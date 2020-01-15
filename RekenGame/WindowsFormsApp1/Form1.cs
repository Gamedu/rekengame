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

        dbi441943Entities DbContext = new dbi441943Entities();

        //Global variables\\
        private readonly Random rnd = new Random();
        private int randomNumberOne;
        private int randomNumberTwo;
        private int score;
        private int sumsGenerated = 0;
        private int sumsCorrect = 0;
        private int sumsWrong = 0;
        int time;

        private string group = "";

        public Form1()
        {
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = this.Size;

            InitializeComponent();

            var user = DbContext.Students.Where(s => s.EmailAddress == "brian@hotmail.com").FirstOrDefault();

            group = user.Groups.GroupName;

            switch (group[0])
            {
                case '3':
                case '4':
                    this.BackgroundImage = Image.FromFile(@"Images\Wallpaper1.png");
                    pnlSetTime.Top = 85;
                    pnlSetTime.Left = 15;
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
                    lblSetTime.ForeColor = Color.Black;
                    lblSetTime2.ForeColor = Color.Black;
                    lblTotalScore.ForeColor = Color.Black;
                    break;
                case '5':
                case '6':
                    this.BackgroundImage = Image.FromFile(@"Images\Wallpaper2.png");
                    pnlButtons.Top = 85;
                    pnlButtons.Left = 15;
                    pnlSetTime.Top = 85;
                    pnlSetTime.Left = 15;
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
                    lblSetTime.ForeColor = Color.White;
                    lblSetTime2.ForeColor = Color.White;
                    lblTotalScore.ForeColor = Color.White;
                    break;
                case '7':
                case '8':
                    this.BackgroundImage = Image.FromFile(@"Images\Wallpaper3.png");
                    pnlButtons.Top = 80;
                    pnlButtons.Left = 70;
                    pnlSetTime.Top = 80;
                    pnlSetTime.Left = 120;
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
                    lblSetTime.ForeColor = Color.Black;
                    lblSetTime2.ForeColor = Color.Black;
                    lblTotalScore.ForeColor = Color.Black;
                    break;
                default:
                    this.BackgroundImage = Image.FromFile(@"Images\Jungle_Kids.jpg");
                    break;
            }
            ControlUIVisibility(true, false, false, false);
        }

        #region Choose Sum
        private void tmrSumTypeCheck_Tick(object sender, EventArgs e)
        {
            Arduino.Receive(usedPort);
            if (Arduino.ExtractedData == "A")
            {
                rbPlus.PerformClick();
                SumGenerator();
                ControlUIVisibility(false, true, false, false);
                lblSum.Text = $"{randomNumberOne}" + " + " + $"{randomNumberTwo}" + " =";
                SetTimers(false, true, false, false, false);
            }

            else if (Arduino.ExtractedData == "B")
            {
                rbMinus.PerformClick();
                SumGenerator();
                ControlUIVisibility(false, true, false, false);
                lblSum.Text = $"{randomNumberOne}" + " - " + $"{randomNumberTwo}" + " =";
                SetTimers(false, true, false, false, false);
            }

            else if (Arduino.ExtractedData == "C")
            {
                rbMultiply.PerformClick();
                SumGenerator();
                ControlUIVisibility(false, true, false, false);
                lblSum.Text = $"{randomNumberOne}" + " x " + $"{randomNumberTwo}" + " =";
                SetTimers(false, true, false, false, false);
            }

            else if (Arduino.ExtractedData == "D")
            {
                rbDivide.PerformClick();
                SumGenerator();
                ControlUIVisibility(false, true, false, false);
                lblSum.Text = $"{randomNumberOne}" + " : " + $"{randomNumberTwo}" + " =";
                SetTimers(false, true, false, false, false);
            }
            Arduino.ClearIncomingData();
        }
        #endregion

        #region Set Time
        private void tmrSetTime_Tick(object sender, EventArgs e)
        {
            Arduino.Receive(usedPort);
            if (Arduino.ExtractedData != "")
            {
                time = Convert.ToInt32(Arduino.ExtractedData);
                SetPlayUI(false, false, true, false, 150, 500);
                SetTimers(false, false, true, true, false);
                Arduino.ClearIncomingData();
            }

        }
        #endregion

        #region Determines Sum Values
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
                    case '4':
                        AfterFirstClick(1, 5, 1, 5, ":");
                        break;
                    case '5':
                        AfterFirstClick(1, 10, 1, 10, ":");
                        break;
                    case '6':
                        AfterFirstClick(10, 101, 1, 10, ":");
                        break;
                    case '7':
                    case '8':
                        AfterFirstClick(10, 101, 10, 21, ":");
                        break;
                    default:
                        AfterFirstClick(1, 10, 1, 10, ":");
                        break;
                }
            }
        }
        #endregion

        #region Sum Generator
        private void AfterFirstClick(int minValueOne, int maxValueOne, int minValueTwo, int maxValueTwo, string type)
        {
            lblTime.Visible = true;
            if (rbDivide.Checked)
            {
                GenerateDivisableSum(minValueOne, maxValueOne, minValueTwo, maxValueTwo);
            }
            else
            {
                GenerateNumbers(minValueOne, maxValueOne, minValueTwo, maxValueTwo);
            }
            lblSum.Text = $"{randomNumberOne}" + " " + type + " " + $"{randomNumberTwo}" + " =";
        }


        //Method for creating two random numbers that are temporarily stored as two variables\\
        private void GenerateNumbers(int minValueOne, int maxValueOne, int minValueTwo, int maxValueTwo)
        {
            randomNumberOne = rnd.Next(minValueOne, maxValueOne);
            randomNumberTwo = rnd.Next(minValueTwo, maxValueTwo);
        }

        private void GenerateDivisableSum(int minValueOne, int maxValueOne, int minValueTwo, int maxValueTwo)
        {
            randomNumberTwo = rnd.Next(minValueTwo, maxValueTwo);
            randomNumberOne = (rnd.Next(minValueOne, maxValueOne) * randomNumberTwo);
        }
        #endregion

        #region Answer Check
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
                    Arduino.SendMessage("wrong", usedPort);
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
                    Arduino.SendMessage("wrong", usedPort);
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
                    Arduino.SendMessage("wrong", usedPort);
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
                    Arduino.SendMessage("wrong", usedPort);
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
        #endregion

        #region End Game Timer
        private void GameCountDown_Tick(object sender, EventArgs e)
        {
            var user = DbContext.Students.Where(s => s.EmailAddress == "brian@hotmail.com").FirstOrDefault();


            time--;
            lblTime.Text = Convert.ToString(time);
            if (time == 0)
            {
                GameCountDown.Enabled = false;
                lblTime.Text = Convert.ToString(time);
                lblSumsMade.Text = $"Je hebt {sumsGenerated} sommen gemaakt.";
                lblSumsCorrect.Text = $"Je hebt er {sumsCorrect} goed beantwoord.";
                lblSumsWrong.Text = $"Je hebt er {sumsWrong} fout beantwoord.";
                lblTotalScore.Text = $"Je hebt {score} punten behaald.";

                var ScoreToAdd = new MathGameScores
                {
                    CorrectSums = sumsCorrect,
                    InCorrectSums = sumsWrong,
                    FinalScore = score,
                    SaveTime = DateTime.Now,
                    StudentId = user.StudentId,
                    TotalSum = sumsGenerated
                };

                DbContext.MathGameScores.Add(ScoreToAdd);

                DbContext.SaveChanges();

                ControlUIVisibility(false, false, false, true);
                rbPlus.PerformClick();
                ResetValues();
                Arduino.ClearIncomingData();
                SetTimers(false, false, false, false, true);
            }
        }
        #endregion

        #region Show End-Game info
        private void tmrInfo_Tick(object sender, EventArgs e)
        {
            ControlUIVisibility(true, false, false, false);
            SetTimers(true, false, false, false, false);
        }
        #endregion

        #region UI Instellingen
        //methode om de UI te setten\\
        private void SetPlayUI(bool setting, bool setTime, bool game, bool info, int x, int y)
        {
            ControlUIVisibility(setting, setTime, game, info);
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
                    pnlGame.Top = x + 250;
                    pnlGame.Left = y + 150;
                    pnlInfo.Top = x + 250;
                    pnlInfo.Left = y + 150;
                    break;
                default:
                    pnlGame.Top = x;
                    pnlGame.Left = y;
                    pnlInfo.Top = x;
                    pnlInfo.Left = y;
                    break;
            }
        }

        private void ControlUIVisibility(bool settings, bool setTime, bool game, bool info)
        {
            pnlButtons.Visible = settings;
            pnlSetTime.Visible = setTime;
            pnlGame.Visible = game;
            pnlInfo.Visible = info;
        }
        #endregion

        #region methode die standaardwaarde reset
        //Methode om standaard waarden terug te zetten\\
        private void ResetValues()
        {
            score = 0;
            sumsGenerated = 0;
            sumsCorrect = 0;
            sumsWrong = 0;
        }
        #endregion

        #region Methodes om score te verhogen en verlagen
        private void ScoreUp()
        {
            score++;
            lblScore.Text = Convert.ToString(score);
            sumsGenerated++;
            sumsCorrect++;
        }

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
        #endregion

        #region Methode die timers Set
        private void SetTimers(bool sumType, bool timeSet, bool answerCheck, bool gameCountDown, bool info)
        {
            tmrSumTypeCheck.Enabled = sumType;
            tmrSetTime.Enabled = timeSet;
            tmrAnswerCheck.Enabled = answerCheck;
            GameCountDown.Enabled = gameCountDown;
            tmrInfo.Enabled = info;
        }
        #endregion

    }
}