using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3
{
    public partial class Form1 : Form
    {
        public static Random randNum = new Random();      

        public Form1()
        {
            InitializeComponent();
        }

        private void StarField(float stars)
        {

            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Cyan, 10);
            SolidBrush b = new SolidBrush(Color.Black);
            int counter = 0;

            while (counter < stars)
            {
                counter++;
                int x = randNum.Next(0, this.Width);
                int y = randNum.Next(0, this.Height);
                int colour1 = randNum.Next(0, 256);
                int colour2 = randNum.Next(0, 256);
                int colour3 = randNum.Next(0, 256);

                p.Color = Color.FromArgb(colour1, colour2, colour3, 0);
                g.DrawEllipse(p, x, y, 1, 1);
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            StarField(100);
        }
    }
}
