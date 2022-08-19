using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinyalizasyonProje
{
    public partial class Form1 : Form
    {
        int s = 0;      // Genel sayaç
        int sYaya = 9;  // Yayalar için sayaç
        int sAna = 17;  // Anayol için sayaç
        int say = 0;    // timer4

        public Form1() // Form açıldığında gelecek ilk ekran
        {
            InitializeComponent();

            label1.Text = "Geçen toplam süre: " + s.ToString();

            durum1();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();

            backgroundAna();  // Işığının üzerindeki sayacın arka planını otomatik saydamlaştırır
            backgroundYaya();
        }

        private void button1_Click(object sender, EventArgs e) // Karşıya geç butonu
        {
            timer1.Start();
            timer4.Start();

            button1.Enabled = false;
            button2.Enabled = false;

            button4.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e) // Karşıya geç butonu
        {
            timer1.Start();
            timer4.Start();

            button1.Enabled = false;
            button2.Enabled = false;

            button4.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e) // Devam et butonu
        {
            timer1.Start();
            timer4.Start();

            if (sYaya < 9 && 0 < sYaya)
            {
                timer2.Start();
            }
            if (sAna < 17 && 0 < sAna)
            {
                timer3.Start();
            }
        }

        private void button4_Click(object sender, EventArgs e) // Duraklat butonu
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();

            button3.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e) // Geçen toplam süreyi sayan sayaç
        {
            s++;
            
            label1.Text = "Geçen toplam süre: " + s.ToString();

            if (s == 5) // Kaçıncı saniyede hangi duruma geçeceğini söylüyor
            {
                durum2();
            }
            if (s == 10)
            {
                durum3();
            }
            if (s == 13)
            {
                durum4();
            }
            if (s == 23)
            {
                durum5();
            }
            if (s == 25)
            {
                durum6();
            }
            if (s == 28)
            {
                durum1();

                timer1.Stop();
                timer3.Stop();
                timer4.Stop();

                MessageBox.Show("Completed", "Info");

                s = 0;  // Sayaçlar ana değerlerine dönüyor
                sYaya = 9;
                sAna = 17;
                say = 0;

                button1.Enabled = true; // Süre dolduğunda buttonların durumu
                button2.Enabled = true;
                button3.Enabled = false;
                button4.Enabled = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e) // Yaya geçidi için sayaç
        {
            lblYaya.Text = sYaya.ToString();
            lblYaya1.Text = sYaya.ToString();
            sYaya--;
        }

        private void timer3_Tick(object sender, EventArgs e) // Ana yol için sayaç
        {
            lblAna.Text = sAna.ToString();
            lblAna1.Text = sAna.ToString();
            sAna--;
        }

        private void timer4_Tick(object sender, EventArgs e) // Son saniyelerde ışığın renginin değişimi
        {
            say++;

            if (say == 187)
            {
                yy_editEffect();
                backgroundYaya();
            }
            if (say == 195)
            {
                yy_editGreen();
                backgroundYaya();
            }
            if (say == 203)
            {
                yy_editEffect();
                backgroundYaya();
            }
            if (say == 220)
            {
                yy_editRed();
                backgroundYaya();

                timer4.Stop();
            }
        }
    }
}