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
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tmrControle = new System.Windows.Forms.Timer(this.components);
            this.pnlGame = new System.Windows.Forms.Panel();
            this.btnGo = new System.Windows.Forms.Button();
            this.lblIntro = new System.Windows.Forms.Label();
            this.pnlButtons.SuspendLayout();
            this.pnlGame.SuspendLayout();
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
            this.rbPlus.Location = new System.Drawing.Point(6, 36);
            this.rbPlus.Name = "rbPlus";
            this.rbPlus.Size = new System.Drawing.Size(75, 75);
            this.rbPlus.TabIndex = 0;
            this.rbPlus.TabStop = true;
            this.rbPlus.Tag = "Plus";
            this.rbPlus.Text = "+";
            this.rbPlus.UseVisualStyleBackColor = true;
            this.rbPlus.Click += new System.EventHandler(this.RadioBtn_Click);
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
            this.rbMinus.Location = new System.Drawing.Point(5, 117);
            this.rbMinus.Name = "rbMinus";
            this.rbMinus.Size = new System.Drawing.Size(75, 75);
            this.rbMinus.TabIndex = 1;
            this.rbMinus.TabStop = true;
            this.rbMinus.Tag = "Minus";
            this.rbMinus.Text = "-";
            this.rbMinus.UseVisualStyleBackColor = true;
            this.rbMinus.Click += new System.EventHandler(this.RadioBtn_Click);
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
            this.rbMultiply.Location = new System.Drawing.Point(86, 36);
            this.rbMultiply.Name = "rbMultiply";
            this.rbMultiply.Size = new System.Drawing.Size(75, 75);
            this.rbMultiply.TabIndex = 2;
            this.rbMultiply.TabStop = true;
            this.rbMultiply.Tag = "Multiply";
            this.rbMultiply.Text = "x";
            this.rbMultiply.UseVisualStyleBackColor = false;
            this.rbMultiply.Click += new System.EventHandler(this.RadioBtn_Click);
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
            this.rbDivide.Location = new System.Drawing.Point(86, 117);
            this.rbDivide.Name = "rbDivide";
            this.rbDivide.Size = new System.Drawing.Size(75, 75);
            this.rbDivide.TabIndex = 3;
            this.rbDivide.TabStop = true;
            this.rbDivide.Tag = "Divide";
            this.rbDivide.Text = ":";
            this.rbDivide.UseVisualStyleBackColor = false;
            this.rbDivide.Click += new System.EventHandler(this.RadioBtn_Click);
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.BackColor = System.Drawing.Color.Transparent;
            this.lblSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSum.Location = new System.Drawing.Point(8, 3);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(257, 31);
            this.lblSum.TabIndex = 5;
            this.lblSum.Text = "Hier komt een som";
            // 
            // GameCountDown
            // 
            this.GameCountDown.Interval = 1000;
            this.GameCountDown.Tick += new System.EventHandler(this.GameCountDown_Tick);
            // 
            // tbAnswer
            // 
            this.tbAnswer.Location = new System.Drawing.Point(3, 37);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(104, 20);
            this.tbAnswer.TabIndex = 9;
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.Transparent;
            this.pnlButtons.Controls.Add(this.lblIntro);
            this.pnlButtons.Controls.Add(this.rbPlus);
            this.pnlButtons.Controls.Add(this.btnGo);
            this.pnlButtons.Controls.Add(this.rbDivide);
            this.pnlButtons.Controls.Add(this.rbMultiply);
            this.pnlButtons.Controls.Add(this.rbMinus);
            this.pnlButtons.ForeColor = System.Drawing.Color.Black;
            this.pnlButtons.Location = new System.Drawing.Point(8, 12);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(434, 250);
            this.pnlButtons.TabIndex = 10;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Purple;
            this.lblScore.Location = new System.Drawing.Point(207, 89);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(57, 63);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "0";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(113, 37);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(163, 49);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnAnswer
            // 
            this.btnAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer.Location = new System.Drawing.Point(3, 63);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(104, 23);
            this.btnAnswer.TabIndex = 14;
            this.btnAnswer.Text = "Antwoord";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.BtnAnswer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(3, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 63);
            this.label1.TabIndex = 15;
            this.label1.Text = "Punten";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Purple;
            this.lblTime.Location = new System.Drawing.Point(140, 152);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(87, 63);
            this.lblTime.TabIndex = 16;
            this.lblTime.Text = "10";
            this.lblTime.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(3, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 63);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tijd:";
            // 
            // tmrControle
            // 
            this.tmrControle.Enabled = true;
            this.tmrControle.Interval = 10;
            this.tmrControle.Tick += new System.EventHandler(this.TmrControle_Tick_1);
            // 
            // pnlGame
            // 
            this.pnlGame.BackColor = System.Drawing.Color.Transparent;
            this.pnlGame.Controls.Add(this.label1);
            this.pnlGame.Controls.Add(this.label2);
            this.pnlGame.Controls.Add(this.lblSum);
            this.pnlGame.Controls.Add(this.lblTime);
            this.pnlGame.Controls.Add(this.tbAnswer);
            this.pnlGame.Controls.Add(this.lblScore);
            this.pnlGame.Controls.Add(this.btnAnswer);
            this.pnlGame.Controls.Add(this.btnStart);
            this.pnlGame.Location = new System.Drawing.Point(448, 12);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(279, 220);
            this.pnlGame.TabIndex = 18;
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(5, 205);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(156, 40);
            this.btnGo.TabIndex = 19;
            this.btnGo.Text = "Start";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.BackColor = System.Drawing.Color.Transparent;
            this.lblIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntro.Location = new System.Drawing.Point(3, 3);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(435, 31);
            this.lblIntro.TabIndex = 20;
            this.lblIntro.Text = "Selecteer een som en klik op \'Start\'";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.pnlGame);
            this.Controls.Add(this.pnlButtons);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.pnlGame.ResumeLayout(false);
            this.pnlGame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbPlus;
        private System.Windows.Forms.RadioButton rbMinus;
        private System.Windows.Forms.RadioButton rbMultiply;
        private System.Windows.Forms.RadioButton rbDivide;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Timer GameCountDown;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer tmrControle;
        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lblIntro;
    }
}

