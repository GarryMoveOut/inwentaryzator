// compile with: /doc:DocFileName.xml 
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

namespace inwentaryzator
{
    public partial class Logowanie : Form
    {
        string login = @".\inwentaryzator\\users\\login.txt";
        string haslo = File.ReadAllText(@".\inwentaryzator\\users\\haslo.txt");
        string uprawnienia = File.ReadAllText(@".\inwentaryzator\\users\\uprawnienia.txt");
        
        //login wczytany z textbox_login
        string wlogin;
        //hasło wczytane z textbox_haslo
        string whaslo;
        //czy login znaleziono w pliku
        bool z_login = false;
        //czy hasło znaleziono w pliku
        bool z_haslo = false;
        //licznik wczytanych linii z pliku z hasłami
        int licznik=0;

        public Logowanie()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            wlogin = textbox_login.Text;
            whaslo = textbox_haslo.Text;
            //zerowanie
            licznik = 0;
            z_login = false;
            z_haslo = false;
            
            //podzielenie pliku z hasłami na linie 
            string[] linia = Regex.Split(haslo, "\r\n");

            //wczytanie loginów z pliku i sprawdzenie czy jest w bazie
            using (StreamReader blogin = File.OpenText(login))
            {
                //zmienna tymczasowa do porównywania loginów z bazy
                string slogin;

                while ((slogin = blogin.ReadLine()) != null)
                {
                    //sprawdzanie czy login jest w bazie
                    if (slogin == wlogin)
                    {
                        z_login = true;
                        break;
                    }
                    licznik++;
                }
            }

            if (z_login == true)
            {
                //wczytanie lini odpowiadającej loginowi
                string poprawne_haslo = linia[licznik];
                if (poprawne_haslo == whaslo)
                {
                    z_haslo = true;
                }
            }

            if (z_login == true && z_haslo == true)
            {
                string[] linia_uprawnienia = Regex.Split(uprawnienia, "\r\n");
                string poziom_uprawnien = linia_uprawnienia[licznik];
                
                if(poziom_uprawnien=="p")
                {
                    //utworzenie i otwarcie okan pracownika
                    pracownik a = new pracownik();
                    a.ShowDialog();
                }
                if (poziom_uprawnien == "k")
                {
                    MessageBox.Show("Kierownik");
                }
                if (poziom_uprawnien == "w")
                {
                    MessageBox.Show("Właściciel");
                }
                if(poziom_uprawnien!="p" && poziom_uprawnien!="k" && poziom_uprawnien!="w")
                {
                    MessageBox.Show("Błąd programu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
               MessageBox.Show("Błędny login lub hasło!", "Odmowa dostępu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
