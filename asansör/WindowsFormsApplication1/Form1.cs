using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                Form2 f2 = new Form2();
                f2.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left -= 1;
            if (pictureBox1.Location.X == 170)
            {
                timer1.Stop();
                pictureBox3.Visible = true;
                label1.Text = "1.Kata Geldiniz";
                label1.BackColor = Color.Green;
            }

        }



        private void timer8_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += 1;
            if (pictureBox1.Location.Y == 429)
            {
                timer8.Stop();
                pictureBox9.Visible = true;
                label1.Text = "8.Kata Geldiniz";
                label1.BackColor = Color.Green;
            }

        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 1;
            if (pictureBox1.Location.X == 672)
            {
                timer6.Stop();
                pictureBox6.Visible = true;
                label1.Text = "6.kata Geldiniz";
                label1.BackColor = Color.Green;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top -= 1;
            if (pictureBox1.Location.Y == 77)
            {
                timer4.Stop();
                pictureBox8.Visible = true;
                label1.Text = "4.Kata Geldiniz";
                label1.BackColor = Color.Green;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top -= 1;
            if (pictureBox1.Location.Y == 77)
            {
                timer3.Stop();
                timer3devam.Start();

            }
        }

        private void timer3devam_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left -= 1;
            if (pictureBox1.Location.X == 170)
            {
                timer3devam.Stop();
                pictureBox2.Visible = true;
                label1.Text = "3.Kata Geldiniz";
                label1.BackColor = Color.Green;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += 1;
            if (pictureBox1.Location.Y == 429)
            {
                timer2.Stop();
                timer2devam.Start();
            }
        }

        private void timer2devam_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left -= 1;
            if (pictureBox1.Location.X == 170)
            {
                timer2devam.Stop();
                pictureBox4.Visible = true;
                label1.Text = "2.Kata Geldiniz";
                label1.BackColor = Color.Green;
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top -= 1;
            if (pictureBox1.Location.Y == 77)
            {
                timer5devam.Start();
                timer5.Stop();
            }
        }

        private void timer5devam_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 1;
            if (pictureBox1.Location.X == 672)
            {
                timer5devam.Stop();
                pictureBox5.Visible = true;
                label1.Text = "5.Kata Geldiniz";
                label1.BackColor = Color.Green;
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += 1;
            if (pictureBox1.Location.Y == 429)
            {
                timer7.Stop();
                timer7devam.Start();
            }

        }

        private void timer7devam_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 1;
            if (pictureBox1.Location.X == 672)
            {
                timer7devam.Stop();
                pictureBox7.Visible = true;
                label1.Text = "7.Kata Geldiniz";
                label1.BackColor = Color.Green;

            }

        }

        private void timer1donus_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 1;
            if (pictureBox1.Location.X == 412)
            {
                timer1donus.Stop();
                label1.Text = "Merkeze Dönüldü";
            }
        }


        private void timer2donus_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 1;
            if (pictureBox1.Location.X == 412)
            {
                label1.Text = "Merkeze Dönülüyor";
                timer2donus.Stop();
                timer2donusiki.Start();
            }

        }

        private void timer2donusiki_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top -= 1;
            if (pictureBox1.Location.Y == 245)
            {
                timer2donusiki.Stop();
                label1.Text = "Merkeze Dönüldü";
            }

        }

        private void timer3donus_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 1;
            if (pictureBox1.Location.X == 412)
            {
                timer3donus.Stop();
                timer3donusiki.Start();
                label1.BackColor = Color.Green;
            }
        }

        private void timer3donusiki_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += 1;
            if (pictureBox1.Location.Y == 245)
            {
                timer3donusiki.Stop();
                label1.Text = "Merkeze Dönüldü";
            }
        }

        private void timer4donus_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += 1;
            if (pictureBox1.Location.Y == 245)
            {
                timer4donus.Stop();
                label1.Text = "Merkeze Dönüldü";
                label1.BackColor = Color.Green;
            }
        }

        private void timer5donus_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += 1;
            if (pictureBox1.Location.Y == 245)
            {
                label1.Text = "Merkeze Geldiniz";
                timer5donus.Stop();
            }
        }

        private void timer5donusiki_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left -= 1;
            if (pictureBox1.Location.X == 412)
            {
                timer5donusiki.Stop();
                timer5donus.Start();
                label1.BackColor = Color.Green;
            }
        }

        private void timer6donus_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left -= 1;
            if (pictureBox1.Location.X == 412)
            {
                timer6donus.Stop();
                label1.Text = "Merkeze Geldiniz";
                label1.BackColor = Color.Green;
            }
        }

        private void timer7donus_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top -= 1;
            if (pictureBox1.Location.Y == 245)
            {
                label1.Text = "Merkeze Geldiniz";
                timer7donus.Stop();
                

            }
        }

        private void timer7donusiki_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left -= 1;
            if (pictureBox1.Location.X == 412)
            {
                timer7donusiki.Stop();
                timer7donus.Start();
                
                label1.BackColor = Color.Green;
            }




        }

        private void timer8donus_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top -= 1;
            if (pictureBox1.Location.Y == 245)
            {
                timer8donus.Stop();
                label1.Text = "Merkeze Geldiniz";
                label1.BackColor = Color.Green;
            }
        }


    }
}

