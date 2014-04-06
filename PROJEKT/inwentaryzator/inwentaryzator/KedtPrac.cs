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
    public partial class KedtPrac : Form
    {
        //deklaracja zmiennych
        public string szLogin;
        public string wUpr;
        

        public KedtPrac()
        {
            InitializeComponent();
            load_cbox();
        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void wyszukaj_but_Click(object sender, EventArgs e)
        {
            
            //lista obiektów klasy Produkt
            List<cPracownik> l_pracownikow = (
                    from oPracownik in (XDocument.Load(@".\inwentaryzator\\data\\uzytkownicy.xml")).Root.Elements("UZYTKOWNIK")
                    select new cPracownik(
                        oPracownik.Element("IMIE").Value,
                        oPracownik.Element("NAZWISKO").Value,
                        oPracownik.Attribute("LOGIN").Value,
                        oPracownik.Element("HASLO").Value,
                        oPracownik.Element("UPRAWNIENIA").Value,
                        oPracownik.Element("INFORMACJE").Value)
                    ).ToList<cPracownik>();
            
            //sprawdzanie czy login istnieje w bazie
            try
            {
                //Wyszukiwanie po ean
                szLogin = txtbox_login.Text;

                cPracownik o_pracownik = l_pracownikow.Find(oElement => oElement.login == szLogin);
                txtbox_Imie.Text = o_pracownik.imie;
                txtbox_Nazwisko.Text = o_pracownik.nazwisko;
                txtbox_Haslo.Text = o_pracownik.haslo;
                txtbox_info.Text = o_pracownik.informacje;
                cbox_Uprawnienia.SelectedIndex = cbox_Uprawnienia.FindStringExact(o_pracownik.uprawnienia);
            }
            catch
            {
                MessageBox.Show("Nie odnaleziono pracownika", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void load_cbox()
        {
            cbox_Uprawnienia.Items.Add("pracownik");
            cbox_Uprawnienia.Items.Add("kierownik");
            cbox_Uprawnienia.Items.Add("wlasciciel");
        }

        private void cbox_Uprawnienia_SelectedIndexChanged(object sender, EventArgs e)
        {
            wUpr = cbox_Uprawnienia.Text;
        }
    }
}
