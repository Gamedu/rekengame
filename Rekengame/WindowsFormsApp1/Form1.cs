using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;
using System.IO.Ports;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        static SerialPort usedPort = new SerialPort("COM4", 9600, Parity.None, 8, StopBits.One);
        Messages Arduino = new Messages(usedPort);
        //Global variables\\
        private readonly Random rnd = new Random();
        private int randomNumberOne;
        private int randomNumberTwo;
        private int score;
        private int time = 40;

        public Form1()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile(@"Images\Jungle_Kids.jpg");
            ControlUIVisibility(true, false);
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
/*
        void loop()
        {
            while (Arduino.receivingData == true)
            {
                Arduino.Receive(usedPort);
                if (Arduino.extractedData == Convert.ToString(randomNumberOne + randomNumberTwo))
                {

                    ScoreUp();
                    Arduino.receivingData = false;
                    Arduino.clearIncomingData();
                }
                else
                {
                    ScoreDown();
                    Arduino.receivingData = false;
                    Arduino.clearIncomingData();
                }
            }

            Arduino.receivingData = true;
        }

    */
        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (rbPlus.Checked)
            {
                if (btnStart.Text == "Controleer")
                {
                    AfterFirstClick(1, 10, 1, 10, "+");
              
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
                        AfterFirstClick(10, 20, 1, 10, "-");
                    }
                    else
                    {
                        ScoreDown();
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
                        AfterFirstClick(1, 10, 1, 10, "x");
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
                    if (Convert.ToString(tbAnswer.Text) == Convert.ToString(randomNumberOne / randomNumberTwo))
                    {
                        ScoreUp();
                        AfterFirstClick(5, 10, 1, 5, "+");
                        while (randomNumberOne % randomNumberTwo != 0)
                        {
                            GenerateNumbers(5, 10, 1, 5);
                        }
                        lblSum.Text = $"{randomNumberOne}" + " : " + $"{randomNumberTwo}" + " =";
                    }
                    else
                    {
                        ScoreDown();
                    }
                }

                if (btnStart.Text == "Start")
                {
                    AfterFirstClick(5, 10, 1, 5, "+");
                    while (randomNumberOne % randomNumberTwo != 0)
                    {
                        GenerateNumbers(5, 10, 1, 5);
                    }
                    lblSum.Text = $"{randomNumberOne}" + " : " + $"{randomNumberTwo}" + " =";
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



        //Method for creating two random numbers that are temporarily stored as two variables\\
        private void GenerateNumbers(int minValueOne, int maxValueOne, int minValueTwo, int maxValueTwo)
        {
            randomNumberOne = rnd.Next(minValueOne, maxValueOne);
            randomNumberTwo = rnd.Next(minValueTwo, maxValueTwo);
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
                lblSum.Text = $"{randomNumberOne}" + " : " + $"{randomNumberTwo}" + " = " +
                              $"{randomNumberOne / randomNumberTwo}";
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
                ControlUIVisibility(true, false);
                MessageBox.Show($"De tijd is om. \n Je score is {score}");
                rbPlus.PerformClick();
                ResetValues();
            }
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            ControlUIVisibility(false, true);
            pnlGame.Top = 10;
            pnlGame.Left = 10;

        }


        //Methode om standaard waarden terug te zetten\\
        private void ResetValues()
        {
            score = 0;
            time = 40;
            tbAnswer.Clear();
        }


        //Methode om UI te setten\\
        private void ControlUIVisibility(bool settings, bool game)
        {
            pnlButtons.Visible = settings;
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
            score--;
            lblScore.Text = Convert.ToString(score);
        }

        private void TmrControle_Tick_1(object sender, EventArgs e)
        {
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
                    if (randomNumberOne != 0 && randomNumberTwo != 0)
                    {
                        if (Convert.ToString(tbAnswer.Text) == Convert.ToString(randomNumberOne / randomNumberTwo))
                        {
                            btnStart.PerformClick();
                        }
                    }
                }
            }
        }

        private void DataReceived_Tick(object sender, EventArgs e)
        {
            Arduino.Receive(usedPort);
            if (Convert.ToString(randomNumberOne + randomNumberTwo) == Arduino.extractedData)
            {
                ScoreUp();
                AfterFirstClick(1, 10, 1, 10, "+");
                Arduino.clearIncomingData();
            }
            else if( Arduino.extractedData != "" && Convert.ToString(randomNumberOne + randomNumberTwo) != Arduino.extractedData)
            {
                ScoreDown();
                AfterFirstClick(1, 10, 1, 10, "+");
                Arduino.clearIncomingData();
            }
        }
    }
}

//Selecteer rekensom door *letter* *enter*
//Uitkomst intypen door *getal* *enter*
//Implementeer de 'Receive' functie
//Op volgorde Som maken, bericht ontvangen, controleren, (bericht weghalen), nieuwe som maken etc...