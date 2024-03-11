using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//
using System.Data;
using SqlDBUtils;

namespace KlasePodataka
{
    
    public class clsSportistaDB
    {
        
         // atributi
    private string pStringKonekcije="";

   
        
        // metode
        

        // konstruktor

    public clsSportistaDB(string noviStringKonekcije)
    {
        pStringKonekcije = noviStringKonekcije; 
    }

        // javne metode
    public int SnimiPodatke(clsSportista objNovSportista)
        {
            int brojslogova = 0;

            // preuzimanje iz korisnickog interfejsa
            // radi preglednosti koda postavljamo promenljive
            string Ime = objNovSportista.Ime;
            string Prezime = objNovSportista.Prezime;
            string Pol = objNovSportista.Pol;
			string Starost = objNovSportista.Starost.ToString();
			string Visina = objNovSportista.Visina.ToString();
			string Tezina = objNovSportista.Tezina.ToString();
			string BrojTrbusnjaka = objNovSportista.BrojTrbusnjaka.ToString();
			string BrojSklekova = objNovSportista.BrojSklekova.ToString();

			clsSqlKonekcija objKonekcija = new clsSqlKonekcija(pStringKonekcije);
            objKonekcija.OtvoriKonekciju();


            clsSqlTabela objTabela = new clsSqlTabela(objKonekcija, "Sportista");
            string SQLNaredba = "Insert into Sportista (Ime, Prezime, Pol, Starost, Visina, Tezina, BrojTrbusnjaka, BrojSklekova) Values ('" + Ime + "', '" + Prezime +"', '" + Pol + "', " + Starost + ", " + Visina + ", " + Tezina + ", " + BrojTrbusnjaka + ", " + BrojSklekova + ")";
            bool uspeh = objTabela.IzvrsiAzuriranje(SQLNaredba);
            if (uspeh)
            {
                brojslogova = 1;
            }
            else
            {
                brojslogova = 0;
            }
            objKonekcija.ZatvoriKonekciju();
        
            return brojslogova;
        }

		public int ObrisiPodatke(clsSportista objSportista)
		{
			int brojslogova = 0;

			// preuzimanje iz korisnickog interfejsa
			// radi preglednosti koda postavljamo promenljive
			string ID = objSportista.ID.ToString();

			clsSqlKonekcija objKonekcija = new clsSqlKonekcija(pStringKonekcije);
			objKonekcija.OtvoriKonekciju();


			clsSqlTabela objTabela = new clsSqlTabela(objKonekcija, "Sportista");
			string SQLNaredba = "Delete from Sportista where ID = " + ID;
			bool uspeh = objTabela.IzvrsiAzuriranje(SQLNaredba);
			if (uspeh)
			{
				brojslogova = 1;
			}
			else
			{
				brojslogova = 0;
			}
			objKonekcija.ZatvoriKonekciju();

			return brojslogova;
		}

		public int IzmeniPodatke(clsSportista objSportista)
		{
			int brojslogova = 0;

			// preuzimanje iz korisnickog interfejsa
			// radi preglednosti koda postavljamo promenljive
			string ID = objSportista.ID.ToString();
			string Ime = objSportista.Ime;
			string Prezime = objSportista.Prezime;
			string Pol = objSportista.Pol;
			string Starost = objSportista.Starost.ToString();
			string Visina = objSportista.Visina.ToString();
			string Tezina = objSportista.Tezina.ToString();
			string BrojTrbusnjaka = objSportista.BrojTrbusnjaka.ToString();
			string BrojSklekova = objSportista.BrojSklekova.ToString();

			clsSqlKonekcija objKonekcija = new clsSqlKonekcija(pStringKonekcije);
			objKonekcija.OtvoriKonekciju();


			clsSqlTabela objTabela = new clsSqlTabela(objKonekcija, "Sportista");
			string SQLNaredba = "Update Sportista set Ime = '" + Ime + "', Prezime = '" + Prezime + "', Pol = '" + Pol + "', Starost = " + Starost + ", Visina = " + Visina + ", Tezina = " + Tezina + ", BrojTrbusnjaka = " + BrojTrbusnjaka + ", BrojSklekova = " + BrojSklekova + " where ID = " + @ID;
			bool uspeh = objTabela.IzvrsiAzuriranje(SQLNaredba);
			if (uspeh)
			{
				brojslogova = 1;
			}
			else
			{
				brojslogova = 0;
			}
			objKonekcija.ZatvoriKonekciju();

			return brojslogova;
		}

		public DataTable UcitajSve()
    {
        DataTable TabelaPodataka = new DataTable();

        clsSqlKonekcija objKonekcija = new clsSqlKonekcija(pStringKonekcije);
        objKonekcija.OtvoriKonekciju();


        clsSqlTabela objTabela = new clsSqlTabela(objKonekcija, "Sportista");
        string SQLNaredba = "select * from Sportista";
        DataSet dsPodaci = objTabela.DajPodatke(SQLNaredba);
        TabelaPodataka = dsPodaci.Tables[0];

        objKonekcija.ZatvoriKonekciju();
        return TabelaPodataka;
    }

    public DataTable UcitajFiltriranoIme(string Filter)
    {
        DataTable TabelaPodataka = new DataTable();

        clsSqlKonekcija objKonekcija = new clsSqlKonekcija(pStringKonekcije);
        objKonekcija.OtvoriKonekciju();


        clsSqlTabela objTabela = new clsSqlTabela(objKonekcija, "Sportista");
        string SQLNaredba = "select * from Sportista where Ime like '%" + Filter + "%'";
        DataSet dsPodaci = objTabela.DajPodatke(SQLNaredba);
        TabelaPodataka = dsPodaci.Tables[0];

        objKonekcija.ZatvoriKonekciju();

        return TabelaPodataka;
    }
	public DataTable UcitajFiltriranoPrezime(string Filter)
	{
		DataTable TabelaPodataka = new DataTable();

		clsSqlKonekcija objKonekcija = new clsSqlKonekcija(pStringKonekcije);
		objKonekcija.OtvoriKonekciju();


		clsSqlTabela objTabela = new clsSqlTabela(objKonekcija, "Sportista");
		string SQLNaredba = "select * from Sportista where Prezime like '%" + Filter + "%'";
		DataSet dsPodaci = objTabela.DajPodatke(SQLNaredba);
		TabelaPodataka = dsPodaci.Tables[0];

		objKonekcija.ZatvoriKonekciju();

		return TabelaPodataka;
	}
	public DataTable UcitajFiltriranoPol(string Filter)
	{
		DataTable TabelaPodataka = new DataTable();

		clsSqlKonekcija objKonekcija = new clsSqlKonekcija(pStringKonekcije);
		objKonekcija.OtvoriKonekciju();


		clsSqlTabela objTabela = new clsSqlTabela(objKonekcija, "Sportista");
		string SQLNaredba = "select * from Sportista where Pol like '%" + Filter + "%'";
		DataSet dsPodaci = objTabela.DajPodatke(SQLNaredba);
		TabelaPodataka = dsPodaci.Tables[0];

		objKonekcija.ZatvoriKonekciju();

		return TabelaPodataka;
	}// metoda

		
	} // klasa
} // namespace
