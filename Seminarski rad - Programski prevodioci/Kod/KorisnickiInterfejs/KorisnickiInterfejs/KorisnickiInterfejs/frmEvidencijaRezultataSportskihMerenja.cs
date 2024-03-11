using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//
using KlasePodataka;


namespace KorisnickiInterfejs
{
    public partial class frmEvidencijaRezultataSportskihMerenja : Form
    {

        private DataTable podaciTabelarni;
        private clsSportistaDB objSportistaDB;


        private void IsprazniKontrole()
        {
            txtIme.Text = "";
            txtPrezime.Text = "";
            cmbPol.SelectedIndex = -1;
            numUpDownStarost.Value = 0;
            numUpDownTezina.Value = 0;
            numUpDownVisina.Value = 0;
            numUpDownBrojTrbusnjaka.Value = 0;
            numUpDownBrojSklekova.Value = 0;
            cmbNacinFiltriranja.SelectedIndex = -1;
            txtFilter.Text = "";
            txtID.Text = "";
        }

        private void AktivirajKontrole()
        {
            txtIme.Enabled = true;
            txtPrezime.Enabled = true;
            cmbPol.Enabled = true;
            numUpDownStarost.Enabled = true;
            numUpDownTezina.Enabled = true;
            numUpDownVisina.Enabled = true;
            numUpDownBrojTrbusnjaka.Enabled = true;
            numUpDownBrojSklekova.Enabled = true;
        }

        private void DeaktivirajKontrole()
        {
            txtIme.Enabled = false;
            txtPrezime.Enabled = false;
            cmbPol.Enabled = false;
            numUpDownStarost.Enabled = false;
            numUpDownTezina.Enabled = false;
            numUpDownVisina.Enabled = false;
            numUpDownBrojTrbusnjaka.Enabled = false;
            numUpDownBrojSklekova.Enabled = false;
        }


        private void PrikaziTabeluPodataka(DataTable TabelaPodataka)
        {
            dgvSpisakSportista.DataSource = TabelaPodataka;
            dgvSpisakSportista.Refresh();
        }


        private void SnimiXML(DataTable podaci, string putanja)
        {
            DataSet dsPodaciEksport = new DataSet();

            DataTable podaciZaEksport = new DataTable();
            podaciZaEksport = podaci.Copy();
            dsPodaciEksport.Tables.Add(podaciZaEksport);
            dsPodaciEksport.WriteXml(putanja);
        }

        public frmEvidencijaRezultataSportskihMerenja()
        {
            InitializeComponent();
        }

        private void frmSaViseslojnimSopstvenimKlasama_Load(object sender, EventArgs e)
        {

            objSportistaDB = new clsSportistaDB(Parametri.stringKonekcije);

            cmbPol.Items.Add("Drugo");
            cmbPol.Items.Add("Žensko");
            cmbPol.Items.Add("Muško");
            cmbPol.SelectedIndex = -1;

            cmbNacinFiltriranja.Items.Add("Prema imenu");
            cmbNacinFiltriranja.Items.Add("Prema prezimenu");
            cmbNacinFiltriranja.Items.Add("Prema polu");
            cmbNacinFiltriranja.SelectedIndex = -1;

            txtID.Visible = false;

        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            IsprazniKontrole();
            AktivirajKontrole();
            txtIme.Focus(); 
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            string poruka = "";

            clsSportista objNovSportista = new clsSportista();
            objNovSportista.Ime = txtIme.Text;
            objNovSportista.Prezime = txtPrezime.Text;
            objNovSportista.Pol = cmbPol.SelectedItem?.ToString();
            objNovSportista.Starost = Convert.ToInt32(numUpDownStarost.Value);
            objNovSportista.Visina = Convert.ToInt32(numUpDownVisina.Value);
            objNovSportista.Tezina = Convert.ToInt32(numUpDownTezina.Value);
            objNovSportista.BrojTrbusnjaka = Convert.ToInt32(numUpDownBrojTrbusnjaka.Value);
            objNovSportista.BrojSklekova = Convert.ToInt32(numUpDownBrojSklekova.Value);

            if (string.IsNullOrEmpty(objNovSportista.Ime) || string.IsNullOrEmpty(objNovSportista.Prezime) || string.IsNullOrEmpty(objNovSportista.Pol))
            {
                poruka = "Nisu uneseni svi obavezni podaci!";
            }
            else
            {
                int ukupnoSnimljeno = objSportistaDB.SnimiPodatke(objNovSportista);
                if (ukupnoSnimljeno > 0)
                {
                    poruka = "Uspesno snimljeno!";
                }
                else
                {
                    poruka = "Nije uspesno snimljeno!";
                }
            }
            MessageBox.Show(poruka);
        }


