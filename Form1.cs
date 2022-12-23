using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatematikHesaplamalari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int birkenar;
            birkenar = Convert.ToInt32(textBox1.Text);
            int alan;
            alan = birkenar * birkenar;
            int cevre;
            cevre = birkenar + birkenar + birkenar + birkenar;
            label4.Text = alan.ToString();
            label5.Text = cevre.ToString();
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
            textBox2.Visible = false;
            panel1.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label1.Text = "KARE";
         dikdortgenhesapla.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label7.Visible = true;
            textBox2.Visible = true;
            panel1.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label1.Text = "DİKDÖRTGEN";
            label2.Text = "KISA KENARI GİRİN:";
            hesapla.Visible = false;
            dikdortgenhesapla.Visible = true;




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;

            int kisakenar, uzunkenar, aland, cevred;
            kisakenar = Convert.ToInt32(textBox1.Text);
            uzunkenar = Convert.ToInt32(textBox2.Text);

            aland = uzunkenar * kisakenar;
            cevred = 2 * (uzunkenar + kisakenar);

            label4.Text = aland.ToString();
            label5.Text = cevred.ToString();

         
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
            textBox2.Visible = false;
            panel1.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label1.Text = "ÜÇGEN";
            label2.Text = "YÜKSEKLİĞİ GİRİNİZ:";
            label7.Text = "TABANI GİRİNİZ:";
            dikdortgenhesapla.Visible = false;
            hesapla.Visible = false;
            ucgenhesaplama.Visible = true;
            label7.Visible = true;
            textBox2.Visible = true;
           

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
            textBox2.Visible = false;
            panel1.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label1.Text = "KARE";
            dikdortgenhesapla.Visible = false;
            hesapla.Visible = true;
            ucgenhesaplama.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label7.Visible = true;
            textBox2.Visible = true;
            panel1.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label1.Text = "DİKDÖRTGEN";
            label2.Text = "KISA KENARI GİRİN:";
            hesapla.Visible = false;
            dikdortgenhesapla.Visible = true;
            ucgenhesaplama.Visible = false;
        }

        private void ucgenhesaplama_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = false;
            label6.Visible = false;
          
            int taban,yukseklik, alanu;
            taban = Convert.ToInt32(textBox1.Text);
            yukseklik = Convert.ToInt32(textBox2.Text);

            alanu = (taban * yukseklik)/2;
     

            label4.Text = alanu.ToString();
       
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;

            int kisakenar, uzunkenar, aland, cevred;
            kisakenar = Convert.ToInt32(textBox1.Text);
            uzunkenar = Convert.ToInt32(textBox2.Text);

            aland = uzunkenar * kisakenar;
            cevred = 2 * (uzunkenar + kisakenar);

            label4.Text = aland.ToString();
            label5.Text = cevred.ToString();
        }
    }
}
