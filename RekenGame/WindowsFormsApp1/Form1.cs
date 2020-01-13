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
        private int time = 10;
        private int sumsGenerated = 0;
        private int sumsCorrect = 0;
        private int sumsWrong = 0;
        private string group = "3 Hier komt de groep uit de database.";

        public Form1()
        {
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = this.Size;

            InitializeComponent();
            switch (group[0])
            {
                case '3':
                case '4':
                    this.BackgroundImage = Image.FromFile(@"Images\Wallpaper1.png");
                    lblIntro.ForeColor = Color.Black;
                    label3.ForeColor = Color.Black;
                    label4.ForeColor = Color.Black;
                    label5.ForeColor = Color.Black;
                    label6.ForeColor = Color.Black;
                    lblSumsMade.ForeColor = Color.Black;
                    lblSumsCorrect.ForeColor = Color.Black;
                    lblSumsWrong.ForeColor = Color.Black;
                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                    lblScore.ForeColor = Color.Black;
                    lblTime.ForeColor = Color.Black;
                    lblSum.ForeColor = Color.Black;
                    break;
                case '5':
                case '6':
                    this.BackgroundImage = Image.FromFile(@"Images\Wallpaper2.png");
                    pnlButtons.Top = 85;
                    pnlButtons.Left = 15;
                    lblIntro.ForeColor = Color.White;
                    label3.ForeColor = Color.White;
                    label4.ForeColor = Color.White;
                    label5.ForeColor = Color.White;
                    label6.ForeColor = Color.White;
                    lblSumsMade.ForeColor = Color.White;
                    lblSumsCorrect.ForeColor = Color.White;
                    lblSumsWrong.ForeColor = Color.White;
                    label1.ForeColor = Color.White;
                    label2.ForeColor = Color.White;
                    lblScore.ForeColor = Color.White;
                    lblTime.ForeColor = Color.White;
                    lblSum.ForeColor = Color.White;
                    break;
                case '7':
                case '8':
                    this.BackgroundImage = Image.FromFile(@"Images\Wallpaper3.png");
                    break;
                default:
                    this.BackgroundImage = Image.FromFile(@"Images\Jungle_Kids.jpg");
                    break;
            }
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
                ResetValues();
                tmrSumTypeCheck.Enabled = true;
                Arduino.ClearIncomingData();
                tmrInfo.Enabled = true;
            }
        }

        //methode om de UI te setten\\
        private void SetPlayUI(bool setting, bool game, bool info, int x, int y)
        {
            ControlUIVisibility(setting, game, info);
            switch (group[0])
            {
                case '3':
                case '4':
                    pnlGame.Top = x;
                    pnlGame.Left = y + 75;
                    pnlInfo.Top = x;
                    pnlInfo.Left = y;
                    break;
                case '5':
                case '6':
                    pnlGame.Top = x + 50;
                    pnlGame.Left = y + 125;
                    pnlInfo.Top = x;
                    pnlInfo.Left = y + 100;
                    break;
                case '7':
                case '8':
                    pnlGame.Top = x;
                    pnlGame.Left = y;
                    pnlInfo.Top = x;
                    pnlInfo.Left = y + 100;
                    break;
                default:
                    pnlGame.Top = x;
                    pnlGame.Left = y;
                    pnlInfo.Top = x;
                    pnlInfo.Left = y + 100;
                    break;
            }
        }


        //Methode om standaard waarden terug te zetten\\
        private void ResetValues()
        {
            score = 0;
            time = 10;
            sumsGenerated = 0;
            sumsCorrect = 0;
            sumsWrong = 0;
        }


        //Methode om de UI zichtbaar te maken\\
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

        //Maak hier een switchcase methode aarin je zowel de som als de getallen in kunt stellen.
        //Dan hoef je dat later niet meer in te stellen bij de Arduino communicatie.
        private void SumGenerator()
        {
            if (rbPlus.Checked)
            {
                switch (group[0])
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
                        AfterFirstClick(1, 10, 1, 10, "+");
                        break;
                }

            }

            if (rbMinus.Checked)
            {
                switch (group[0])
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
                        AfterFirstClick(1, 10, 1, 10, "-");
                        break;
                }

            }

            if (rbMultiply.Checked)
            {
                switch (group[0])
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
                        AfterFirstClick(1, 10, 1, 10, "x");
                        break;
                }

            }

            if (rbDivide.Checked)
            {
                switch (group[0])
                {
                    case '5':
                        break;
                    case '6':
                        break;
                    case '7':
                    case '8':
                        break;
                    default:
                        break;
                }
            }
        }

        private void tmrAnswerCheck_Tick(object sender, EventArgs e)
        {
            if (rbPlus.Checked)
            {
                Arduino.Receive(usedPort);
                if (Convert.ToString(randomNumberOne + randomNumberTwo) == Arduino.ExtractedData)
                {
                    ScoreUp();
                    SumGenerator();
                    Arduino.ClearIncomingData();
                }
                else if (Arduino.ExtractedData != "" && Convert.ToString(randomNumberOne + randomNumberTwo) != Arduino.ExtractedData)
                {
                    Arduino.SendMessage("test", usedPort);
                    ScoreDown();
                    SumGenerator();
                    Arduino.ClearIncomingData();
                }
            }

            else if (rbMinus.Checked)
            {
                Arduino.Receive(usedPort);
                if (Convert.ToString(randomNumberOne - randomNumberTwo) == Arduino.ExtractedData)
                {
                    ScoreUp();
                    SumGenerator();
                    Arduino.ClearIncomingData();
                }
                else if (Arduino.ExtractedData != "" && Convert.ToString(randomNumberOne - randomNumberTwo) != Arduino.ExtractedData)
                {
                    Arduino.SendMessage("test", usedPort);
                    ScoreDown();
                    SumGenerator();
                    Arduino.ClearIncomingData();
                }
            }

            else if (rbMultiply.Checked)
            {
                Arduino.Receive(usedPort);
                if (Convert.ToString(randomNumberOne * randomNumberTwo) == Arduino.ExtractedData)
                {
                    ScoreUp();
                    SumGenerator();
                    Arduino.ClearIncomingData();
                }
                else if (Arduino.ExtractedData != "" && Convert.ToString(randomNumberOne * randomNumberTwo) != Arduino.ExtractedData)
                {
                    Arduino.SendMessage("test", usedPort);
                    ScoreDown();
                    SumGenerator();
                    Arduino.ClearIncomingData();
                }
            }

            else
            {
                Arduino.Receive(usedPort);
                if (Convert.ToString(randomNumberOne / randomNumberTwo) == Arduino.ExtractedData)
                {
                    ScoreUp();
                    SumGenerator();
                    while (randomNumberOne % randomNumberTwo != 0)
                    {
                        SumGenerator();
                    }
                    lblSum.Text = $"{randomNumberOne}" + " : " + $"{randomNumberTwo}" + " =";
                    Arduino.ClearIncomingData();
                }
                else if (Arduino.ExtractedData != "" && Convert.ToString(randomNumberOne / randomNumberTwo) != Arduino.ExtractedData)
                {
                    Arduino.SendMessage("test", usedPort);
                    ScoreDown();
                    SumGenerator();
                    while (randomNumberOne % randomNumberTwo != 0)
                    {
                        SumGenerator();
                    }
                    lblSum.Text = $"{randomNumberOne}" + " : " + $"{randomNumberTwo}" + " =";
                    Arduino.ClearIncomingData();
                }
            }

        }

        private void tmrSumTypeCheck_Tick(object sender, EventArgs e)
        {
            Arduino.Receive(usedPort);
            if (Arduino.ExtractedData == "A")
            {
                rbPlus.PerformClick();
                SumGenerator();
                SetPlayUI(false, true, false, 150, 500);
                lblSum.Text = $"{randomNumberOne}" + " + " + $"{randomNumberTwo}" + " =";
                tmrSumTypeCheck.Enabled = false;
                tmrAnswerCheck.Enabled = true;
            }

            else if (Arduino.ExtractedData == "B")
            {
                rbMinus.PerformClick();
                SumGenerator();
                SetPlayUI(false, true, false, 150, 500);
                lblSum.Text = $"{randomNumberOne}" + " - " + $"{randomNumberTwo}" + " =";
                tmrSumTypeCheck.Enabled = false;
                tmrAnswerCheck.Enabled = true;
            }

            else if (Arduino.ExtractedData == "C")
            {
                rbMultiply.PerformClick();
                SumGenerator();
                SetPlayUI(false, true, false, 150, 500);
                lblSum.Text = $"{randomNumberOne}" + " x " + $"{randomNumberTwo}" + " =";
                tmrSumTypeCheck.Enabled = false;
                tmrAnswerCheck.Enabled = true;
            }

            else if (Arduino.ExtractedData == "D")
            {
                rbDivide.PerformClick();
                SumGenerator();
                while (randomNumberOne % randomNumberTwo != 0)
                {
                    SumGenerator();
                }
                SetPlayUI(false, true, false, 150, 50);
                lblSum.Text = $"{randomNumberOne}" + " : " + $"{randomNumberTwo}" + " =";
                tmrSumTypeCheck.Enabled = false;
                tmrAnswerCheck.Enabled = true;
            }
            Arduino.ClearIncomingData();
        }

        private void tmrInfo_Tick(object sender, EventArgs e)
        {
            ControlUIVisibility(true, false, false);
            tmrInfo.Enabled = false;
        }
    }
}

//Maak een optie zodat kinderen de timer in kunnen stellen\\
//Doe dit door een nieuwe UI in te stellen met de tekst "Vul hier in hoe lang je wilt oefenen."\\