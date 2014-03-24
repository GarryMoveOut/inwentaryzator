using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inwentaryzator
{
    public partial class pracownik : Form
    {
        public pracownik()
        {
            InitializeComponent();
        }
        //Położenie pliku XML z produktami
        public string baza = @".\inwentaryzator\\data\\baza.xml";

        private void wyloguj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_wyszukaj_Click(object sender, EventArgs e)
        {

        }
    }
    
    /// <summary>
    /// Klasa produktów
    /// </summary>
    public class Produkt
    {
        public string EAN13 { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public int Ilosc { get; set; }
        public float Cena { get; set; }

        public Produkt(string kod, string nazwa, string opis, int ilosc, float cena)
        {
            EAN13 = kod;
            Nazwa = nazwa;
            Opis = opis;
            Ilosc = ilosc;
            Cena = cena;
        }

    }
}
