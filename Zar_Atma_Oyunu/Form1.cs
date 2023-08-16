using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zar_Atma_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
            contextMenuStrip1.Enabled = false;
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            contextMenuStrip1.Enabled = true;


            Random zar = new Random();

            int s1;
            s1 = zar.Next(1, 7);

            label3.Text = s1.ToString();

            if (s1 == 1)
            {

                pictureBox1.Image = Resource1._1;

            }

            if (s1 == 2)
            {

                pictureBox1.Image = Resource1._2;

            }

            if (s1 == 3)
            {

                pictureBox1.Image = Resource1._3;

            }

            if (s1 == 4)
            {

                pictureBox1.Image = Resource1._4;

            }
            if (s1 == 5)
            {

                pictureBox1.Image = Resource1._5;

            }
            if (s1 == 6)
            {

                pictureBox1.Image = Resource1._6;

            }
  

        }

        private void birDahaAtToolStripMenuItem_Click(object sender, EventArgs e)
        {


            button1_Click(sender, e);


        }
    }
}