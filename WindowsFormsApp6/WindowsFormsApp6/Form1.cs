using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("CD");
            comboBox1.Items.Add("Video");
            comboBox1.Items.Add("DVD");
            label3.Text = "";
        }

        private bool Preveri()
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Izberi vrsto medija za izposojo.");
                return false;
            }
            else if (numericUpDown1.Value == 0)
            {
                MessageBox.Show("Število dni mora biti večje od 0.");
                return false;
            }
            else
                return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Preveri())
            {
                if(comboBox1.SelectedIndex == 0)
                {
                    RacunCD cd=new RacunCD();
                    label3.Text = cd.Izracun((int)numericUpDown1.Value).ToString()+" €";
                }
                else if(comboBox1.SelectedIndex == 1)
                   {
                    RacunVideo video = new RacunVideo(1.0);
                    label3.Text = video.Izracun((int)numericUpDown1.Value).ToString() + " €";
                   }
                else if (comboBox1.SelectedIndex == 2)
                {
                    RacunDVD dvd = new RacunDVD(1.2,10.0);
                    label3.Text = dvd.Izracun((int)numericUpDown1.Value).ToString() + " €";   
                }
            }
            }
        }
    }

