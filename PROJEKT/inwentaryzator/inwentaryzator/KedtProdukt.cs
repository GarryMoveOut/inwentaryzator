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
        public XDocument xml = XDocument.Load(@".\inwentaryzator\\data\\baza.xml");

        private void BUT_wstecz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

    }
}
