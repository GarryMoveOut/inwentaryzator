using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Xml.Linq;
using System.IO; /* file.exists */

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
            //wczytanie bazy z pliku
            XDocument xml = XDocument.Load(baza);

            //wczytanie danych do listy
            List<Produkt> lista_produktow = (
                from produkt in xml.Root.Elements("PRODUKT")
                select new Produkt(
                    produkt.Attribute("EAN13").Value,
                    produkt.Element("NAZWA").Value,
                    produkt.Element("OPIS").Value,
                    int.Parse(produkt.Element("ILOSC").Value),
                    float.Parse(produkt.Element("CENA").Value)
                    )
                ).ToList<Produkt>();

            try
            {
                //Wyszukiwanie po ean
                string find_ean;
                find_ean = ean_textBox.Text;

                Produkt o_produkt = lista_produktow.Find(oElement => oElement.EAN13 == find_ean);
                //ean_textBox.Text = o_produkt.EAN13;
                ilosc_textBox.Text = Convert.ToString(o_produkt.Ilosc);
                cena_textBox.Text = Convert.ToString(o_produkt.Cena);
                nazwa_textBox.Text = o_produkt.Nazwa;
                opis_textBox.Text = o_produkt.Opis;

            }
            catch
            {
                MessageBox.Show("Nie odnaleziono produktu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

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
