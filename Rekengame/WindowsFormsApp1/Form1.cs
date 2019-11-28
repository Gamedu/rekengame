using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int numberOne;
        private int numberTwo;

        public Form1()
        {
            InitializeComponent();
        }

        private void RadioBtn_Click(object sender, EventArgs e)
        {
            var radioButtonSender = (RadioButton)sender;
            switch (radioButtonSender.Tag)
            {
                case "Plus":
                    numberOne = rnd.Next(50);
                    numberTwo = rnd.Next(50);
                    lblSum.Text = $"{numberOne}" + " + " + $"{numberTwo}";

                    break;
                case "Minus":
                    numberOne = rnd.Next(50);
                    numberTwo = rnd.Next(50);
                    lblSum.Text = $"{numberOne}" + " - " + $"{numberTwo}";
                    break;
                case "Multiply":
                    numberOne = rnd.Next(50);
                    numberTwo = rnd.Next(50);
                    lblSum.Text = $"{numberOne}" + " * " + $"{numberTwo}";

                    break;
                case "Divide":
                    numberOne = rnd.Next(50);
                    numberTwo = rnd.Next(50);
                    lblSum.Text = $"{numberOne}" + " / " + $"{numberTwo}";
                    break;
            }

            foreach (var rb in this.RBGroup.Controls.OfType<RadioButton>())
            {
                var btnColour = rb == radioButtonSender ? "Green" : "Red";
                rb.BackgroundImage = Image.FromFile($@"Images\Button_{btnColour}_{(string)rb.Tag}.jpg");
            }
        }


        private void TbAnswer_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (rbPlus.Checked)
            {
                if (numberOne + numberTwo == Convert.ToInt32(tbAnswer.Text))
                {
                    numberOne = rnd.Next(50);
                    numberTwo = rnd.Next(50);
                    lblSum.Text = $"{numberOne}" + " + " + $"{numberTwo}";
                }
                else if 
            }
        }
    }
}