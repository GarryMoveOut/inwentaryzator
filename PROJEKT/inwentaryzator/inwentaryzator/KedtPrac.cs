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
        //plik z bazą użytkowników
        public XDocument buzytkownikow = XDocument.Load(@".\inwentaryzator\\data\\uzytkownicy.xml");
        public string plik_uzytkownicy = @".\inwentaryzator\\data\\uzytkownicy.xml";
        

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
                //Wyszukiwanie 
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
            l_pracownikow.Clear();
        }

        private void cbox_Uprawnienia_SelectedIndexChanged(object sender, EventArgs e)
        {
            wUpr = cbox_Uprawnienia.Text;
        }

        private void zapisz_but_Click(object sender, EventArgs e)
        {
            //Deklaracja nowych danych użytkownika.
            string nImie, nNazwisko, nHaslo, nInformacje, nUprawnienia, nLogin;
            bool poprawny_formularz = true;

            nImie = txtbox_Imie.Text;
            nNazwisko = txtbox_Nazwisko.Text;
            nHaslo = txtbox_Haslo.Text;
            nInformacje = txtbox_info.Text;
            nUprawnienia = cbox_Uprawnienia.Text;
            nLogin = txtbox_login.Text;

            if (string.IsNullOrWhiteSpace(nImie))
            {
                MessageBox.Show("Pole Imie nie może być puste, wpisz imię.", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                poprawny_formularz = false;
            }
            if (string.IsNullOrWhiteSpace(nNazwisko))
            {
                MessageBox.Show("Pole Nazwisko nie może być puste, wpisz nazwisko.", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                poprawny_formularz = false;
            }
            if (string.IsNullOrWhiteSpace(nHaslo))
            {
                MessageBox.Show("Pole Hasło nie może być puste, wpisz hasło.", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                poprawny_formularz = false;
            }
            if (nLogin != szLogin)
            {
                MessageBox.Show("Zmiana loginu jest niedozwolona", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                poprawny_formularz = false;
            }

            //Jeśli formularz jest poprawnie wypełniony to mogą zostać wpprowadzone zmiany
            if(poprawny_formularz == true)
            {
                try
                { 
                    var zmieniany_uzytkownik = buzytkownikow.Root.Elements("UZYTKOWNIK").Where(
                                   uzytkownik => uzytkownik.Attribute("LOGIN").Value == szLogin);
                    if (zmieniany_uzytkownik.Any())
                    {
                        zmieniany_uzytkownik.First().Element("IMIE").Value = nImie;
                        zmieniany_uzytkownik.First().Element("NAZWISKO").Value = nNazwisko;
                        zmieniany_uzytkownik.First().Element("HASLO").Value = nHaslo;
                        zmieniany_uzytkownik.First().Element("UPRAWNIENIA").Value = nUprawnienia;
                        zmieniany_uzytkownik.First().Element("INFORMACJE").Value = nInformacje;
                    }
                    //zapisanie zmian w pliku
                    buzytkownikow.Save(plik_uzytkownicy);
                    //wyczyszczenie formularza
                    ClearTextBoxes(this);
                    //resetowanie combobox
                    cbox_Uprawnienia.SelectedIndex = -1;
                    //
                    MessageBox.Show("Zapisano zmiany", "Zapisano");


                }
                catch
                {
                    MessageBox.Show("Błąd ", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                    
            }
        }
        //załadowanie uprawnień do combobox
        private void load_cbox()
        {
            cbox_Uprawnienia.Items.Add("pracownik");
            cbox_Uprawnienia.Items.Add("kierownik");
            cbox_Uprawnienia.Items.Add("wlasciciel");
        }
        //metoda do czyszczenia wszystkich pól w oknie
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
