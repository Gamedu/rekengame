using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
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

                    break;
                case "Minus":

                    break;
                case "Multiply":

                    break;
                case "Divide":

                    break;
            }

            foreach (var rb in this.RBGroup.Controls.OfType<RadioButton>())
            {
                var btnColour = rb == radioButtonSender ? "Green" : "Red";
                rb.BackgroundImage = Image.FromFile($@"Images\Button_{btnColour}_{(string)rb.Tag}.jpg");
            }
        }
    }
}