using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DELEGATE_EXERCİSE
{
    public partial class Form1 : Form
    {

        public delegate void Hesapla(int text);
        public Form1()
        {
            InitializeComponent();
        }
        void bilinmeyen(int a) {

            //4x^2+5x+10

            int sonuc = (4 * a) * (4 * a) + 5 * a + 10;
            bilinmeyenText.Text = sonuc.ToString();
        
        }
        void karesi(int b)
        {
            int sonuc = b * b;
            karesiText.Text = sonuc.ToString();

        }
        void küpü(int c)
        {

            int sonuc = c*c*c;
            küpüText.Text = sonuc.ToString();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hesapla hsp = new Hesapla(bilinmeyen);
            hsp += karesi;
            hsp += küpü;
            int alinacaksayi = Convert.ToInt32(textBox1.Text);
            hsp(alinacaksayi);

        }
    }
}
