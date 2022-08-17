using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinyalizasyonProje
{
    public partial class Form1
    {
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

        private void backgroundAna() // Ana yol ışığının üzerindeki sayacın arka planını düzenler..
        {
            TransparetBackground(lblAna);
            TransparetBackground(lblAna1);
        }

        private void backgroundYaya() // Yaya geçidi ışığının üzerindeki sayacın arka planını düzenler..
        {
            TransparetBackground(lblYaya);
            TransparetBackground(lblYaya1);
        }
    }
}
