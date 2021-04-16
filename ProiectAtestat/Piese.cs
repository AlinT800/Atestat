using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProiectAtestat
{
    public partial class Piese : Form
    {
        public Piese()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rege f1 = new Rege();
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Regina f2 = new Regina();
            f2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Nebun f3 = new Nebun();
            f3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cal f4 = new Cal();
            f4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Turn f5 = new Turn();
            f5.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Pion f6 = new Pion();
            f6.ShowDialog();
        }
    }
}