        private void btnOdustani_Click(object sender, EventArgs e)
        {
            IsprazniKontrole();
            DeaktivirajKontrole();
        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
			switch (cmbNacinFiltriranja.SelectedIndex)
			{
                case 0 : podaciTabelarni = objSportistaDB.UcitajFiltriranoIme(txtFilter.Text);
                    break;
                case 1 : podaciTabelarni = objSportistaDB.UcitajFiltriranoPrezime(txtFilter.Text);
                    break;
                case 2 : podaciTabelarni = objSportistaDB.UcitajFiltriranoPol(txtFilter.Text);
                    break;
            }
            PrikaziTabeluPodataka(podaciTabelarni);
        }

        private void btnSve_Click(object sender, EventArgs e)
        {
            podaciTabelarni = objSportistaDB.UcitajSve();
            PrikaziTabeluPodataka(podaciTabelarni);
        }

        private void btnExportXML_Click(object sender, EventArgs e)
        {
            SnimiXML(podaciTabelarni, Parametri.putanjaXML);
            MessageBox.Show("Uspesno realizovan eksport podataka!"); 
        }
        private void dgvSpisakSportista_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSpisakSportista.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvSpisakSportista.SelectedRows[0];

                if (selectedRow.Cells["Ime"].Value != null)
                {
                    txtIme.Text = selectedRow.Cells["Ime"].Value.ToString();
                }

                if (selectedRow.Cells["Prezime"].Value != null)
                {
                    txtPrezime.Text = selectedRow.Cells["Prezime"].Value.ToString();
                }

                string pol = selectedRow.Cells["Pol"].Value.ToString();
                switch (pol)
                {
                    case "Muško":
                        cmbPol.SelectedIndex = 2;
                        break;
                    case "Žensko":
                        cmbPol.SelectedIndex = 1;
                        break;
                    case "Drugo":
                        cmbPol.SelectedIndex = 0;
                        break;
                }

                if (selectedRow.Cells["Starost"].Value != null)
                {
                    numUpDownStarost.Value = Convert.ToDecimal(selectedRow.Cells["Starost"].Value);
                }

                if (selectedRow.Cells["Tezina"].Value != null)
                {
                    numUpDownTezina.Value = Convert.ToDecimal(selectedRow.Cells["Tezina"].Value);
                }

                if (selectedRow.Cells["Visina"].Value != null)
                {
                    numUpDownVisina.Value = Convert.ToDecimal(selectedRow.Cells["Visina"].Value);
                }

                if (selectedRow.Cells["BrojTrbusnjaka"].Value != null)
                {
                    numUpDownBrojTrbusnjaka.Value = Convert.ToDecimal(selectedRow.Cells["BrojTrbusnjaka"].Value);
                }

                if (selectedRow.Cells["BrojSklekova"].Value != null)
                {
                    numUpDownBrojSklekova.Value = Convert.ToDecimal(selectedRow.Cells["BrojSklekova"].Value);
                }

