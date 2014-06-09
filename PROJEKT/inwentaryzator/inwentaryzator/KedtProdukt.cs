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

namespace inwentaryzator
{
    public partial class KedtProdukt : Form
    {
        public KedtProdukt()
        {
            InitializeComponent();
        }
        //Położenie pliku XML z produktami
        public string baza = @".\inwentaryzator\\data\\baza.xml";
        public string find_ean;
        //wczytanie bazy z pliku
        public XDocument xmlProdukty = XDocument.Load(@".\inwentaryzator\\data\\baza.xml");

        //
        //Przycisk wstecz
        //
        private void BUT_wstecz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //
        //Przycisk wyszukaj
        //
        private void BUT_wyszukaj_Click(object sender, EventArgs e)
        {
            //Wpisanie produktów do listy
            List<cProdukt> lista_produktow = (
                from produkt in (XDocument.Load(@".\inwentaryzator\\data\\baza.xml")).Root.Elements("PRODUKT")
                select new cProdukt(
                    produkt.Attribute("EAN13").Value,
                    produkt.Element("NAZWA").Value,
                    produkt.Element("OPIS").Value,
                    int.Parse(produkt.Element("ILOSC").Value),
                    float.Parse(produkt.Element("CENA").Value)
                    )
                ).ToList<cProdukt>();
            try
            {
                //Wyszukiwanie po ean
                find_ean = txtbox_ean.Text;

                cProdukt o_produkt = lista_produktow.Find(oElement => oElement.EAN13 == find_ean);
                //wypełnienie wszystkich pól formularza
                txtbox_ilosc.Text = Convert.ToString(o_produkt.Ilosc);
                txtbox_cena.Text = Convert.ToString(o_produkt.Cena);
                txtbox_nazwa.Text = o_produkt.Nazwa;
                txtbox_opis.Text = o_produkt.Opis;
            }
            catch
            {
                MessageBox.Show("Nie odnaleziono produktu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //
        //Przycisk zapisz
        //
        private void BUT_zapisz_Click(object sender, EventArgs e)
        {
            try
            {
                //Zmienna do której przepisywana jest wartość 
                int wIlosc;
                double nCena;
                bool blad_form = false;
                wIlosc = Convert.ToInt32(txtbox_ilosc.Text);
                nCena = Convert.ToDouble(txtbox_cena.Text);
                //nCena = System.Math.Round(nCena, 2);


                find_ean = txtbox_ean.Text;
                if (string.IsNullOrWhiteSpace(txtbox_nazwa.Text))
                {
                    blad_form = true;
                }

                if (wIlosc < 0 || nCena < 0 || blad_form == true)
                {
                    MessageBox.Show("Błąd w formularzu", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    //wyszukanie i zmienienie elementu
                    var zmieniany_produkt = xmlProdukty.Root.Elements("PRODUKT").Where(
                                  produkt => produkt.Attribute("EAN13").Value == find_ean);
                    if (zmieniany_produkt.Any())
                    {
                        zmieniany_produkt.First().Element("NAZWA").Value = txtbox_nazwa.Text;
                        zmieniany_produkt.First().Element("OPIS").Value = txtbox_opis.Text;
                        zmieniany_produkt.First().Element("ILOSC").Value = txtbox_ilosc.Text;
                        zmieniany_produkt.First().Element("CENA").Value = txtbox_cena.Text;
                    }

                    //zapis zmian
                    xmlProdukty.Save(baza);

                    MessageBox.Show("Zapisano zmiany", "Sukces");

                    //Wyczyszczenie textboxow
                    ClearTextBoxes(this);
                }
            }
            catch
            {
                MessageBox.Show("Błąd w formularzu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //
        //Przycisk usuń produkt
        //
        private void BUT_usnProd_Click(object sender, EventArgs e)
        {
            DialogResult potw_usun = MessageBox.Show("Czy chcesz usunąć produkt?", "Potwierdź", MessageBoxButtons.YesNo);
            if (potw_usun == DialogResult.Yes)
            {
                var usun_prod = xmlProdukty.Descendants("PRODUKT").Where(o => o.Attribute("EAN13").Value == find_ean);
                usun_prod.Remove();
                //zapisanie zmian w pliku
                xmlProdukty.Save(baza);
                //wyczyszczenie formularza
                ClearTextBoxes(this);
                
                MessageBox.Show("Usunięto produkt", "Potwierdzenie");
            }
        }

        //
        //Przycisk dodaj produkt
        //
        private void BUT_dodajProd_Click(object sender, EventArgs e)
        {
            //Deklaracja nowych danych produktu.
            string nEAN, nCena, nNazwa, nIlosc, nOpis;
            bool poprawny_formularz = true;
            bool czy_istnieje = false;

            nEAN = txtbox_ean.Text;
            nCena = txtbox_cena.Text;
            nNazwa = txtbox_nazwa.Text;
            nIlosc = txtbox_ilosc.Text;
            nOpis = txtbox_opis.Text;

           
            var count = nEAN.Count(Char.IsDigit);//liczenie cyfr w kodzie EAN
            if(count!=13)
            {
                MessageBox.Show("Pole EAN13 zawiera błędny kod.", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                poprawny_formularz = false;
            }
            
            if (string.IsNullOrWhiteSpace(nEAN))
            {
                MessageBox.Show("Pole EAN13 nie może być puste.", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                poprawny_formularz = false;
            }
            if (string.IsNullOrWhiteSpace(nCena) || 0 > double.Parse(nCena))
            {
                MessageBox.Show("Pole cena nie może być puste lub ujemne.", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                poprawny_formularz = false;
            }
            if (string.IsNullOrWhiteSpace(nNazwa))
            {
                MessageBox.Show("Pole nazwa nie może być puste.", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                poprawny_formularz = false;
            }


            //czy podany login już istnieje w bazie
            var dubel = xmlProdukty.Root.Elements("PRODUKT").Where(
                                   produkt => produkt.Attribute("EAN13").Value == nEAN);
            if (dubel.Any())
            {
                czy_istnieje = true;
                MessageBox.Show("Produkt o podanym kodzie EAN13 już istnieje", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (poprawny_formularz == true && czy_istnieje == false)
            {
                xmlProdukty.Root.Add(new XElement("PRODUKT",
                    new XAttribute("EAN13", nEAN),
                    new XElement("NAZWA", nNazwa),
                    new XElement("OPIS", nOpis),
                    new XElement("ILOSC", nIlosc),
                    new XElement("CENA", nCena))
                   );
                xmlProdukty.Save(baza);
                MessageBox.Show("Produkt został zapisany", "Dodano");
                //wyczyszczenie formularza
                ClearTextBoxes(this);
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
}
