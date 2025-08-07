using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC11_Jogo_da_Memoria
{
    public partial class Form1 : Form
    {
        string pb1 = "0";
        string pb2 = "0";
        string pb3 = "0";
        string pb4 = "0";
        string pb5 = "0";
        string pb6 = "0";
        string pb7 = "0";
        string pb8 = "0";
        string pb9 = "0";
        string pb10 = "0";
        string pb11 = "0";
        string pb12 = "0";

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pb1 == "0")
            {
                pictureBox1.Image = Properties.Resources.aquaman;
                pb1 = "1";
            }
            else
            {
                pictureBox1.Image = Properties.Resources.smile;
                pb1 = "0";
            }

            if (pb1 == pb9 && pb1 != "0")
            {
                MessageBox.Show("Acertou!");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pb2 == "0")
            {
                pictureBox2.Image = Properties.Resources.felicity;
                pb2 = "1";
            }
            else
            {
                pictureBox2.Image = Properties.Resources.smile;
                pb2 = "0";
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pb3 == "0")
            {
                pictureBox3.Image = Properties.Resources.hulk;
                pb3 = "1";
            }
            else
            {
                pictureBox3.Image = Properties.Resources.smile;
                pb3 = "0";
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pb4 == "0")
            {
                pictureBox4.Image = Properties.Resources.felicity;
                pb4 = "1";
            }
            else
            {
                pictureBox4.Image = Properties.Resources.smile;
                pb4 = "0";
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pb5 == "0")
            {
                pictureBox5.Image = Properties.Resources.homem_de_ferro;
                pb5 = "1";
            }
            else
            {
                pictureBox5.Image = Properties.Resources.smile;
                pb5 = "0";
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (pb6 == "0")
            {
                pictureBox6.Image = Properties.Resources.viuva_negra;
                pb6 = "1";
            }
            else
            {
                pictureBox6.Image = Properties.Resources.smile;
                pb6 = "0";
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (pb7 == "0")
            {
                pictureBox7.Image = Properties.Resources.feiticeira_escarlate;
                pb7 = "1";
            }
            else
            {
                pictureBox7.Image = Properties.Resources.smile;
                pb7 = "0";
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (pb8 == "0")
            {
                pictureBox8.Image = Properties.Resources.hulk;
                pb8 = "1";
            }
            else
            {
                pictureBox8.Image = Properties.Resources.smile;
                pb8 = "0";
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (pb9 == "0")
            {
                pictureBox9.Image = Properties.Resources.aquaman;
                pb9 = "1";
            }
            else
            {
                pictureBox9.Image = Properties.Resources.smile;
                pb9 = "0";
            }

            if (pb1 == pb9 && pb1 != "0")
            {
                MessageBox.Show("Acertou!");
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (pb10 == "0")
            {
                pictureBox10.Image = Properties.Resources.feiticeira_escarlate;
                pb10 = "1";
            }
            else
            {
                pictureBox10.Image = Properties.Resources.smile;
                pb10 = "0";
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (pb11 == "0")
            {
                pictureBox11.Image = Properties.Resources.viuva_negra;
                pb11 = "1";
            }
            else
            {
                pictureBox11.Image = Properties.Resources.smile;
                pb11 = "0";
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (pb12 == "0")
            {
                pictureBox12.Image = Properties.Resources.homem_de_ferro;
                pb12 = "1";
            }
            else
            {
                pictureBox12.Image = Properties.Resources.smile;
                pb12 = "0";
            }
        }
    }
}
