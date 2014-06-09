using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace InwentaryzatorTEST
{
    [TestClass]
    public class cProduktTest
    {
        public string EAN13 { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public int Ilosc { get; set; }
        public float Cena { get; set; }

        //Konstruktor
        
        public cProduktTest(string kod, string nazwa, string opis, int ilosc, float cena)
        {
            EAN13 = kod;
            Nazwa = nazwa;
            Opis = opis;
            Ilosc = ilosc;
            Cena = cena;
        }

    }
}
