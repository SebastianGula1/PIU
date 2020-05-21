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

            Pharmacy p = new Pharmacy(txtNume.Text, Convert.ToInt32(txtPret.Text), GetTipMedicamentSelectat().ToString(), cmbValabil.Text);
            p.Locatie = new List<string>();
            p.Locatie.AddRange(locatiiSelectate);
            adminFarmacie.AddM(p);
            lblMesajAdauga.Text = "S-a adaugat Medicamentul";

            ResetareControale();

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

        private void btnClose_click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
