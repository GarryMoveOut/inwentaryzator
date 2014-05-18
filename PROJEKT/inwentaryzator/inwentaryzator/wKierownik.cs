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
    public partial class wKierownik : Form
    {
        public wKierownik()
        {
            InitializeComponent();
        }

        private void but_edt_pracownikow_Click(object sender, EventArgs e)
        {
            KedtPrac a = new KedtPrac();
            a.ShowDialog();
        }

        private void but_edt_prod_Click(object sender, EventArgs e)
        {
            KedtProdukt a = new KedtProdukt();
            a.ShowDialog();
        }

        private void but_wyloguj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
