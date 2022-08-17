using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinyalizasyonProje
{
    public partial class Form1
    {
        private void durum1() // durum1 metodu çağrıldığında olacaklar
        {
            lblAna.Text = "Geç";
            lblAna1.Text = "Geç";

            ay1_editGreen();
            ay2_editGreen();
            yy1_editRed();
            yy2_editRed();

            backgroundAna();
        }

        private void durum2()
        {
            lblAna.Font = new Font("Microsoft Sans Serif", 12);
            lblAna1.Font = new Font("Microsoft Sans Serif", 12);

            lblAna.Text = "Yavaşla";
            lblAna1.Text = "Yavaşla";

            ay1_editYellow();
            ay2_editYellow();
            yy1_editRed();
            yy2_editRed();
        }

        private void durum3()
        {
            lblAna.Font = new Font("Microsoft Sans Serif", 20);
            lblAna1.Font = new Font("Microsoft Sans Serif", 20);

            lblAna.Text = "Dur";
            lblAna1.Text = "Dur";

            timer3.Start();

            ay1_editRed();
            ay2_editRed();
            yy1_editRed();
            yy2_editRed();

            backgroundAna();
        }

        public void durum4()
        {
            lblYaya.Text = sYaya.ToString();
            lblYaya1.Text = sYaya.ToString();
            timer2.Start();

            ay1_editRed();
            ay2_editRed();
            yy1_editGreen();
            yy2_editGreen();

            backgroundYaya();
        }

        private void durum5()
        {
            timer2.Stop();
            lblYaya.Text = "Dur";
            lblYaya1.Text = "Dur";

            ay1_editRed();
            ay2_editRed();
            yy1_editRed();
            yy2_editRed();

            backgroundYaya();
        }

        private void durum6()
        {
            ay1_editYellow();
            ay2_editYellow();
            yy1_editRed();
            yy2_editRed();

            backgroundAna();
        }
    }
}
