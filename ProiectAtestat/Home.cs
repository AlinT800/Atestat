using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectAtestat
{
    public partial class Principala : Form
    {
        public Principala()
        {
            InitializeComponent();
        }

        private void Principala_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Istorie istorie = new Istorie(); //deschide fereastra cu istoria șahului
            istorie.ShowDialog();
        }
    }
}
