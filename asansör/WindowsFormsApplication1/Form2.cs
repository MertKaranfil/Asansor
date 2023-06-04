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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1.hareketbir = 1;
            Class2.donusbir = 1;
            button8.Enabled = false;
            button9.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button1.BackColor = Color.Green;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class1.hareketiki = 1;
            Class2.donusiki = 1;
            button1.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button2.BackColor = Color.Green;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Class1.hareketuc = 1;
            Class2.donusuc = 1;
            button1.Enabled = false;
            button2.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = true;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button3.BackColor = Color.Green;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Class1.hareketdort = 1;
            Class2.donusdort = 1;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button8.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button9.Enabled = true;
            button4.BackColor = Color.Green;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Class1.hareketbes = 1;
            Class2.donusbes = 1;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = true;
            button6.Enabled = false;
            button7.Enabled = false;
            button5.BackColor = Color.Green;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Class1.hareketalti = 1;
            Class2.donusalti = 1;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = true;
            button6.BackColor = Color.Green;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Class1.hareketyedi = 1;
            Class2.donusyedi = 1;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button9.Enabled = true;
            button8.Enabled = false;
            button7.BackColor = Color.Green;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Class1.hareketsekiz = 1;
            Class2.donussekiz = 1;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button9.Enabled = true;
            button8.BackColor = Color.Green;
        }
        
        private void button9_Click(object sender, EventArgs e)
        {
            if (Class1.hareketbir == 1)
            {
                Form1 f1 = (Form1)Application.OpenForms[(("Form1"))];
                f1.timer1.Start();
                f1.label1.Text = "1. Kata Gidiyor";
                f1.label1.BackColor = Color.Red;

            }
            if (Class1.hareketiki == 1)
            {
                Form1 f1 = (Form1)Application.OpenForms[(("form1"))];
                f1.timer2.Start();
                f1.label1.Text = "2. Kata Gidiyor";
                f1.label1.BackColor = Color.Red;
            }
            if (Class1.hareketuc == 1)
            {
                Form1 f1 = (Form1)Application.OpenForms[(("form1"))];
                f1.timer3.Start();
                f1.label1.Text = "3. Kata Gidiyor";
                f1.label1.BackColor = Color.Red;
            }
            if (Class1.hareketdort == 1)
            {
                Form1 f1 = (Form1)Application.OpenForms[(("form1"))];
                f1.timer4.Start();
                f1.label1.Text = "4. Kata Gidiyor";
                f1.label1.BackColor = Color.Red;
            }
            if (Class1.hareketbes == 1)
            {
                Form1 f1 = (Form1)Application.OpenForms[(("form1"))];
                f1.timer5.Start();
                f1.label1.Text = "5. Kata Gidiyor";
                f1.label1.BackColor = Color.Red;
            }
            if (Class1.hareketalti == 1)
            {
                Form1 f1 = (Form1)Application.OpenForms[(("form1"))];
                f1.timer6.Start();
                f1.label1.Text = "6. Kata Gidiyor";
                f1.label1.BackColor = Color.Red;
            }
            if (Class1.hareketyedi == 1)
            {
                Form1 f1 = (Form1)Application.OpenForms[(("Form1"))];
                f1.timer7.Start();
                f1.label1.Text = "7. Kata Gidiyor";
                f1.label1.BackColor = Color.Red;
            }

            if (Class1.hareketsekiz == 1)
            {
                Form1 f1 = (Form1)Application.OpenForms[(("form1"))];
                f1.timer8.Start();
                f1.label1.Text = "8. Kata Gidiyor";
                f1.label1.BackColor = Color.Red;
            }
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.Enabled = false;
            

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Class2.donusbir == 1)
            {
                Form1 f1 = (Form1)Application.OpenForms[(("form1"))];
                f1.label1.Text = "Merkeze Dönülüyor";
                f1.label1.BackColor = Color.Red;
                f1.timer1donus.Start();
                Class1.hareketbir = 0;
                Class2.donusbir = 0;
            }
            if (Class2.donusiki == 1)
            {
                Form1 f1 = (Form1)Application.OpenForms[(("form1"))];
                f1.label1.Text = "Merkeze Dönülüyor";
                f1.label1.BackColor = Color.Red;
                f1.timer2donus.Start();
                Class1.hareketiki = 0;
                Class2.donusiki = 0;
            }
            if (Class2.donusuc == 1)
            {
                
                Form1 f1 = (Form1)Application.OpenForms[(("form1"))];
                f1.label1.Text = "Merkeze Dönülüyor";
                f1.label1.BackColor = Color.Red;
                f1.timer3donus.Start();
                Class1.hareketuc = 0;
                Class2.donusuc = 0;
            }
            if (Class2.donusdort==1)
            {
               Form1 f1 = (Form1)Application.OpenForms[(("form1"))];
               f1.label1.Text = "Merkeze Dönülüyor";
               f1.label1.BackColor = Color.Red;
               f1.timer4donus.Start();
               Class1.hareketdort = 0;
               Class2.donusdort = 0;
            }
            if (Class2.donusbes==1)
            {
                Form1 f1 = (Form1)Application.OpenForms[(("form1"))];
                f1.label1.Text = "Merkeze Dönülüyor";
                f1.label1.BackColor = Color.Red;
                f1.timer5donusiki.Start();
                Class1.hareketbes = 0;
                Class2.donusbes = 0;
            }
            if (Class2.donusalti==1)
            {
                Form1 f1 = (Form1)Application.OpenForms[(("form1"))];
                f1.label1.Text = "Merkeze Dönülüyor";
                f1.label1.BackColor = Color.Red;
                f1.timer6donus.Start();
                Class1.hareketalti = 0;
                Class2.donusalti = 0;
            }
            if (Class2.donusyedi==1)
            {
               Form1 f1 = (Form1)Application.OpenForms[(("form1"))];
               f1.label1.Text = "Merkeze Dönülüyor";
               f1.label1.BackColor = Color.Red;
               f1.timer7donusiki.Start();
               Class1.hareketyedi = 0;
               Class2.donusyedi = 0;
            }
            if (Class2.donussekiz==1)
            {
              Form1 f1 = (Form1)Application.OpenForms[(("form1"))];
               f1.label1.Text = "Merkeze Dönülüyor";
               f1.label1.BackColor = Color.Red;
               f1.timer8donus.Start();
               Class1.hareketsekiz = 0;
               Class2.donussekiz = 0;  
            }
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            Form1 ff1 = (Form1)Application.OpenForms[(("form1"))];
            ff1.pictureBox2.Visible = false;
            ff1.pictureBox3.Visible = false;
            ff1.pictureBox4.Visible = false;
            ff1.pictureBox5.Visible = false;
            ff1.pictureBox6.Visible = false;
            ff1.pictureBox7.Visible = false;
            ff1.pictureBox8.Visible = false;
            ff1.pictureBox9.Visible = false;

            
        }
    }
}
    
