using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnostavenKalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIzračunaj_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtPrvo.Text);
            int b = int.Parse(txtDrugo.Text);
            int c=0;
            if (radPlus.Checked)
                c = a + b;
            if (radMinus.Checked)
                c = a - b;
            if (radKrat.Checked)
                c = a * b;
            if (radDeli.Checked)
                c = a / b;
            txtRezultat.Text = c+"";    
        }

        private void btnPočisti_Click(object sender, EventArgs e)
        {
            txtPrvo.Text = "";
            txtDrugo.Text = "";
            txtRezultat.Clear();
            //postavi se v prvi textbox
            txtPrvo.Focus();
        }
    }
}
