using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIzhod_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRezultat_Click(object sender, EventArgs e)
        {
            double a=double.Parse(textPrvo.Text);
            double b=double.Parse(textDrugo.Text);
            if(rbSestej.Checked==true)
                textRez.Text = (a + b).ToString();
            if (rbOdstej.Checked == true)
                textRez.Text = (a - b).ToString();
            if (rbMnozi.Checked == true)
                textRez.Text = (a * b).ToString();
            if (rbDeli.Checked == true)
                textRez.Text = (a / b).ToString();
            if (cbNeg.Checked == true && double.Parse(textRez.Text) < 0)
                textRez.ForeColor = Color.Red;
            else
                textRez.ForeColor = Color.Black;
            
        }

 
    }
}
