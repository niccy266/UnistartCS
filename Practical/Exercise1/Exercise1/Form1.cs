using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Pen Pen1 = new Pen(Color.Blue, 5);
        private void buttonDrawLine_Click(object sender, EventArgs e)
        {
            Graphics Paper = pictureBoxDisplay.CreateGraphics();

            Pen1.Width = 2;
            Paper.DrawLine(Pen1, 10, 10, 100, 100);
            Pen1.Width = 5;

        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDrawSquare_Click(object sender, EventArgs e)
        {
            Graphics Paper = pictureBoxDisplay.CreateGraphics();

            Pen1.Color = Color.Blue;
            Paper.DrawLine(Pen1, 10, 10, 10, 100);
            Pen1.Color = Color.Red;
            Paper.DrawLine(Pen1, 10, 100, 100, 100);
            Pen1.Color = Color.Green;
            Paper.DrawLine(Pen1, 100, 100, 100, 10);
            Pen1.Color = Color.Yellow;
            Paper.DrawLine(Pen1, 100, 10, 10, 10);

        }

        private void radioButtonRed_CheckedChanged(object sender, EventArgs e)
        {
            Pen1.Color = Color.Red;
        }

        private void radioButtonGreen_CheckedChanged(object sender, EventArgs e)
        {
            Pen1.Color = Color.Green;
        }

        private void radioButtonBlue_CheckedChanged(object sender, EventArgs e)
        {
            Pen1.Color = Color.Blue;
        }
    }
}
