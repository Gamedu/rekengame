using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //Global variables\\
        private readonly Random rnd = new Random();
        private Function function;
        private Argument one;
        private int randomNumberOne;
        private int randomNumberTwo;
        private int divisibleNumberOne;
        private int divisibleNumberTwo;
        private int score;
        private int time = 10;
        private string groep = "5 Insert Hier De Klas Uit De Database";

        public Form1()
        {
            function = new Function($"{randomNumberOne}");
            one = new Argument($"one = {randomNumberOne}");
            InitializeComponent();
            this.BackgroundImage = Image.FromFile(@"Images\Jungle_Kids.jpg");
            SetClassUI();
        }

        private void SetClassUI()
        {
            switch (groep[0])
            {
                case '3':
                    ControlUIVisibility(true, true, true, false, false, false);
                    break;
                case '4':
                    ControlUIVisibility(true, true, true, true, false, false);
                    break;
                case '5':
                case '6':
                case '7':
                case '8':
                    ControlUIVisibility(true, true, true, true, true, false);
                    break;
            }
        }

        //Click event for all the radio settings in the panel\\
        private void RadioBtn_Click(object sender, EventArgs e)
        {
            btnStart.Text = "Start";

            var radioButtonSender = (RadioButton)sender;
            foreach (var rb in this.pnlButtons.Controls.OfType<RadioButton>())
            {
                var btnColour = rb == radioButtonSender ? "Green" : "Red";
                rb.BackgroundImage = Image.FromFile($@"Images\Button_{btnColour}_{(string)rb.Tag}.png");

                lblSum.Text = "Klik op start!";
                ResetValues();
                lblScore.Text = Convert.ToString(score);
            }
        }

        //Click event for the start button\\
        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (rbPlus.Checked)
            {
                if (btnStart.Text == "Controleer")
                {
                    if (Convert.ToString(tbAnswer.Text) == Convert.ToString(randomNumberOne + randomNumberTwo))
                    {
                        ScoreUp();
                        switch (groep[0])
                        {
                            case '3':
                                AfterFirstClick(1, 6, 1, 6, "+");
                                break;
                            case '4':
                                AfterFirstClick(11, 91, 1, 11, "+");
                                break;
                            case '5':
                                AfterFirstClick(101, 501, 101, 501, "+");
                                break;
                            case '6':
                                AfterFirstClick(1001, 5001, 1001, 5001, "+");
                                break;
                            case '7':
                            case '8':
                                AfterFirstClick(10001, 50001, 10001, 50001, "+");
                                break;
                            default:
                                AfterFirstClick(1, 10, 1, 10, ":");
                                break;
                        }

                    }
                    else
                    {
                        ScoreDown();
                    }
                }

                if (btnStart.Text == "Start")
                {
                    AfterFirstClick(1, 10, 1, 10, "+");
                }
            }

            else if (rbMinus.Checked)
            {
                if (btnStart.Text == "Controleer")
                {
                    if (Convert.ToString(tbAnswer.Text) == Convert.ToString(randomNumberOne - randomNumberTwo))
                    {
                        ScoreUp();
                        switch (groep[0])
                        {
                            case '3':
                                AfterFirstClick(7, 11, 1, 6, "-");
                                break;
                            case '4':
                                AfterFirstClick(11, 101, 1, 10, "-");
                                break;
                            case '5':
                                AfterFirstClick(101, 1001, 10, 100, "-");
                                break;
                            case '6':
                                AfterFirstClick(1001, 10001, 100, 1000, "-");
                                break;
                            case '7':
                            case '8':
                                AfterFirstClick(10001, 100001, 1000, 10000, "-");
                                break;
                            default:
                                AfterFirstClick(1, 10, 1, 10, ":");
                                break;
                        }
                    }
                    else
                    {
                        if (score != 0)
                        {
                            ScoreDown();
                        }
                    }
                }

                if (btnStart.Text == "Start")
                {
                    AfterFirstClick(10, 20, 1, 10, "-");
                }


            }

            else if (rbMultiply.Checked)
            {
                if (btnStart.Text == "Controleer")
                {
                    if (Convert.ToString(tbAnswer.Text) == Convert.ToString(randomNumberOne * randomNumberTwo))
                    {
                        ScoreUp();
                        switch (groep[0])
                        {
                            case '4':
                                AfterFirstClick(1, 11, 1, 11, "x");
                                break;
                            case '5':
                                AfterFirstClick(10, 100, 1, 11, "x");
                                break;
                            case '6':
                                AfterFirstClick(10, 100, 10, 100, "x");
                                break;
                            case '7':
                            case '8':
                                AfterFirstClick(10, 1000, 10, 1000, "x");
                                break;
                            default:
                                AfterFirstClick(1, 10, 1, 10, ":");
                                break;
                        }
                    }
                    else
                    {
                        ScoreDown();
                    }
                }

                if (btnStart.Text == "Start")
                {
                    tbAnswer.Clear();
                    AfterFirstClick(1, 10, 1, 10, "x");
                }


            }

            else
            {
                if (btnStart.Text == "Controleer")
                {
                    if (Convert.ToString(tbAnswer.Text) == Convert.ToString(divisibleNumberOne / divisibleNumberTwo))
                    {
                        ScoreUp();
                        switch (groep[0])
                        {
                            case '5':
                                DivideSom(1, 11, 1, 11, ":");
                                break;
                            case '6':
                                DivideSom(1, 101, 1, 11, ":");
                                break;
                            case '7':
                            case '8':
                                DivideSom(1, 1001, 1, 101, ":");
                                break;
                            default:
                                DivideSom(1, 10, 1, 10, ":");
                                break;
                        }

                    }
                    else
                    {
                        ScoreDown();
                    }
                }

                if (btnStart.Text == "Start")
                {
                    DivideSom(5, 10, 1, 5, ":");
                    lblSum.Text = $"{divisibleNumberOne}" + " : " + $"{divisibleNumberTwo}" + " =";
                }


            }
            btnStart.Text = "Controleer";
            tbAnswer.Clear();
            this.ActiveControl = tbAnswer;
        }

        private void AfterFirstClick(int minValueOne, int maxValueOne, int minValueTwo, int maxValueTwo, string type)
        {
            tbAnswer.Clear();
            lblTime.Visible = true;
            GameCountDown.Enabled = true;
            GenerateNumbers(minValueOne, maxValueOne, minValueTwo, maxValueTwo);
            lblSum.Text = $"{randomNumberOne}" + " " + type + " " + $"{randomNumberTwo}" + " =";
        }


        private void DivideSom(int minValueOne, int maxValueOne, int minValueTwo, int maxValueTwo, string type)
        {
            tbAnswer.Clear();
            lblTime.Visible = true;
            GameCountDown.Enabled = true;
            DivisibleNumbers(minValueOne, maxValueOne, minValueTwo, maxValueTwo);
            lblSum.Text = $"{divisibleNumberOne}" + " " + type + " " + $"{divisibleNumberTwo}" + " =";
        }



        //Method for creating two random numbers that are temporarily stored as two variables\\
        private void GenerateNumbers(int minValueOne, int maxValueOne, int minValueTwo, int maxValueTwo)
        {
            randomNumberOne = rnd.Next(minValueOne, maxValueOne);
            randomNumberTwo = rnd.Next(minValueTwo, maxValueTwo);
        }

        //Deel methode om lag te voorkomen\\
        private void DivisibleNumbers(int minValueOne, int maxValueOne, int minValueTwo, int maxValueTwo)
        {
            divisibleNumberTwo = rnd.Next(minValueTwo, maxValueTwo);
            divisibleNumberOne = rnd.Next(minValueOne, maxValueOne) * divisibleNumberTwo;
        }

        private void BtnAnswer_Click(object sender, EventArgs e)
        {
            if (rbPlus.Checked)
            {
                lblSum.Text = $"{randomNumberOne}" + " + " + $"{randomNumberTwo}" + " = " +
                              $"{randomNumberOne + randomNumberTwo}";
            }

            if (rbMinus.Checked)
            {
                lblSum.Text = $"{randomNumberOne}" + " - " + $"{randomNumberTwo}" + " = " +
                              $"{randomNumberOne - randomNumberTwo}";
            }

            if (rbMultiply.Checked)
            {
                lblSum.Text = $"{randomNumberOne}" + " x " + $"{randomNumberTwo}" + " = " +
                              $"{randomNumberOne * randomNumberTwo}";
            }

            if (rbDivide.Checked)
            {
                lblSum.Text = $"{divisibleNumberOne}" + " : " + $"{divisibleNumberTwo}" + " = " +
                              $"{divisibleNumberOne / divisibleNumberTwo}";
            }
        }

        private void GameCountDown_Tick(object sender, EventArgs e)
        {
            time--;
            lblTime.Text = Convert.ToString(time);
            if (time == 0)
            {
                GameCountDown.Enabled = false;
                lblTime.Text = Convert.ToString(time);
                SetClassUI();

                MessageBox.Show($"De tijd is om. \n Je score is {score}");
                rbPlus.PerformClick();
                ResetValues();
            }
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            ControlUIVisibility(false, false, false, false, false, true);
            pnlGame.Top = 10;
            pnlGame.Left = 10;
        }


        //Methode om standaard waarden terug te zetten\\
        private void ResetValues()
        {
            score = 0;
            time = 10;
            tbAnswer.Clear();
            SetClassUI();
        }


        //Methode om UI te setten\\
        private void ControlUIVisibility(bool settings, bool btnPlus, bool btnMinus, bool btnMultiply, bool btnDivide, bool game)
        {
            pnlButtons.Visible = settings;
            rbPlus.Visible = btnPlus;
            rbMinus.Visible = btnMinus;
            rbMultiply.Visible = btnMultiply;
            rbDivide.Visible = btnDivide;
            pnlGame.Visible = game;
        }

        //Methode om de score te verhogen\\
        private void ScoreUp()
        {
            score++;
            lblScore.Text = Convert.ToString(score);
        }

        //Methode om de score te verlagen\\
        private void ScoreDown()
        {
            if (score != 0)
            {
                score--;
                lblScore.Text = Convert.ToString(score);
            }
        }

        private void TmrControle_Tick_1(object sender, EventArgs e)
        {

            if (rbPlus.Checked)
            {
                if (Convert.ToString(tbAnswer.Text) == Convert.ToString(randomNumberOne + randomNumberTwo))
                {
                    btnStart.PerformClick();
                }
            }

            if (rbMinus.Checked)
            {
                if (Convert.ToString(tbAnswer.Text) == Convert.ToString(randomNumberOne - randomNumberTwo))
                {
                    btnStart.PerformClick();
                }
            }

            if (rbMultiply.Checked)
            {
                if (Convert.ToString(tbAnswer.Text) == Convert.ToString(randomNumberOne * randomNumberTwo))
                {
                    btnStart.PerformClick();
                }
            }

            if (rbDivide.Checked)
            {
                if (divisibleNumberOne != 0 && divisibleNumberTwo != 0)
                {
                    if (Convert.ToString(tbAnswer.Text) == Convert.ToString(divisibleNumberOne / divisibleNumberTwo))
                    {
                        btnStart.PerformClick();
                    }
                }
            }
        }
    }
}

