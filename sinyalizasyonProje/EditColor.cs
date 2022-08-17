using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinyalizasyonProje
{
    public partial class Form1
    {
        public void ay1_editRed() // Ana yol 1 kırmızı oluyor.
        {
            aYol1_red.Visible = Enabled;
            aYol1_yellow.Visible = false;
            aYol1_green.Visible = false;
        }

        private void ay1_editYellow() // Ana yol 1 sarı oluyor.
        {
            aYol1_red.Visible = false;
            aYol1_yellow.Visible = Enabled;
            aYol1_green.Visible = false;
        }

        public void ay1_editGreen() // Anayol 1 yeşil oluyor.
        {
            aYol1_green.Visible = Enabled;
            aYol1_red.Visible = false;
            aYol1_yellow.Visible = false;
        }

        private void ay2_editRed() 
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
    }
}
