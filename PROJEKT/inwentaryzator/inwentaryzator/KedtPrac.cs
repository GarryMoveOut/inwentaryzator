using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        //
        //Przycisk wyszukiwania
        //
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
        //
        //Przycisk zapisywania
        //
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

            //Sprawdzanie znaków specjalnych
            var regexItem = new Regex("^[a-zA-Z ]*$");
            var regexItem2 = new Regex("^[a-zA-Z0-9 ]*$");
            if (!regexItem.IsMatch(txtbox_Haslo.Text) || !regexItem.IsMatch(txtbox_info.Text))
            {
                MessageBox.Show("Błąd formularza", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                poprawny_formularz = false;
            }
            if (!regexItem.IsMatch(txtbox_Imie.Text) || !regexItem.IsMatch(txtbox_Nazwisko.Text) || !regexItem.IsMatch(txtbox_login.Text))
            {
                MessageBox.Show("Błąd formularza", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                poprawny_formularz = false;
            }

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
        //
        //Przycisk uswania
        //
        private void usun_but_Click(object sender, EventArgs e)
        {
            DialogResult potw_usun = MessageBox.Show("Czy chcesz usunąć użytkownika", "Potwierdź", MessageBoxButtons.YesNo);
            if (potw_usun == DialogResult.Yes)
            {
                var usun_uzyt = buzytkownikow.Descendants("UZYTKOWNIK").Where(o => o.Attribute("LOGIN").Value == szLogin);
                usun_uzyt.Remove();
                //zapisanie zmian w pliku
                buzytkownikow.Save(plik_uzytkownicy);
                //wyczyszczenie formularza
                ClearTextBoxes(this);
                //resetowanie combobox
                cbox_Uprawnienia.SelectedIndex = -1;
                //
                MessageBox.Show("Usunięto użytkownika", "Potwierdzenie");
            }
        }
        //
        //Przycisk dodawania użytkownika
        //
        private void dodaj_but_Click(object sender, EventArgs e)
        {
            //Deklaracja nowych danych użytkownika.
            string nImie, nNazwisko, nHaslo, nInformacje, nUprawnienia, nLogin;
            bool poprawny_formularz = true;
            bool czy_istnieje = false;

            nImie = txtbox_Imie.Text;
            nNazwisko = txtbox_Nazwisko.Text;
            nHaslo = txtbox_Haslo.Text;
            nInformacje = txtbox_info.Text;
            nUprawnienia = cbox_Uprawnienia.Text;
            nLogin = txtbox_login.Text;

            //Sprawdzanie znaków specjalnych
            var regexItem = new Regex("^[a-zA-Z ]*$");
            var regexItem2 = new Regex("^[a-zA-Z0-9 ]*$");
            if (!regexItem.IsMatch(txtbox_Haslo.Text) || !regexItem.IsMatch(txtbox_info.Text))
            {
                MessageBox.Show("Błąd formularza", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                poprawny_formularz = false;
            }
            if (!regexItem.IsMatch(txtbox_Imie.Text) || !regexItem.IsMatch(txtbox_Nazwisko.Text) || !regexItem.IsMatch(txtbox_login.Text))
            {
                MessageBox.Show("Błąd formularza", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                poprawny_formularz = false;
            }
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
            if (string.IsNullOrWhiteSpace(nLogin))
            {
                MessageBox.Show("Pole login nie może być puste", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                poprawny_formularz = false;
            }

            //czy podany login już istnieje w bazie
            var dubel = buzytkownikow.Root.Elements("UZYTKOWNIK").Where(
                                   uzytkownik => uzytkownik.Attribute("LOGIN").Value == nLogin);
            if (dubel.Any())
            {
                czy_istnieje = true;
                MessageBox.Show("Użytkownik o podanym loginie już istnieje", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (poprawny_formularz == true && czy_istnieje == false)
            {
                //XElement nUzytkownik = new XElement("UZYTKOWNIK",
                //    new XAttribute("LOGIN", nLogin),
                //    new XElement("HASLO", nHaslo),
                //    new XElement("UPRAWNIENIA", nUprawnienia),
                //    new XElement("IMIE", nImie),
                //    new XElement("NAZWISKO", nNazwisko),
                //    new XElement("INFORMACJE", nInformacje)
                //    );
                //buzytkownikow.Root.Add(nUzytkownik);
                buzytkownikow.Root.Add(new XElement("UZYTKOWNIK",
                    new XAttribute("LOGIN", nLogin),
                    new XElement("HASLO", nHaslo),
                    new XElement("UPRAWNIENIA", nUprawnienia),
                    new XElement("IMIE", nImie),
                    new XElement("NAZWISKO", nNazwisko),
                    new XElement("INFORMACJE", nInformacje))
                   );
                buzytkownikow.Save(plik_uzytkownicy);
                MessageBox.Show("Użytkownik został zapisany", "Dodano");
                //wyczyszczenie formularza
                ClearTextBoxes(this);
                //resetowanie combobox
                cbox_Uprawnienia.SelectedIndex = -1;
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
