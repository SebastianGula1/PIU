﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Librarie;
using NivelAccesDate;
using System.Windows.Forms;
using System.IO;


namespace FarmacieForm
{
    public partial class FarmacieFormAfisare : Form
    {
        IStocareData adminFarmacie;
        List<string> locatiiSelectate = new List<string>();

        public FarmacieFormAfisare()

        {
            InitializeComponent();
            adminFarmacie = StocareFactory.GetAdministratorStocare();


        }

        private void btnAfiseaza_click(Object sender, EventArgs e)
            {
                List<Pharmacy> medicamente = adminFarmacie.GetMedicamente();

                AdaugaMedicamenteInControlListbox(medicamente);
                AdaugaMedicamenteInControlDataGridView(medicamente);

            }
            private void AdaugaMedicamenteInControlListbox(List<Pharmacy> medicamante)
            {
                lstAfisare.Items.Clear();


                foreach (Pharmacy s in medicamante)
                {
                    lstAfisare.Items.Add(s.ConversieLaSir_Fisier());
                }
            }
            private void AdaugaMedicamenteInControlDataGridView(List<Pharmacy> medicamente)
            {
                dataGridMedicamente.DataSource = null;


                // dataGridMedicamente.DataSource = medicamente;
                dataGridMedicamente.DataSource = medicamente.Select(s => new {s.IdMedicament, s.Nume, s.Pret, s.Tip, s.Valabilitate, Locatie = string.Join(",", s.MedicamenteAsString) }).ToList();

            }
            
            private void btnModificaPagina_click(object sender, EventArgs e)
        {
            var myForm = new FormFarmacieModifica();
            myForm.Show();
        }
        private void btnClose_click(object sender, EventArgs e)
        {
            this.Close();
        }
       
    } 
}
