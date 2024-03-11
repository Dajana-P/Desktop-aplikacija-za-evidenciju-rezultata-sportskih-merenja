using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KlasePodataka
{
    public class clsSportista
    {
        //-------------ATRIBUTI

        // polja - sustinski atributi
        private int pID;
        private string pIme;
		private string pPrezime;
        private string pPol;
        private int pStarost;
        private int pVisina;
		private int pTezina;
        private int pBrojTrbusnjaka;
        private int pBrojSklekova;

		// public property
		public int ID
		{
			get
			{
				return pID;
			}
			set
			{
				if (this.pID != value)
					this.pID = value;
			}
		}
		public string Ime
        {
            get
            {
                return pIme;
            }
            set
            {
                if (this.pIme != value)
                    this.pIme = value;
            }
        }
		public string Prezime
		{
			get
			{
				return pPrezime;
			}
			set
			{
				if (this.pPrezime != value)
					this.pPrezime = value;
			}
		}
		public string Pol
        {
            get
            {
                return pPol;
            }
            set
            {
                if (this.pPol != value)
                    this.pPol = value;
            }
        }
		public int Starost
		{
			get
			{
				return pStarost;
			}
			set
			{
				if (this.pStarost != value)
					this.pStarost = value;
			}
		}
		public int Visina
		{
			get
			{
				return pVisina;
			}
			set
			{
				if (this.pVisina != value)
					this.pVisina = value;
			}
		}
		public int Tezina
		{
			get
			{
				return pTezina;
			}
			set
			{
				if (this.pTezina != value)
					this.pTezina = value;
			}
		}
		public int BrojTrbusnjaka
		{
			get
			{
				return pBrojTrbusnjaka;
			}
			set
			{
				if (this.pBrojTrbusnjaka != value)
					this.pBrojTrbusnjaka = value;
			}
		}
		public int BrojSklekova
		{
			get
			{
				return pBrojSklekova;
			}
			set
			{
				if (this.pBrojSklekova != value)
					this.pBrojSklekova = value;
			}
		}

		// --------- METODE

		//konstruktor

		public clsSportista()
        {
            // inicijalizacija polja

			pIme="";
			pPrezime="";
			pPol="";
			pStarost=0;
			pVisina=0;
			pTezina=0;
			pBrojTrbusnjaka=0;
			pBrojSklekova=0;
		}

    }
}
