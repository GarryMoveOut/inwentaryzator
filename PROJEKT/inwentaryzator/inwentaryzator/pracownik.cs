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
        //**************zdefiniowane********************
        //Położenie pliku XML z produktami
        public string baza = @".\inwentaryzator\\data\\baza.xml";
        public string find_ean;
        //wczytanie bazy z pliku
        public XDocument xml = XDocument.Load(@".\inwentaryzator\\data\\baza.xml");
        //lista obiektów klasy Produkt
        List<Produkt> lista_produktow = (
                from produkt in (XDocument.Load(@".\inwentaryzator\\data\\baza.xml")).Root.Elements("PRODUKT")
                select new Produkt(
                    produkt.Attribute("EAN13").Value,
                    produkt.Element("NAZWA").Value,
                    produkt.Element("OPIS").Value,
                    int.Parse(produkt.Element("ILOSC").Value),
                    float.Parse(produkt.Element("CENA").Value)
                    )
                ).ToList<Produkt>();
        
        

        
        /// <summary>
        /// Metoda do przycisku wyloguj
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wyloguj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Metoda do przycisku wyszukaj
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void but_wyszukaj_Click(object sender, EventArgs e)
        {
            

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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //Zmienna do której przepisywana jest wartość 
                int wIlosc;
                wIlosc = Convert.ToInt32(ilosc_textBox.Text);

                find_ean = ean_textBox.Text;

                if(wIlosc < 0)
                {
                    MessageBox.Show("Błędna ilość", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    //Produkt o_produkt = lista_produktow.Find(oElement => oElement.EAN13 == find_ean);
                    //o_produkt.Ilosc = wIlosc;

                    //wyszukanie i zmienienie elementu
                    var produkty = xml.Root.Elements("PRODUKT").Where(
                                produkt => produkt.Attribute("EAN13").Value == find_ean);
                    if (produkty.Any())
                        produkty.First().Element("ILOSC").Value = Convert.ToString(wIlosc);
                    
                    //zapis zmian
                    xml.Save(baza);

                    MessageBox.Show("Zapisano zmiany", "Sukces");

                    //Wyczyszczenie textboxow
                    ClearTextBoxes(this);
                }
            }
            catch
            {
                MessageBox.Show("Nieznany błąd aplikacji", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Metoda do czyszczenia wszystkich tekstboksów w oknie
        /// </summary>
        /// <param name="control">this</param>
        public void ClearTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                if (c.HasChildren)
                {
                    ClearTextBoxes(c);
                }
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

        //Konstruktor
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
