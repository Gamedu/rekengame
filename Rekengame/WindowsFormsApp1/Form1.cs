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
        private int sumsGenerated = 0;
        private int sumsCorrect = 0;
        private int sumsWrong = 0;

        public Form1()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile(@"Images\Jungle_Kids.jpg");
            ControlUIVisibility(true, false, false);
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
                lblSumsMade.Text = $"Je hebt {sumsGenerated} sommen gemaakt";
                lblSumsCorrect.Text = $"Je hebt er {sumsCorrect} goed beantwoord";
                lblSumsWrong.Text = $"Je hebt er {sumsWrong} fout beantwoord";
                ControlUIVisibility(false, false, true);
                rbPlus.PerformClick();
                ResetValues(); //Geeft mogelijk conflict met regel 57 aangezien de score wordt geleegd tijdens het laten zien van de score in pnlInfo\\
                tmrSumTypeCheck.Enabled = true;
                Arduino.clearIncomingData();
            }
        }

        private void SetPlayUI(bool setting, bool game, int x, int y)
        {
            ControlUIVisibility(false, true, false);
            pnlGame.Top = x;
            pnlGame.Left = y;
            pnlInfo.Top = x;
            pnlInfo.Left = y;
        }


        //Methode om standaard waarden terug te zetten\\
        private void ResetValues()
        {
            score = 0;
            time = 40;
            sumsGenerated = 0;
            sumsCorrect = 0;
            sumsWrong = 0;
        }


        //Methode om UI te setten\\
        private void ControlUIVisibility(bool settings, bool game, bool info)
        {
            pnlButtons.Visible = settings;
            pnlGame.Visible = game;
            pnlInfo.Visible = info;
        }

        //Methode om de score te verhogen\\
        private void ScoreUp()
        {
            score++;
            lblScore.Text = Convert.ToString(score);
            sumsGenerated++;
            sumsCorrect++;
        }

        //Methode om de score te verlagen\\
        private void ScoreDown()
        {
            if (score != 0)
            {
                score--;
            }
            lblScore.Text = Convert.ToString(score);
            sumsGenerated++;
            sumsWrong++;
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
            Arduino.clearIncomingData();
        }
    }
}