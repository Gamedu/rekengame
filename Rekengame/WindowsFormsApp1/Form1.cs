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
        static SerialPort usedPort = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);
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

        private void AfterFirstClick(int minValueOne, int maxValueOne, int minValueTwo, int maxValueTwo, string type)
        {
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
                tmrSumTypeCheck.Enabled = true;
                Arduino.clearIncomingData();
            }
        }

        private void SetPlayUI(bool setting, bool game, int x, int y)
        {
            ControlUIVisibility(false, true);
            pnlGame.Top = x;
            pnlGame.Left = y;
        }


        //Methode om standaard waarden terug te zetten\\
        private void ResetValues()
        {
            score = 0;
            time = 40;
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
            if (score != 0)
            {
                score--;
            }
            lblScore.Text = Convert.ToString(score);
        }

        private void tmrAnswerCheck_Tick(object sender, EventArgs e)
        {
            if (rbPlus.Checked)
            {
                Arduino.Receive(usedPort);
                if (Convert.ToString(randomNumberOne + randomNumberTwo) == Arduino.extractedData)
                {
                    ScoreUp();
                    AfterFirstClick(1, 10, 1, 10, "+");
                    Arduino.clearIncomingData();
                }
                else if (Arduino.extractedData != "" && Convert.ToString(randomNumberOne + randomNumberTwo) != Arduino.extractedData)
                {
                    ScoreDown();
                    AfterFirstClick(1, 10, 1, 10, "+");
                    Arduino.clearIncomingData();
                }
            }

            else if (rbMinus.Checked)
            {
                Arduino.Receive(usedPort);
                if (Convert.ToString(randomNumberOne - randomNumberTwo) == Arduino.extractedData)
                {
                    ScoreUp();
                    AfterFirstClick(10, 20, 1, 10, "-");
                    Arduino.clearIncomingData();
                }
                else if (Arduino.extractedData != "" && Convert.ToString(randomNumberOne - randomNumberTwo) != Arduino.extractedData)
                {
                    ScoreDown();
                    AfterFirstClick(10, 20, 1, 10, "-");
                    Arduino.clearIncomingData();
                }
            }

            else if (rbMultiply.Checked)
            {
                Arduino.Receive(usedPort);
                if (Convert.ToString(randomNumberOne * randomNumberTwo) == Arduino.extractedData)
                {
                    ScoreUp();
                    AfterFirstClick(1, 10, 1, 10, "x");
                    Arduino.clearIncomingData();
                }
                else if (Arduino.extractedData != "" && Convert.ToString(randomNumberOne * randomNumberTwo) != Arduino.extractedData)
                {
                    ScoreDown();
                    AfterFirstClick(1, 10, 1, 10, "x");
                    Arduino.clearIncomingData();
                }
            }

            else
            {
                Arduino.Receive(usedPort);
                if (Convert.ToString(randomNumberOne / randomNumberTwo) == Arduino.extractedData)
                {
                    ScoreUp();
                    AfterFirstClick(5, 10, 1, 5, ":");
                    while (randomNumberOne % randomNumberTwo != 0)
                    {
                        GenerateNumbers(5, 10, 1, 5);
                    }
                    lblSum.Text = $"{randomNumberOne}" + " : " + $"{randomNumberTwo}" + " =";
                    Arduino.clearIncomingData();
                }
                else if (Arduino.extractedData != "" && Convert.ToString(randomNumberOne / randomNumberTwo) != Arduino.extractedData)
                {
                    ScoreDown();
                    AfterFirstClick(5, 10, 1, 5, ":");
                    while (randomNumberOne % randomNumberTwo != 0)
                    {
                        GenerateNumbers(5, 10, 1, 5);
                    }
                    lblSum.Text = $"{randomNumberOne}" + " : " + $"{randomNumberTwo}" + " =";
                    Arduino.clearIncomingData();
                }
            }

        }

        private void tmrSumTypeCheck_Tick(object sender, EventArgs e)
        {
            Arduino.Receive(usedPort);
            if (Arduino.extractedData == "A")
            {
                rbPlus.PerformClick();
                AfterFirstClick(1, 10, 1, 10, "+");
                SetPlayUI(false, true, 10, 10);
                lblSum.Text = $"{randomNumberOne}" + " + " + $"{randomNumberTwo}" + " =";
                tmrSumTypeCheck.Enabled = false;
                tmrAnswerCheck.Enabled = true;
            }

            else if (Arduino.extractedData == "B")
            {
                rbMinus.PerformClick();
                AfterFirstClick(10, 20, 1, 10, "-");
                SetPlayUI(false, true, 10, 10);
                lblSum.Text = $"{randomNumberOne}" + " - " + $"{randomNumberTwo}" + " =";
                tmrSumTypeCheck.Enabled = false;
                tmrAnswerCheck.Enabled = true;
            }

            else if (Arduino.extractedData == "c")
            {
                rbMultiply.PerformClick();
                AfterFirstClick(1, 10, 1, 10, "x");
                SetPlayUI(false, true, 10, 10);
                lblSum.Text = $"{randomNumberOne}" + " x " + $"{randomNumberTwo}" + " =";
                tmrSumTypeCheck.Enabled = false;
                tmrAnswerCheck.Enabled = true;
            }

            else if (Arduino.extractedData == "D")
            {
                rbDivide.PerformClick();
                AfterFirstClick(5, 10, 1, 5, ":");
                while (randomNumberOne % randomNumberTwo != 0)
                {
                    GenerateNumbers(5, 10, 1, 5);
                }
                SetPlayUI(false, true, 10, 10);
                lblSum.Text = $"{randomNumberOne}" + " : " + $"{randomNumberTwo}" + " =";
                tmrSumTypeCheck.Enabled = false;
                tmrAnswerCheck.Enabled = true;
            }
        }
    }
}

//Selecteer rekensom door *letter* *enter*
//Uitkomst intypen door *getal* *enter*
//Implementeer de 'Receive' functie
//Op volgorde Som maken, bericht ontvangen, controleren, (bericht weghalen), nieuwe som maken etc...