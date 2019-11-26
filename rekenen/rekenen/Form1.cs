using System;
using System.Drawing;
using System.Windows.Forms;

namespace rekenen
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        //Wanneer je op de klas go button drukt\\
        private void BtnGroup_Click(object sender, EventArgs e)
        {
            try
            {
                Test(Int32.Parse(tbGroup.Text));
            }
            catch (Exception)
            {

                tbGroup.Clear();
                MessageBox.Show("Voer een getal in.");
            }
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
            tbScore.Enabled = false;
        }

        int score = 0;

        public void Som()
        {
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
            else if (rbDivide.Checked)
            {
                DivideEquation(rnd);
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
                lblEquation.Text = Convert.ToString(a) + " x " + Convert.ToString(b);
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
                a = rnd.Next(25, 50);
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
        //Plus som\\
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
        //Deel som\\
        private void DivideEquation(Random rnd)
        {
            a = rnd.Next(25, 50);
            b = rnd.Next(1, 25);
            while (a % b != 0)
            {
                a = rnd.Next(10, 25);
                b = rnd.Next(1, 10);
            }
            lblEquation.Text = Convert.ToString(a) + " : " + Convert.ToString(b);
            try
            {
                if (Convert.ToInt32(tbAnswer.Text) == a / b)
                {
                    score++;
                }
                else
                {
                    score--;
                }
                tbScore.Text = Convert.ToString(score);


                tbAnswer.Clear();
            }

            catch (Exception)
            {
                tbAnswer.Clear();
                MessageBox.Show("Voer een getal in.");
            }
        }

        private void RbPlus_Click(object sender, EventArgs e)
        {
            int a = rnd.Next(1, 50);
            int b = rnd.Next(1, 50);
            lblEquation.Text = Convert.ToString(a) + " + " + Convert.ToString(b);
            tbAnswer.Clear();
            tbScore.Clear();
        }

        private void RbMinus_Click(object sender, EventArgs e)
        {
            int a = rnd.Next(25, 50);
            int b = rnd.Next(1, 25);

            lblEquation.Text = Convert.ToString(a) + " - " + Convert.ToString(b);
            tbAnswer.Clear();
            tbScore.Clear();
        }

        private void RbMultiply_Click(object sender, EventArgs e)
        {
            int a = rnd.Next(1, 5);
            int b = rnd.Next(1, 5);

            lblEquation.Text = Convert.ToString(a) + " x " + Convert.ToString(b);
            tbAnswer.Clear();
            tbScore.Clear();
        }

        private void RbDivide_Click(object sender, EventArgs e)
        {
            int a = rnd.Next(10, 25);
            int b = rnd.Next(1, 10);
            while (a % b != 0)
            {
                a = rnd.Next(10, 25);
                b = rnd.Next(1, 10);
            }
            lblEquation.Text = Convert.ToString(a) + " : " + Convert.ToString(b);
            tbAnswer.Clear();
            tbScore.Clear();
        }
    }
}
