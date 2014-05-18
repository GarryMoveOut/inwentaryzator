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
                wIlosc = Convert.ToInt32(txtbox_ilosc.Text);

                find_ean = txtbox_ean.Text;

                if (wIlosc < 0)
                {
                    MessageBox.Show("Błędna ilość", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    //wyszukanie i zmienienie elementu
                    var produkty = xmlProdukty.Root.Elements("PRODUKT").Where(
                                produkt => produkt.Attribute("EAN13").Value == find_ean);
                    if (produkty.Any())
                        produkty.First().Element("ILOSC").Value = Convert.ToString(wIlosc);

                    //zapis zmian
                    xmlProdukty.Save(baza);

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

        //
        //Przyciks usuń produkt
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
