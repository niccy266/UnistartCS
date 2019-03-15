using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial_A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Pen myPen = new Pen(Color.Red, 5);//this is outside of the methods so that it can be accessed by the radio buttons I set up (global)
        private void buttonDrawLine_Click(object sender, EventArgs e)
        {
            //Excercise 1: Definitions
            /*
            Define: Objects
            An object is a thing with characteristics.
            In a programming sense, it is a thing with
            self-contained Properties and Methods that
            can be reached by interacting with the Object

            Another definition for a programming Object
            is that it is an instance of a Class
            
            Define: Classes
            A class is a plan or blue print for an object. 
            It describes the default properties and methods 
            of an object that would belong to that class.
            For example, every Student (someone from a student Class)
            would have a name (name property)

            As many objects as you like can be created from any 1 class.

            Define: Properties / Attributes
            Data that Characterizes an Object.
            We only store the information which we are interested in.

            For example, a vet program would need animal objects
            to store the information of an patients's diseases

            Define: Methods / Behaviours
            Functions stored in an object, which you can call through the object
            Operations or actions which an object can perform.
            
            For example: a graphics object can draw on the form.
            */

            /*Excercise 2: Comments - Explaining what the code does.
            
            //This creates a new canvas object from the Graphics class
            //linking it to the pictureBox
            Graphics paper = pictureBoxDisplay.CreateGraphics();

            //This code creates a new pen from the Pen class
            //with the colour Blue, and a pen width/thickness of 5
            Pen myPen = new Pen(Color.Blue, 5);

            //calls a method from the new paper object
            //using the pen object to draw a line
            //from 10, 30 to 100, 200
            paper.DrawLine(myPen, 10, 30, 100, 200);

            */

            //Excercise 3: Drawing a second line
            //uncomment the following section to draw the blue line with the smaller red line next to it
            /*
            Pen bluePen = new Pen(Color.Blue, 5);
            Pen redPen = new Pen(Color.Red, 2);

            paper.DrawLine(bluePen, 10, 30, 100, 200);
            paper.DrawLine(redPen, 150, 100, 250, 200);
            */

            //Excercise 4: Drawing two different colour and thickness lines with the same pen
            //uncomment the following section to draw the blue line with the smaller red line next to it, 
            //and the third line, which is drawn with the (edited) first pen
            /*
            Pen pen1 = new Pen(Color.Blue, 5);
            Pen pen2 = new Pen(Color.Red, 2);

            paper.DrawLine(pen1, 10, 30, 100, 200);
            paper.DrawLine(pen2, 150, 100, 250, 200);

            pen1.Color = Color.Red;
            pen1.Width = 10;

            paper.DrawLine(pen1, 200, 45, 150, 300);
            */


            //Excercise 5: Drawing a line from the top left to the center of the picturebox
            //uncomment the following section to draw a line from the top left to the center of the picture box
            /*
            Pen myPen = new Pen(Color.Blue, 5);

            paper.DrawLine(myPen, 0, 0, pictureBoxDisplay.Width / 2, pictureBoxDisplay.Height / 2);
            */


            //Excercise 6: What shape will be drawn?
            //This section of code draws a triangle. To move it to another location, 
            //I have to change the coordinates for every time the DrawLine method is used
            /*
            Pen pen1 = new Pen(Color.Red, 2);
            paper.DrawLine(pen1, 100, 50, 150, 100);
            paper.DrawLine(pen1, 150, 100, 50, 100);
            paper.DrawLine(pen1, 50, 100, 100, 50);
            */

            //Excercise 7: Moving the triangle
            //to demonstrate my understanding, I have increased every value for the coordinates of the lines by 50 each, 
            //which will move the shape 50 pixels down and 50 pixels to the right
            /*
            Pen pen1 = new Pen(Color.Red, 2);
            paper.DrawLine(pen1, 150, 100, 200, 150);
            paper.DrawLine(pen1, 200, 150, 100, 150);
            paper.DrawLine(pen1, 100, 150, 150, 100);
            */

            //Excercise 8: Completed in a jpg file stored in my Tutorial A folder

            //leaving some functionality for while none of the above code is uncommented
            paper.DrawLine(myPen, 0, 0, pictureBoxDisplay.Width / 2, pictureBoxDisplay.Height / 2);
        }
        private void buttonHiMark_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ohHiMark = new System.Media.SoundPlayer(Resource1.Oh__hi_Mark);
            ohHiMark.Play();
            //I made an extra button that plays a sound file from a movie haha. I googled how to do it and store resources in the file
        }

        private void radioButtonRed_CheckedChanged(object sender, EventArgs e)
        {
            myPen.Color = Color.Red;//by default, red is selected and this is shown by it being selected when you open the window
        }

        private void radioButtonBlue_CheckedChanged(object sender, EventArgs e)
        {
            myPen.Color = Color.Blue;//clicking one of these will change the colour of the myPen object
        }

        private void radioButtonGreen_CheckedChanged(object sender, EventArgs e)
        {
            myPen.Color = Color.Green;
        }
    }
}
