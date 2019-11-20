using System;
using System.Windows.Forms;

namespace rekenen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            Test(Int32.Parse(textBox1.Text));
        }

        public void Test(int groep)
        {
            switch (groep)
            {
                case 3:
                    rbMultiply.Hide();
                    rbDivide.Hide();
                    break;
                case 4:
                    rbDivide.Hide();
                    break;
                case 5:

                    break;
                case 6:

                    break;
                case 7:
                case 8:

                    break;
                default:

                    break;
            }
        }

        private void BtnNewEquation_Click(object sender, EventArgs e)
        {
            Som();
        }

        int a;
        int b;

        public void Som()
        {
            Random rnd = new Random();
            
            a = rnd.Next(50);
            b = rnd.Next(50);

            if (rbPlus.Checked)
            {
                lblEquation.Text = 
            }
        }
    }
}