                if (selectedRow.Cells["ID"].Value != null)
                {
                    txtID.Text = selectedRow.Cells["ID"].Value.ToString();
                }
            }
        }

        private void dgvSpisakSportista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvSpisakSportista.Rows[e.RowIndex];

                if (selectedRow.Cells["Ime"].Value != null)
                {
                    txtIme.Text = selectedRow.Cells["Ime"].Value.ToString();
                }

                if (selectedRow.Cells["Prezime"].Value != null)
                {
                    txtPrezime.Text = selectedRow.Cells["Prezime"].Value.ToString();
                }

                if (selectedRow.Cells["Pol"].Value != null)
                {
                    string pol = selectedRow.Cells["Pol"].Value.ToString();
                    switch (pol)
                    {
                        case "Muško":
                            cmbPol.SelectedIndex = 2;
                            break;
                        case "Žensko":
                            cmbPol.SelectedIndex = 1;
                            break;
                        case "Drugo":
                            cmbPol.SelectedIndex = 0;
                            break;
                    }
                }

                if (selectedRow.Cells["Starost"].Value != null)
                {
                    numUpDownStarost.Value = Convert.ToDecimal(selectedRow.Cells["Starost"].Value);
                }

                if (selectedRow.Cells["Visina"].Value != null)
                {
                    numUpDownVisina.Value = Convert.ToDecimal(selectedRow.Cells["Visina"].Value);
                }

                if (selectedRow.Cells["Tezina"].Value != null)
                {
                    numUpDownTezina.Value = Convert.ToDecimal(selectedRow.Cells["Tezina"].Value);
                }

                if (selectedRow.Cells["BrojTrbusnjaka"].Value != null)
                {
                    numUpDownBrojTrbusnjaka.Value = Convert.ToDecimal(selectedRow.Cells["BrojTrbusnjaka"].Value);
                }

                if (selectedRow.Cells["BrojSklekova"].Value != null)
                {
                    numUpDownBrojSklekova.Value = Convert.ToDecimal(selectedRow.Cells["BrojSklekova"].Value);
                }

                if (selectedRow.Cells["ID"].Value != null)
                {
                    txtID.Text = selectedRow.Cells["ID"].Value.ToString();
                }
            }
        }

        private void btnBrisanje_Click(object sender, EventArgs e)
        {
            string poruka = "";

            clsSportista objSportista = new clsSportista();

            if (!string.IsNullOrEmpty(txtID.Text))
            {
                objSportista.ID = Convert.ToInt32(txtID.Text);

                int ukupnoSnimljeno = objSportistaDB.ObrisiPodatke(objSportista);
                if (ukupnoSnimljeno > 0)
                {
                    poruka = "Uspesno obrisano!";
                }
                else
                {
                    poruka = "Nije uspesno obrisano!";
                }
            }
            else
            {
                poruka = "Niste izabrali sportsko merenje za brisanje!";
            }
            DeaktivirajKontrole();
            MessageBox.Show(poruka);
        }


        private void btnIzmena_Click(object sender, EventArgs e)
        {
            string poruka = "";

            clsSportista objSportista = new clsSportista();
            objSportista.Ime = txtIme.Text;
            objSportista.Prezime = txtPrezime.Text;
            objSportista.Pol = cmbPol.SelectedItem?.ToString();
            objSportista.Starost = Convert.ToInt32(numUpDownStarost.Value);
            objSportista.Visina = Convert.ToInt32(numUpDownVisina.Value);
            objSportista.Tezina = Convert.ToInt32(numUpDownTezina.Value);
            objSportista.BrojTrbusnjaka = Convert.ToInt32(numUpDownBrojTrbusnjaka.Value);
            objSportista.BrojSklekova = Convert.ToInt32(numUpDownBrojSklekova.Value);

            if (string.IsNullOrEmpty(objSportista.Ime) || string.IsNullOrEmpty(objSportista.Prezime) || string.IsNullOrEmpty(objSportista.Pol) || string.IsNullOrEmpty(txtID.Text))
            {
                poruka = "Nisu uneseni svi obavezni podaci!";
            }
            else
            {
                objSportista.ID = Convert.ToInt32(txtID.Text);
                int ukupnoSnimljeno = objSportistaDB.IzmeniPodatke(objSportista);
                if (ukupnoSnimljeno > 0)
                {
                    poruka = "Uspesno izmenjeno!";
                }
                else
                {
                    poruka = "Nije uspesno izmenjeno!";
                }
            }
            MessageBox.Show(poruka);
        }

    }
}
