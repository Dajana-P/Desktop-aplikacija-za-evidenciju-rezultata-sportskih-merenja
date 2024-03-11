using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace KlasePodataka
{
    public class clsListaSportista
    {
        // ATRIBUTI

        // polja - sustinski atributi
        private List<clsSportista> pListaSportista;

        // public property

        public List<clsSportista> ListaSportista
        {
            get
            {
                return pListaSportista;
            }
            set
            {
                if (this.pListaSportista != value)
                    this.pListaSportista = value;
            }
        }

         
          // --------- METODE
        
        //konstruktor

        public clsListaSportista()
        {
            pListaSportista = new List<clsSportista>();

        }

        // javne metode
        public void DodajNoviElement(clsSportista objNovSportista)
        {
            pListaSportista.Add(objNovSportista);  
        }

        public void ObrisiElement(clsSportista objSportistaZaBrisanje)
        {
            pListaSportista.Remove(objSportistaZaBrisanje);  
        }

        public void ObrisiElementNaPoziciji(int pozicija)
        {
            pListaSportista.RemoveAt(pozicija);
        }
     
    }
}
