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
        private void durum1() // Durumları ifade eder.
        {
            lblAna.Text = "Geç";
            lblAna1.Text = "Geç";

            ay_editGreen();
            yy_editRed();

            backgroundAna();
        }

        private void durum2()
        {
            lblAna.Font = new Font("Microsoft Sans Serif", 12);
            lblAna1.Font = new Font("Microsoft Sans Serif", 12);

            lblAna.Text = "Yavaşla";
            lblAna1.Text = "Yavaşla";

            ay_editYellow();
        }

        private void durum3()
        {
            lblAna.Font = new Font("Microsoft Sans Serif", 18);
            lblAna1.Font = new Font("Microsoft Sans Serif", 18);

            lblAna.Text = "Dur";
            lblAna1.Text = "Dur";

            timer3.Start();

            ay_editRed();

            backgroundAna();
        }

        public void durum4()
        {
            lblYaya.Text = sYaya.ToString();
            lblYaya1.Text = sYaya.ToString();

            timer2.Start();

            yy_editGreen();

            backgroundYaya();
        }

        private void durum5()
        {
            yy_editRed();

            lblYaya.Text = "Dur";
            lblYaya1.Text = "Dur";

            timer2.Stop();

            backgroundYaya();
        }

        private void durum6()
        {
            ay_editYellow();

            backgroundAna();
        }
    }
}