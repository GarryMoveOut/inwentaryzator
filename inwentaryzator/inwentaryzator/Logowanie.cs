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
        string login = @"inwentaryzator\\login.txt";
        string haslo = File.ReadAllText(@"inwentaryzator\\haslo.txt");
        string uprawnienia = File.ReadAllText(@"inwentaryzator\\uprawnienia.txt");
        
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
            licznik = 0;
            
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
                MessageBox.Show("Zalogowano");
            }
            else
            {
                MessageBox.Show("Błędny login lub hasło!");
            }
        }
    }
}
