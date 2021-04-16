using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProiectAtestat
{
    public partial class Regulament : Form
    {
        public Regulament()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reguli_de_baza f1 = new Reguli_de_baza();
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sfarsitul_jocului f2 = new Sfarsitul_jocului();
            f2.ShowDialog();
        }
    }
}
