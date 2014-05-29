using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inwentaryzator
{
    public partial class WgenRaport : Form
    {
        public WgenRaport()
        {
            InitializeComponent();
            load_cbox();
        }

        //
        //Przycisk wyloguj
        //
        private void but_wyloguj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        //Wczytanie listy opcji dla combox
        //
        private void load_cbox()
        {
            combox_raport.Items.Add("Wszystkie produkty");
            combox_raport.Items.Add("Brakujące produkty");
            combox_raport.Items.Add("Spis pracowników");
        }
    }
}
