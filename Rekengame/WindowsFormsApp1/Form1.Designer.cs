namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rbPlus = new System.Windows.Forms.RadioButton();
            this.rbMinus = new System.Windows.Forms.RadioButton();
            this.rbMultiply = new System.Windows.Forms.RadioButton();
            this.rbDivide = new System.Windows.Forms.RadioButton();
            this.lblSum = new System.Windows.Forms.Label();
            this.GameCountDown = new System.Windows.Forms.Timer(this.components);
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIntro = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlGame = new System.Windows.Forms.Panel();
            this.tmrAnswerCheck = new System.Windows.Forms.Timer(this.components);
            this.tmrSumTypeCheck = new System.Windows.Forms.Timer(this.components);
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblSumsWrong = new System.Windows.Forms.Label();
            this.lblSumsCorrect = new System.Windows.Forms.Label();
            this.lblSumsMade = new System.Windows.Forms.Label();
            this.tmrInfo = new System.Windows.Forms.Timer(this.components);
            this.tmrSetTime = new System.Windows.Forms.Timer(this.components);
            this.pnlSetTime = new System.Windows.Forms.Panel();
            this.lblSetTime2 = new System.Windows.Forms.Label();
            this.lblSetTime = new System.Windows.Forms.Label();
            this.lblTotalScore = new System.Windows.Forms.Label();
            this.pnlButtons.SuspendLayout();
            this.pnlGame.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.pnlSetTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbPlus
            // 
            this.rbPlus.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbPlus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbPlus.BackgroundImage")));
            this.rbPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbPlus.FlatAppearance.BorderSize = 0;
            this.rbPlus.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.rbPlus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.rbPlus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.rbPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPlus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbPlus.Location = new System.Drawing.Point(70, 37);
            this.rbPlus.Name = "rbPlus";
            this.rbPlus.Size = new System.Drawing.Size(125, 125);
            this.rbPlus.TabIndex = 0;
            this.rbPlus.TabStop = true;
            this.rbPlus.Tag = "Plus";
            this.rbPlus.Text = "+";
            this.rbPlus.UseVisualStyleBackColor = true;
            // 
            // rbMinus
            // 
            this.rbMinus.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbMinus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbMinus.BackgroundImage")));
            this.rbMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbMinus.FlatAppearance.BorderSize = 0;
            this.rbMinus.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.rbMinus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.rbMinus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.rbMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMinus.Location = new System.Drawing.Point(279, 37);
            this.rbMinus.Name = "rbMinus";
            this.rbMinus.Size = new System.Drawing.Size(125, 125);
            this.rbMinus.TabIndex = 1;
            this.rbMinus.TabStop = true;
            this.rbMinus.Tag = "Minus";
            this.rbMinus.Text = "-";
            this.rbMinus.UseVisualStyleBackColor = true;
            // 
            // rbMultiply
            // 
            this.rbMultiply.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbMultiply.BackColor = System.Drawing.Color.Transparent;
            this.rbMultiply.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbMultiply.BackgroundImage")));
            this.rbMultiply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbMultiply.FlatAppearance.BorderSize = 0;
            this.rbMultiply.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.rbMultiply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.rbMultiply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.rbMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMultiply.Location = new System.Drawing.Point(70, 198);
            this.rbMultiply.Name = "rbMultiply";
            this.rbMultiply.Size = new System.Drawing.Size(125, 125);
            this.rbMultiply.TabIndex = 2;
            this.rbMultiply.TabStop = true;
            this.rbMultiply.Tag = "Multiply";
            this.rbMultiply.Text = "x";
            this.rbMultiply.UseVisualStyleBackColor = false;
            // 
            // rbDivide
            // 
            this.rbDivide.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbDivide.BackColor = System.Drawing.Color.Transparent;
            this.rbDivide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbDivide.BackgroundImage")));
            this.rbDivide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbDivide.FlatAppearance.BorderSize = 0;
            this.rbDivide.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.rbDivide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.rbDivide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.rbDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDivide.Location = new System.Drawing.Point(279, 198);
            this.rbDivide.Name = "rbDivide";
            this.rbDivide.Size = new System.Drawing.Size(125, 125);
            this.rbDivide.TabIndex = 3;
            this.rbDivide.TabStop = true;
            this.rbDivide.Tag = "Divide";
            this.rbDivide.Text = ":";
            this.rbDivide.UseVisualStyleBackColor = false;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.BackColor = System.Drawing.Color.Transparent;
            this.lblSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 55F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSum.ForeColor = System.Drawing.Color.Purple;
            this.lblSum.Location = new System.Drawing.Point(148, 167);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(674, 85);
            this.lblSum.TabIndex = 5;
            this.lblSum.Text = "Hier komt een som";
            // 
            // GameCountDown
            // 
            this.GameCountDown.Interval = 1000;
            this.GameCountDown.Tick += new System.EventHandler(this.GameCountDown_Tick);
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.Transparent;
            this.pnlButtons.Controls.Add(this.label6);
            this.pnlButtons.Controls.Add(this.label5);
            this.pnlButtons.Controls.Add(this.label4);
            this.pnlButtons.Controls.Add(this.label3);
            this.pnlButtons.Controls.Add(this.lblIntro);
            this.pnlButtons.Controls.Add(this.rbPlus);
            this.pnlButtons.Controls.Add(this.rbDivide);
            this.pnlButtons.Controls.Add(this.rbMultiply);
            this.pnlButtons.Controls.Add(this.rbMinus);
            this.pnlButtons.ForeColor = System.Drawing.Color.Black;
            this.pnlButtons.Location = new System.Drawing.Point(12, 12);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(446, 387);
            this.pnlButtons.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(211, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 46);
            this.label6.TabIndex = 24;
            this.label6.Text = "D:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 46);
            this.label5.TabIndex = 23;
            this.label5.Text = "C:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(211, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 46);
            this.label4.TabIndex = 22;
            this.label4.Text = "B:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 46);
            this.label3.TabIndex = 21;
            this.label3.Text = "A:";
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.BackColor = System.Drawing.Color.Transparent;
            this.lblIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntro.Location = new System.Drawing.Point(3, 3);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(375, 31);
            this.lblIntro.TabIndex = 20;
            this.lblIntro.Text = "Kies en letter en druk op enter";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Purple;
            this.lblScore.Location = new System.Drawing.Point(155, 3);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(42, 46);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 46);
            this.label1.TabIndex = 15;
            this.label1.Text = "Punten";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Purple;
            this.lblTime.Location = new System.Drawing.Point(592, 3);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(85, 46);
            this.lblTime.TabIndex = 16;
            this.lblTime.Text = "Tijd";
            this.lblTime.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(490, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 46);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tijd:";
            // 
            // pnlGame
            // 
            this.pnlGame.BackColor = System.Drawing.Color.Transparent;
            this.pnlGame.Controls.Add(this.label1);
            this.pnlGame.Controls.Add(this.label2);
            this.pnlGame.Controls.Add(this.lblSum);
            this.pnlGame.Controls.Add(this.lblTime);
            this.pnlGame.Controls.Add(this.lblScore);
            this.pnlGame.Location = new System.Drawing.Point(464, 12);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(833, 387);
            this.pnlGame.TabIndex = 18;
            // 
            // tmrAnswerCheck
            // 
            this.tmrAnswerCheck.Interval = 10;
            this.tmrAnswerCheck.Tick += new System.EventHandler(this.tmrAnswerCheck_Tick);
            // 
            // tmrSumTypeCheck
            // 
            this.tmrSumTypeCheck.Enabled = true;
            this.tmrSumTypeCheck.Interval = 10;
            this.tmrSumTypeCheck.Tick += new System.EventHandler(this.tmrSumTypeCheck_Tick);
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.Transparent;
            this.pnlInfo.Controls.Add(this.lblTotalScore);
            this.pnlInfo.Controls.Add(this.lblSumsWrong);
            this.pnlInfo.Controls.Add(this.lblSumsCorrect);
            this.pnlInfo.Controls.Add(this.lblSumsMade);
            this.pnlInfo.Location = new System.Drawing.Point(12, 405);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(1001, 314);
            this.pnlInfo.TabIndex = 19;
            // 
            // lblSumsWrong
            // 
            this.lblSumsWrong.AutoSize = true;
            this.lblSumsWrong.BackColor = System.Drawing.Color.Transparent;
            this.lblSumsWrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumsWrong.ForeColor = System.Drawing.Color.Purple;
            this.lblSumsWrong.Location = new System.Drawing.Point(6, 134);
            this.lblSumsWrong.Name = "lblSumsWrong";
            this.lblSumsWrong.Size = new System.Drawing.Size(342, 63);
            this.lblSumsWrong.TabIndex = 2;
            this.lblSumsWrong.Text = "Hoeveel fout";
            // 
            // lblSumsCorrect
            // 
            this.lblSumsCorrect.AutoSize = true;
            this.lblSumsCorrect.BackColor = System.Drawing.Color.Transparent;
            this.lblSumsCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumsCorrect.ForeColor = System.Drawing.Color.Purple;
            this.lblSumsCorrect.Location = new System.Drawing.Point(6, 71);
            this.lblSumsCorrect.Name = "lblSumsCorrect";
            this.lblSumsCorrect.Size = new System.Drawing.Size(372, 63);
            this.lblSumsCorrect.TabIndex = 1;
            this.lblSumsCorrect.Text = "Hoeveel goed";
            // 
            // lblSumsMade
            // 
            this.lblSumsMade.AutoSize = true;
            this.lblSumsMade.BackColor = System.Drawing.Color.Transparent;
            this.lblSumsMade.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumsMade.ForeColor = System.Drawing.Color.Purple;
            this.lblSumsMade.Location = new System.Drawing.Point(6, 8);
            this.lblSumsMade.Name = "lblSumsMade";
            this.lblSumsMade.Size = new System.Drawing.Size(462, 63);
            this.lblSumsMade.TabIndex = 0;
            this.lblSumsMade.Text = "Hoeveel gemaakt";
            // 
            // tmrInfo
            // 
            this.tmrInfo.Interval = 10000;
            this.tmrInfo.Tick += new System.EventHandler(this.tmrInfo_Tick);
            // 
            // tmrSetTime
            // 
            this.tmrSetTime.Interval = 10;
            this.tmrSetTime.Tick += new System.EventHandler(this.tmrSetTime_Tick);
            // 
            // pnlSetTime
            // 
            this.pnlSetTime.BackColor = System.Drawing.Color.Transparent;
            this.pnlSetTime.Controls.Add(this.lblSetTime2);
            this.pnlSetTime.Controls.Add(this.lblSetTime);
            this.pnlSetTime.Location = new System.Drawing.Point(1019, 405);
            this.pnlSetTime.Name = "pnlSetTime";
            this.pnlSetTime.Size = new System.Drawing.Size(278, 314);
            this.pnlSetTime.TabIndex = 20;
            // 
            // lblSetTime2
            // 
            this.lblSetTime2.AutoSize = true;
            this.lblSetTime2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetTime2.Location = new System.Drawing.Point(3, 42);
            this.lblSetTime2.Name = "lblSetTime2";
            this.lblSetTime2.Size = new System.Drawing.Size(273, 29);
            this.lblSetTime2.TabIndex = 1;
            this.lblSetTime2.Text = "Vul je tijd in seconden in";
            // 
            // lblSetTime
            // 
            this.lblSetTime.AutoSize = true;
            this.lblSetTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetTime.Location = new System.Drawing.Point(3, 8);
            this.lblSetTime.Name = "lblSetTime";
            this.lblSetTime.Size = new System.Drawing.Size(272, 29);
            this.lblSetTime.TabIndex = 0;
            this.lblSetTime.Text = "Hoelang wil je oefenen?";
            // 
            // lblTotalScore
            // 
            this.lblTotalScore.AutoSize = true;
            this.lblTotalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalScore.ForeColor = System.Drawing.Color.Purple;
            this.lblTotalScore.Location = new System.Drawing.Point(6, 197);
            this.lblTotalScore.Name = "lblTotalScore";
            this.lblTotalScore.Size = new System.Drawing.Size(419, 63);
            this.lblTotalScore.TabIndex = 3;
            this.lblTotalScore.Text = "Hoeveel punten";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1303, 723);
            this.Controls.Add(this.pnlSetTime);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pnlGame);
            this.Controls.Add(this.pnlButtons);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Reken Spel";
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.pnlGame.ResumeLayout(false);
            this.pnlGame.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.pnlSetTime.ResumeLayout(false);
            this.pnlSetTime.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbPlus;
        private System.Windows.Forms.RadioButton rbMinus;
        private System.Windows.Forms.RadioButton rbMultiply;
        private System.Windows.Forms.RadioButton rbDivide;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Timer GameCountDown;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.Timer tmrAnswerCheck;
        private System.Windows.Forms.Timer tmrSumTypeCheck;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblSumsWrong;
        private System.Windows.Forms.Label lblSumsCorrect;
        private System.Windows.Forms.Label lblSumsMade;
        private System.Windows.Forms.Timer tmrInfo;
        private System.Windows.Forms.Timer tmrSetTime;
        private System.Windows.Forms.Panel pnlSetTime;
        private System.Windows.Forms.Label lblSetTime;
        private System.Windows.Forms.Label lblSetTime2;
        private System.Windows.Forms.Label lblTotalScore;
    }
}

