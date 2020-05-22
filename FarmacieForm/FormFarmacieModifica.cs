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
    public partial class FormFarmacieModifica : Form
    {
        IStocareData adminFarmacie;
        List<string> locatiiSelectate = new List<string>();
        public FormFarmacieModifica()
        {
            InitializeComponent();
            adminFarmacie = StocareFactory.GetAdministratorStocare();

        }
        private void btnClose_click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnModifica_Click(object sender, EventArgs e)
        {

            CodEroare codValidare = Validare(txtNume.Text, txtPret.Text);

            if (codValidare != CodEroare.CORECT)
            {
                MarcheazaControaleCuDateIncorecte(codValidare);
            }
            else
            {
                Pharmacy p = new Pharmacy(txtNume.Text, Convert.ToInt32(txtPret.Text), GetTipMedicamentSelectat().ToString(), cmbValabil.Text);
                p.Locatie = new List<string>();
                p.Locatie.AddRange(locatiiSelectate);
               

                adminFarmacie.UpdateMedicament(p);
                lblMesajModifica.Text = "Medicamentul a fost actualizat";

                //resetarea controalelor pentru a introduce datele unui student nou
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
            if (pret == string.Empty)
            {
                rezultatValidare |= CodEroare.PRET_INCORET;
            }

            // verificare ca este cel putin un program studiu selectat
            int optiuneSelectata = 0;
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
        /*
        private void lstAfisare_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetareControale();
            Pharmacy p = null;
            try
            {
                p= adminFarmacie.GetPersoanaByIndex(lstAfisare.SelectedIndex);
            }
            catch (Exception ex)
            {
                lblMesaj.Text = "Eroare: " + ex.Message;
            }

            if (s != null)
            {
                lblID.Text = s.IdPersoana.ToString();

                txtNume.Text = s.Nume;
                txtPrenume.Text = s.Prenume;

                foreach (var gp in gpbGrup.Controls)
                {
                    if (gp is RadioButton)
                    {
                        var gpBox = gp as RadioButton;
                        if (gpBox.Text == s.Grupul.ToString())
                        {
                            gpBox.Checked = true;
                        }
                    }
                }

                foreach (var social in gpbSocial.Controls)
                {
                    if (social is CheckBox)
                    {
                        var socialBox = social as CheckBox;
                        foreach (String soc in s.Social)
                            if (socialBox.Text.Equals(soc))
                                socialBox.Checked = true;
                    }
                }

                cmbSalvare.Text = s.Salvare;
            }
        }
        public Pharmacy GetPersoanaByIndex(int index)
        {
            try
            {
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Pharmacy persoana = new Pharmacy(line);
                        if (persoana.IdMedicament == index)
                            return persoana;

                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            return null;
        } */
    } 
}
