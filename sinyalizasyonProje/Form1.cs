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
        int s = 0;      //genel sayaç.
        int sYaya = 9;  //yayalar için sayaç.
        int sAna = 19;  //anayol için sayaç.

        public void ay1_editRed() //anayol 1 kırmızı oluyor.
        {
            aYol1_red.Visible = Enabled;
            aYol1_yellow.Visible = false;
            aYol1_green.Visible = false;
        }

        private void ay1_editYellow()
        {
            aYol1_red.Visible = false;
            aYol1_yellow.Visible = Enabled;
            aYol1_green.Visible = false;
        }

        public void ay1_editGreen()
        {
            aYol1_green.Visible = Enabled;
            aYol1_red.Visible = false;
            aYol1_yellow.Visible = false; 
        }

        private void ay2_editRed() //anayol 2 kırmızı oluyor.
        {
            aYol2_red.Visible = Enabled;
            aYol2_yellow.Visible = false;
            aYol2_green.Visible = false;
        }

        private void ay2_editYellow()
        {
            aYol2_red.Visible = false;
            aYol2_yellow.Visible = Enabled;
            aYol2_green.Visible = false;
        }

        public void ay2_editGreen()
        {
            aYol2_green.Visible = Enabled;
            aYol2_red.Visible = false;
            aYol2_yellow.Visible = false;
        }

        private void yy1_editRed() 
        {
            yYol1_red.Visible = Enabled;
            yYol1_green.Visible = false;
        }

        private void yy1_editGreen()
        {
            yYol1_red.Visible = false;
            yYol1_green.Visible = Enabled;
        }

        private void yy2_editRed()
        {
            yYol2_red.Visible = Enabled;
            yYol2_green.Visible = false;
        }

        private void yy2_editGreen()
        {
            yYol2_red.Visible = false;
            yYol2_green.Visible = Enabled;
        }

        private void durum1() //burada durumlar bildiriliyor.
        {
            lAna.Text = "Geç";
            lAna1.Text = "Geç";

            ay1_editGreen();
            ay2_editGreen();
            yy1_editRed();
            yy2_editRed();

            backAna(); 
        }

        private void durum2()
        {
            lAna.Font = new Font("Microsoft Sans Serif", 12);
            lAna1.Font = new Font("Microsoft Sans Serif", 12);

            lAna.Text = "Yavaşla";
            lAna1.Text = "Yavaşla";

            ay1_editYellow();
            ay2_editYellow();
            yy1_editRed();
            yy2_editRed();
        }

        private void durum3()
        {
            lAna.Font = new Font("Microsoft Sans Serif", 20);
            lAna1.Font = new Font("Microsoft Sans Serif", 20);

            lAna.Text = "Dur";
            lAna1.Text = "Dur";

            timer3.Start();

            ay1_editRed();
            ay2_editRed();
            yy1_editRed();
            yy2_editRed();

            backAna();
        }

        public void durum4()
        {
            lYaya.Text = sYaya.ToString();
            lYaya1.Text = sYaya.ToString();
            timer2.Start();

            ay1_editRed();
            ay2_editRed();
            yy1_editGreen();
            yy2_editGreen();                 

            backYaya();
        }

        private void durum5()
        {   
            timer2.Stop();
            lYaya.Text = "Dur";
            lYaya1.Text = "Dur";

            ay1_editRed();
            ay2_editRed();
            yy1_editRed();
            yy2_editRed();

            backYaya();
        }

        private void durum6()
        {
            ay1_editYellow();
            ay2_editYellow();
            yy1_editRed();
            yy2_editRed();

            backAna();
        }

        void TransparetBackground(Control C)
        {
            C.Visible = false;

            C.Refresh();
            Application.DoEvents();

            Rectangle screenRectangle = RectangleToScreen(this.ClientRectangle);
            int titleHeight = screenRectangle.Top - this.Top;
            int Right = screenRectangle.Left - this.Left;

            Bitmap bmp = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));
            Bitmap bmpImage = new Bitmap(bmp);
            bmp = bmpImage.Clone(new Rectangle
                (C.Location.X + Right, C.Location.Y + titleHeight, C.Width, C.Height), bmpImage.PixelFormat);
            C.BackgroundImage = bmp;

            C.Visible = true;
        }

        public Form1() //form açıldığında gelecek ilk ekran..
        {
            InitializeComponent();
            label1.Text = "Geçen toplam süre: " + s.ToString();
            durum1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button1.Enabled = false;
            button2.Enabled = false;

            button4.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button1.Enabled = false;
            button2.Enabled = false;

            button4.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s++;
            label1.Text = "Geçen toplam süre: " + s.ToString();

            if (s == 5) //kaçıncı saniyede hangi duruma geçeceğini söylüyor.
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
            if (s == 30)
            {
                durum1();

                timer1.Stop();
                timer3.Stop();
                MessageBox.Show("Completed", "Info");
                s = 0;
                sYaya = 9;
                sAna = 19;

                button1.Enabled = true;
                button2.Enabled = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lYaya.Text = sYaya.ToString();
            lYaya1.Text = sYaya.ToString();
            sYaya--;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            lAna.Text = sAna.ToString();
            lAna1.Text = sAna.ToString();
            sAna--;
        }

        private void backAna()
        {
            TransparetBackground(lAna);
            TransparetBackground(lAna1);
        }

        private void backYaya()
        {
            TransparetBackground(lYaya);
            TransparetBackground(lYaya1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backAna();
            backYaya();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();

            if(sYaya < 9 && 0 < sYaya)
            {
                timer2.Start();
            }
            if (sAna < 19 && 0 < sAna)
            {
                timer3.Start();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();

            button3.Enabled = true;
        }
    }
}