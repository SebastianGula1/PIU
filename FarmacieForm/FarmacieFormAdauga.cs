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
    public partial class FarmacieFormAdauga : Form
    {
        IStocareData adminFarmacie;
        public  List<string> locatiiSelectate = new List<string>();

        public FarmacieFormAdauga()
        {
            InitializeComponent();
            adminFarmacie = StocareFactory.GetAdministratorStocare();

        }
        private void btnAdauga_Click(Object sender, EventArgs e)
        {
            CodEroare codValidare = Validare(txtNume.Text, txtPret.Text);

            if (codValidare != CodEroare.CORECT)
            {
                MarcheazaControaleCuDateIncorecte(codValidare);
                lblMesajAdauga.Text = "Eroare la adaugarea medicamentului";
            }

            else
            {

                Pharmacy p = new Pharmacy(txtNume.Text, Convert.ToInt32(txtPret.Text), GetTipMedicamentSelectat().ToString(), cmbValabil.Text);
                p.Locatie = new List<string>();
                p.Locatie.AddRange(locatiiSelectate);
                adminFarmacie.AddM(p);
                lblMesajAdauga.Text = "S-a adaugat Medicamentul";

                ResetareControale();
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
        private void MarcheazaControaleCuDateIncorecte(CodEroare codValidare)
        {
            if ((codValidare & CodEroare.NUME_INCORECT) == CodEroare.NUME_INCORECT)
            {
                lblNume.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.PRET_INCORET) == CodEroare.PRET_INCORET)
            {
                lblPret.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.TIP_INCORECT) == CodEroare.TIP_INCORECT)
            {
                lblTip.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.LOCATIE_INCORECT) == CodEroare.LOCATIE_INCORECT)
            {
                lblFarmacie.ForeColor = Color.Red;
            }
           
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
        private CodEroare Validare(string nume, string pret)
        {
            CodEroare rezultatValidare = CodEroare.CORECT;
            if (nume == string.Empty)
            {
                rezultatValidare |= CodEroare.NUME_INCORECT;
            }
            if (pret == string.Empty )
            {
                rezultatValidare |= CodEroare.PRET_INCORET;
            }
           
            // verificare ca este cel putin un program studiu selectat
            int  optiuneSelectata = 0;
            foreach (var control in boxTip.Controls)
            {
                RadioButton rdb = null;
                try
                {
                    rdb = (RadioButton)control;
                }
                catch { }

                if (rdb != null && rdb.Checked == true)
                    optiuneSelectata = 1;
            }
            if (optiuneSelectata == 0)
                rezultatValidare |= CodEroare.LOCATIE_INCORECT;
                
            return rezultatValidare;
        }

        private void btnClose_click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
