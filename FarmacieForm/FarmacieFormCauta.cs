using System;
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
    public partial class FarmacieFormCauta : Form
    {
        IStocareData adminFarmacie;
        public List<string> locatiiSelectate = new List<string>();
        public FarmacieFormCauta()
        {
            InitializeComponent();
            adminFarmacie = StocareFactory.GetAdministratorStocare();

        }

        private void btnClose_click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCauta_Click(object sender, EventArgs e)
        {
            Pharmacy s = adminFarmacie.GetMedicament(txtNume.Text);
            if (s != null)
            {
                lblMesajCauta.Text = s.ConversieLaSir();
                /*
                foreach (var medicamente in boxFarmacie.Controls)
                {
                    if (medicamente is CheckBox)
                    {
                        var disciplinaBox = medicamente as CheckBox;
                        foreach (String dis in s.Locatie)
                            if (disciplinaBox.Text.Equals(dis))
                                disciplinaBox.Checked = true;
                    }
                } */
            }
            else
                lblMesajCauta.Text = "Nu s-a gasit Medicamentul";
            /*
            if (txtNume.Enabled == true)
            {
                txtNume.Enabled = false;
                //dezactivare butoane radio
                foreach (var button in boxTip.Controls)
                {
                    if (button is RadioButton)
                    {
                        var radioButton = button as RadioButton;
                        radioButton.Enabled = false;
                    }
                }
            }
            else
            {
                txtNume.Enabled = true;
                //activare butoane radio
                foreach (var button in boxTip.Controls)
                {
                    if (button is RadioButton)
                    {
                        var radioButton = button as RadioButton;
                        radioButton.Enabled = true;
                    }
                }
                
            }*/
        }

    }
}
