using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace inwentaryzator
{
    public partial class wRaport : Form
    {
        public wRaport(int raport)
        {
            InitializeComponent();
            wypelnij(raport);
        }
        private void wypelnij(int r_raportu)
        {
            switch (r_raportu)
            {
                case -1:
                    MessageBox.Show("Wybierze rodzaj raportu");
                    break;
                case 0:
                    wszystkie_produkty();
                    break;
                case 1:
                    brakujace_produkty();
                    break;
                case 2:
                    spis_pracownikow();
                    break;
            }
            
            
        }
        //
        //Uzupełnianie GridData wszystkimi produktami
        //
        private void wszystkie_produkty()
        {
            XElement root = XElement.Load(@".\inwentaryzator\\data\\baza.xml");
            var produkty = from item in root.Descendants("PRODUKT")
                           select new
                           {
                               EAN13 = item.Attribute("EAN13").Value,
                               nazwa = item.Element("NAZWA").Value,
                               opis = item.Element("OPIS").Value,
                               ilosc = item.Element("ILOSC").Value,
                               cena = item.Element("CENA").Value
                           };

            dataGridView1.DataSource = produkty.ToArray();
        }
        //
        //Uzupełnianie GridData brakującymi produktami
        //
        private void brakujace_produkty()
        {
            XElement root = XElement.Load(@".\inwentaryzator\\data\\baza.xml");
            var produkty = from item in root.Descendants("PRODUKT") where item.Element("ILOSC").Value.Equals("0")
                           select new
                           {
                               EAN13 = item.Attribute("EAN13").Value,
                               nazwa = item.Element("NAZWA").Value,
                               opis = item.Element("OPIS").Value,
                               ilosc = item.Element("ILOSC").Value,
                               cena = item.Element("CENA").Value
                           };

            dataGridView1.DataSource = produkty.ToArray();
        }
        //
        //Uzupełnianie listy GridData pracownikami
        //
        private void spis_pracownikow()
        {
            XElement root = XElement.Load(@".\inwentaryzator\\data\\uzytkownicy.xml");
            var uzytkownik = from item in root.Descendants("UZYTKOWNIK")
                           select new
                           {
                               login = item.Attribute("LOGIN").Value,
                               //haslo = item.Element("HASLO").Value,
                               uprawnienia = item.Element("UPRAWNIENIA").Value,
                               imie = item.Element("IMIE").Value,
                               nazwisko = item.Element("NAZWISKO").Value,
                               informacje = item.Element("INFORMACJE").Value
                           };

            dataGridView1.DataSource = uzytkownik.ToArray();
        }
    }
}
