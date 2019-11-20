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
        //Wanneer je op de klas go button drukt\\
        private void BtnStart_Click(object sender, EventArgs e)
        {
            Test(Int32.Parse(tbGroup.Text));
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

        int a = 0;
        int b = 0;
        //Wanneer je je antwoord controleert\\
        private void BtnNewEquation_Click(object sender, EventArgs e)
        {
            btnNewEquation.Text = "Controleer";
            Som();
        }

        int score = 0;

        public void Som()
        {
            Random rnd = new Random();
            if (rbPlus.Checked)
            {
                PlusEquation(rnd);
            }

            else if (rbMinus.Checked)
            {
                MinusEquation(rnd);
            }

            else if (rbMultiply.Checked)
            {
                MultiplyEquation(rnd);
            }


        }
        //Maal som\\
        private void MultiplyEquation(Random rnd)
        {
            try
            {
                if (Convert.ToInt32(tbAnswer.Text) == a * b)
                {
                    score++;
                }
                else
                {
                    score--;
                }
                tbScore.Text = Convert.ToString(score);
                a = rnd.Next(10);
                b = rnd.Next(10);
                lblEquation.Text = Convert.ToString(a) + " * " + Convert.ToString(b);
                tbAnswer.Clear();
            }
            catch (Exception)
            {
                tbAnswer.Clear();
                MessageBox.Show("Voer een getal in.");
            }
        }
        //Min som\\
        private void MinusEquation(Random rnd)
        {
            try
            {
                if (Convert.ToInt32(tbAnswer.Text) == a - b)
                {
                    score++;
                }
                else
                {
                    score--;
                }
                tbScore.Text = Convert.ToString(score);
                a = rnd.Next(25,50);
                b = rnd.Next(25);
                lblEquation.Text = Convert.ToString(a) + " - " + Convert.ToString(b);
                tbAnswer.Clear();
            }
            catch (Exception)
            {
                tbAnswer.Clear();
                MessageBox.Show("Voer een getal in.");
            }
        }
        //PLus som\\
        private void PlusEquation(Random rnd)
        {
            try
            {
                if (Convert.ToInt32(tbAnswer.Text) == a + b)
                {
                    score++;
                }
                else
                {
                    score--;
                }
                tbScore.Text = Convert.ToString(score);
                a = rnd.Next(50);
                b = rnd.Next(50);
                lblEquation.Text = Convert.ToString(a) + " + " + Convert.ToString(b);
                tbAnswer.Clear();
            }
            catch (Exception)
            {
                tbAnswer.Clear();
                MessageBox.Show("Voer een getal in.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbAnswer.Text = Convert.ToString(0);
        }
    }
}
