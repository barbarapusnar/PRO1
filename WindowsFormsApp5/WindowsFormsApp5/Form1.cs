using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radInformatika_CheckedChanged(object sender, EventArgs e)
        {
            grpIme.Text = "Študent informatike";
            lblVmesna.Visible = true;
            lblKoncna.Visible = true;
            lblSeminar.Visible = true;  
            lblUstna.Visible = true;
            txtVmesna.Text = "";
            txtKoncna.Text = "";
            txtSeminar.Visible = true;
            txtSeminar.Text = "";
            txtUstna.Text = "";
        }

        private void radMehatronika_CheckedChanged(object sender, EventArgs e)
        {
            grpIme.Text = "Študent mehatronike";
            lblVmesna.Visible = true;
            lblKoncna.Visible = true;
            lblSeminar.Visible = false;
            lblUstna.Visible = false;
            txtVmesna.Text = "";
            txtKoncna.Text = "";
            txtSeminar.Visible=false;
            txtUstna.Visible=false;
        }

        private void radUPK_CheckedChanged(object sender, EventArgs e)
        {
            grpIme.Text = "Študent UPK";
            lblVmesna.Visible = true;
            lblKoncna.Visible = true;
            lblSeminar.Visible = true;
            lblUstna.Visible = false;
            txtVmesna.Text = "";
            txtKoncna.Text = "";
            txtSeminar.Visible = true;
            txtSeminar.Text = "";
            txtUstna.Visible = false;
        }

        private void btnPonastavi_Click(object sender, EventArgs e)
        {
            grpIme.Text = "Študent informatike";
            radInformatika.Checked = true;
            lblVmesna.Visible = true;
            lblKoncna.Visible = true;
            lblSeminar.Visible = true;
            lblUstna.Visible = true;
            txtVmesna.Visible = true;
            txtKoncna.Visible = true;
            txtUstna.Visible = true;
            txtSeminar.Visible = true;
            txtVmesna.Text = "";
            txtKoncna.Text = "";
            txtSeminar.Text = "";
            txtUstna.Text = "";
            lblOcena.Text = "";
            lblPovp.Text = "";
            
        }

        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            if (radInformatika.Checked == true)
            {
                try
                {
                    ŠtudentInf x = new ŠtudentInf();
                    x.Vmesna = int.Parse(txtVmesna.Text);
                    x.Koncna = int.Parse(txtKoncna.Text);
                    x.Seminar = int.Parse(txtSeminar.Text);
                    x.Ustna=int.Parse(txtUstna.Text);
                    x.Računaj();
                    lblPovp.Text = "Povprečje točk je " + x.Povp;
                    lblOcena.Text="KONČNA OCENA: "+x.Ocena;
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }
            }

            if (radMehatronika.Checked == true)
            {
                try
                {
                    ŠtudentMeh x = new ŠtudentMeh();
                    x.Vmesna = int.Parse(txtVmesna.Text);
                    x.Koncna = int.Parse(txtKoncna.Text);
                    x.Računaj();
                    lblPovp.Text = "Povprečje točk je " + x.Povp;
                    lblOcena.Text = "KONČNA OCENA: " + x.Ocena;
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }
            }

            if (radUPK.Checked == true)
            {
                try
                {
                    ŠtudentUPK x = new ŠtudentUPK();
                    x.Vmesna = int.Parse(txtVmesna.Text);
                    x.Koncna = int.Parse(txtKoncna.Text);
                    x.Seminar = int.Parse(txtSeminar.Text);
                    x.Računaj();
                    lblPovp.Text = "Povprečje točk je " + x.Povp;
                    lblOcena.Text = "KONČNA OCENA: " + x.Ocena;
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }
            }
        }


    }
}
