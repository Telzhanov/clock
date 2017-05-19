using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numbers
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics g;
        Pen p = new Pen(Color.Red);
        float r = 90;
        float q = 90;
        float x;
        float y;
        float x1, y1;
        public Form1()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.DrawEllipse(p, 0, 0, 200, 200);

            x = 100 + (float)Math.Cos(Math.PI * r / 180.0) * 100;
            y = 100 - (float)Math.Sin(Math.PI * r / 180.0) * 100;
            x1 = 100 + (float)Math.Cos(Math.PI * q / 180.0) * 70;
            y1 = 100 - (float)Math.Sin(Math.PI * q / 180.0) * 70;
            g.DrawLine(p, 100, 100, x1, y1);
            g.DrawLine(p, 100, 100, x, y);
            r = r - 6;
            if (Math.Abs(r-90)%360==0)
            {
                q = q - 6;
                g.DrawLine(p, 100, 100, x1, y1);
            }

            Refresh();
            g.Clear(Color.White);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
            g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            
           

        }
    }
}
