using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excercise1b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics drawing = pictureBoxDisplay.CreateGraphics();
            Pen Pen1 = new Pen(Color.Gray, 2);

            //drawing.DrawLine(Pen1, 0, 0, e.X, e.Y);
            drawing.DrawLine(Pen1, pictureBoxDisplay.Width/2, pictureBoxDisplay.Height/2, e.X, e.Y);
        }
    }
}
