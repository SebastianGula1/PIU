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
    public partial class FarmacieForm : Form

    {
        IStocareData adminFarmacie;
        List<string> locatiiSelectate = new List<string>();

        public FarmacieForm()
        {
            InitializeComponent();
            adminFarmacie = StocareFactory.GetAdministratorStocare();
        }
              
        private void btnAfisarePagina_Click(Object sender, EventArgs e)
        {
            var myForm = new FarmacieFormAfisare();
            myForm.Show();

        }
        private void btnAdaugaPagina_Click(Object sender, EventArgs e)
        {
            var myForm = new FarmacieFormAdauga();
            myForm.Show();
        }
        private void btnCautaPagina_Click(Object sender, EventArgs e)
        {
            var myForm = new FarmacieFormCauta();
            myForm.Show();
        }




        /*
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


            dataGridMedicamente.DataSource = medicamente.Select(s => new { s.Nume, s.Pret, s.Tip, s.Valabilitate, Locatie = string.Join(",", s.MedicamenteAsString) }).ToList();

        }
         
           private void btnAdauga_Click(Object sender, EventArgs e)
        {

            Pharmacy p = new Pharmacy(txtNume.Text, Convert.ToInt32(txtPret.Text), GetTipMedicamentSelectat().ToString(), cmbValabil.Text);
            p.Locatie = new List<string>();
            p.Locatie.AddRange(locatiiSelectate);
            adminFarmacie.AddM(p);
            lblMesajF.Text = "S-a adaugat Medicamentul";

            ResetareControale();

        }


        private void ckbDiscipline_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBoxControl = sender as CheckBox;


            string farmacieSelectata = checkBoxControl.Text;

            //verificare daca checkbox-ul asupra caruia s-a actionat este selectat
            if (checkBoxControl.Checked == true)
                locatiiSelectate.Add(farmacieSelectata);
            else
                locatiiSelectate.Remove(farmacieSelectata);
        }
        private void btnCauta_Click(object sender, EventArgs e)
        {
            Pharmacy s = adminFarmacie.GetMedicament(txtNume.Text);
            if (s != null)
            {
                lblMesajF.Text = s.ConversieLaSir();

                foreach (var medicamente in boxFarmacie.Controls)
                {
                    if (medicamente is CheckBox)
                    {
                        var disciplinaBox = medicamente as CheckBox;
                        foreach (String dis in s.Locatie)
                            if (disciplinaBox.Text.Equals(dis))
                                disciplinaBox.Checked = true;
                    }
                }
            }
            else
                lblMesajF.Text = "Nu s-a gasit Medicamentul";

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
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            Pharmacy s = adminFarmacie.GetMedicament(txtNume.Text);
            if (s != null)
            {
                int nrNoteVechi = s.GetPret();
                int nrNoteNoi = s.Pret;
                if (nrNoteNoi == nrNoteVechi)
                {
                    adminFarmacie.UpdateMedicament(s);
                    lblMesajF.Text = "Modificare efectuata";
                    txtNume.Enabled = true;
                }
                else
                {
                    lblMesajF.Text = "Numarul de note nu corespunde cu notele anterioare ale studentului";
                }
            }
            else
            {
                lblMesajF.Text = "Student inexistent";
            }
        }
        private tip GetTipMedicamentSelectat()
        {
            if (radioBtnPilula.Checked)
                return tip.Pilula;
            if (radioBtnSirop.Checked)
                return tip.Sirop;
            if (radioBtnUnguent.Checked)
                return tip.Unguent;
            if (radioBtnInjectie.Checked)
                return tip.Injectie;

            return tip.Necunoscut;
        }
        private void ResetareControale()
        {
            txtNume.Text = string.Empty;
            radioBtnPilula.Checked = false;
            radioBtnSirop.Checked = false;
            radioBtnUnguent.Checked = false;
            radioBtnInjectie.Checked = false;
            chkCatena.Checked = false;
            chkSensiBlue.Checked = false;
            chkHelpNet.Checked = false;
            chkDona.Checked = false;
            chkBluePharm.Checked = false;
            locatiiSelectate.Clear();
            cmbValabil.Text = string.Empty;
        }
    
        
        private void btnAfisarePagina_Click(Object sender, EventArgs e)
        {
            openChildForm(new FarmacieFormAfisare());
        }
        private void btnAdaugaPagina_Click(Object sender, EventArgs e)
        {
            openChildForm(new FarmacieFormAdauga());
        }

        private Form activeForm = null;
        private void openChildForm( Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            //panelChildForm.Controls.Add(childForm);
           // panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();


        } */

        public void AddM(Pharmacy x)
        {
            throw new NotImplementedException();
        }

        public Pharmacy[] GetM(out int nrMed)
        {
            throw new NotImplementedException();
        }
    }
}
