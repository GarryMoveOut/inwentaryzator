using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO; //odpowiada za manipulacje na plikach

namespace inwentaryzator
{
    public partial class Logowanie : Form
    {
        string login = @"inwentaryzator\\login.txt";
        string haslo = @"inwentaryzator\\haslo.txt";
        string wlogin;
        string whaslo;
        bool z_login = false;
        bool z_haslo = false;

        public Logowanie()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            wlogin = textbox_login.Text;
            whaslo = textbox_haslo.Text;

            using (StreamReader blogin = File.OpenText(login))
            {
                string slogin;

                while ((slogin = blogin.ReadLine()) != null)
                {
                    if (slogin == wlogin)
                    {
                        z_login = true;
                    }
                }
            }

            using (StreamReader bhaslo = File.OpenText(haslo))
            {
                string shaslo;

                while ((shaslo = bhaslo.ReadLine()) != null)
                {
                    if (shaslo == whaslo)
                    {
                        z_haslo = true;
                    }
                }
            }

            if (z_login == true && z_haslo == true)
            {
                MessageBox.Show("Zalogowano");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
