using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions; //potrzebne do split regex

using System.IO; //odpowiada za manipulacje na plikach
using System.Xml.Linq;

namespace inwentaryzator
{
    public partial class Logowanie : Form
    {
        //Położenie pliku XML z produktami
        //public string uzyt = @".\inwentaryzator\\data\\uzytkownicy.xml";
        //wczytanie bazy z pliku
        //public XDocument uzytkownicy = XDocument.Load(@".\inwentaryzator\\data\\uzytkownicy.xml");

        //szukany login i haslo
        public string szLogin;
        public string szHaslo;

        //czy znaleziono
        public bool znaleziono;

        public Logowanie()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            //resetowanie
            znaleziono = false;
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

            szLogin = textbox_login.Text;
            szHaslo = textbox_haslo.Text;

            //sprawdzanie czy login istnieje w bazie
            foreach (cPracownik oPracownik in l_pracownikow)
            {
                if (oPracownik.login == szLogin && oPracownik.haslo == szHaslo)
                {
                    znaleziono = true;
                    switch (oPracownik.uprawnienia)
                    {
                        case "pracownik":
                            //Utworzenie i otwarcie okna pracownika
                            pracownik a = new pracownik();
                            a.ShowDialog();

                            textbox_login.Text = null;
                            textbox_haslo.Text = null;
                            break;
                        case "kierownik":
                            //Utworzenie i otwarcie okna wyboru kierownika
                            wKierownik b = new wKierownik();
                            b.ShowDialog();

                            textbox_login.Text = null;
                            textbox_haslo.Text = null;
                            break;
                        case "wlasciciel":
                            //Utworzenie i otwarcie okna właściciela 
                            WgenRaport c = new WgenRaport();
                            c.ShowDialog();

                            textbox_login.Text = null;
                            textbox_haslo.Text = null;
                            break;
                        default:
                            MessageBox.Show("Błąd wczytania pliku", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;
                    }
                }
            }

            if (znaleziono == false)
            {
                MessageBox.Show("Błędne hasło lub login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
