using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinyalizasyonProje
{
    public partial class Form1
    {
        public void ay_editRed() // Ana yol kırmızı oluyor
        {
            aYol1.Image = Properties.Resources.anaKirmizi;
            aYol2.Image = Properties.Resources.anaKirmizi;
        }

        private void ay_editYellow() // Ana yol sarı oluyor
        {
            aYol1.Image = Properties.Resources.anaSari;
            aYol2.Image = Properties.Resources.anaSari;
        }

        public void ay_editGreen() // Anayol yeşil oluyor
        {
            aYol1.Image = Properties.Resources.anaYesil;
            aYol2.Image = Properties.Resources.anaYesil;
        }

        private void yy_editRed() // Yaya yol kırmızı oluyor
        {
            yYol1.Image = Properties.Resources.yayaKirmizi;
            yYol2.Image = Properties.Resources.yayaKirmizi;
        }

        private void yy_editGreen() // Yaya yol yeşil oluyor
        {
            yYol1.Image = Properties.Resources.yayaYesil;
            yYol2.Image = Properties.Resources.yayaYesil;
        }
        private void yy_editEffect() // Şeffaflaştırma
        {
            yYol1.Image = Properties.Resources.effect;
            yYol2.Image = Properties.Resources.effect;
        }
    }
}
