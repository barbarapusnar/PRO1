using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radGBP.Checked = true;
        }

        private void btnIzhod_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPocisti_Click(object sender, EventArgs e)
        {
            txtVnos.Text = "";
            txtRezultat.Text = "";
            radGBP.Checked = true;
            lblRezultat.Text = "";
        }

        private void btnIzracun_Click(object sender, EventArgs e)
        {
            double vnos=double.Parse(txtVnos.Text);
            if (radUSD.Checked == true)
            {
                txtRezultat.Text = (vnos * 1.094).ToString();
                lblRezultat.Text = "USD";
            }
            if (radCHF.Checked == true)
            {
                txtRezultat.Text = (vnos * 0.992).ToString();
                lblRezultat.Text = "CHF";
            }
            if (radGBP.Checked == true)
            {
                txtRezultat.Text = (vnos * 0.88).ToString();
                lblRezultat.Text = "GBP";
            }
        }
    }
}
