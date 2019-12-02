using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //Global variables\\
        private readonly Random rnd = new Random();
        private int randomNumberOne;
        private int randomNumberTwo;
        private int score;

        public Form1()
        {
            InitializeComponent();
        }

        //Click event for all the radio buttons in the panel\\
        private void RadioBtn_Click(object sender, EventArgs e)
        {
            btnStart.Text = "Start";

            var radioButtonSender = (RadioButton)sender;
            foreach (var rb in this.pnlButtons.Controls.OfType<RadioButton>())
            {
                var btnColour = rb == radioButtonSender ? "Green" : "Red";
                rb.BackgroundImage = Image.FromFile($@"Images\Button_{btnColour}_{(string)rb.Tag}.jpg");
                GenerateNumbers(1, 50, 1, 50 );
                lblSum.Text = "{randomNumberOne}" + rb.Text + "{randomNumberTwo}";
            }
        }

        //Click event for the start button\\
        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Controleer")
            {
                if (Convert.ToInt32(tbAnswer.Text) == randomNumberOne + randomNumberTwo)
                {
                    score++;
                    lblScore.Text = Convert.ToString(score);
                }
                else
                {
                    score--;
                    lblScore.Text = Convert.ToString(score);
                }
            }

            tbAnswer.Clear();
            btnStart.Text = "Controleer";

            GenerateNumbers(1, 10, 1, 10);
            lblSum.Text = $"Wat is {randomNumberOne} + {randomNumberTwo}";
        }

        //Method for creating two random numbers that are temporarily stored as two variables\\
        private void GenerateNumbers(int minValueOne, int maxValueOne, int minValueTwo, int maxValueTwo)
        {
            randomNumberOne = rnd.Next(minValueOne, maxValueOne);
            randomNumberTwo = rnd.Next(minValueTwo, maxValueTwo);
        }
    }
}