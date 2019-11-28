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
            this.RBGroup = new System.Windows.Forms.GroupBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.GameCountDown = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.RBGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbPlus
            // 
            this.rbPlus.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbPlus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbPlus.BackgroundImage")));
            this.rbPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbPlus.FlatAppearance.BorderSize = 0;
            this.rbPlus.Location = new System.Drawing.Point(6, 19);
            this.rbPlus.Name = "rbPlus";
            this.rbPlus.Size = new System.Drawing.Size(75, 75);
            this.rbPlus.TabIndex = 0;
            this.rbPlus.TabStop = true;
            this.rbPlus.Tag = "Plus";
            this.rbPlus.UseVisualStyleBackColor = true;
            this.rbPlus.Click += new System.EventHandler(this.RadioBtn_Click);
            // 
            // rbMinus
            // 
            this.rbMinus.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbMinus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbMinus.BackgroundImage")));
            this.rbMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbMinus.FlatAppearance.BorderSize = 0;
            this.rbMinus.Location = new System.Drawing.Point(6, 100);
            this.rbMinus.Name = "rbMinus";
            this.rbMinus.Size = new System.Drawing.Size(75, 75);
            this.rbMinus.TabIndex = 1;
            this.rbMinus.TabStop = true;
            this.rbMinus.Tag = "Minus";
            this.rbMinus.UseVisualStyleBackColor = true;
            this.rbMinus.Click += new System.EventHandler(this.RadioBtn_Click);
            // 
            // rbMultiply
            // 
            this.rbMultiply.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbMultiply.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbMultiply.BackgroundImage")));
            this.rbMultiply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbMultiply.FlatAppearance.BorderSize = 0;
            this.rbMultiply.Location = new System.Drawing.Point(6, 181);
            this.rbMultiply.Name = "rbMultiply";
            this.rbMultiply.Size = new System.Drawing.Size(75, 75);
            this.rbMultiply.TabIndex = 2;
            this.rbMultiply.TabStop = true;
            this.rbMultiply.Tag = "Multiply";
            this.rbMultiply.UseVisualStyleBackColor = true;
            this.rbMultiply.Click += new System.EventHandler(this.RadioBtn_Click);
            // 
            // rbDivide
            // 
            this.rbDivide.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbDivide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbDivide.BackgroundImage")));
            this.rbDivide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbDivide.FlatAppearance.BorderSize = 0;
            this.rbDivide.Location = new System.Drawing.Point(6, 262);
            this.rbDivide.Name = "rbDivide";
            this.rbDivide.Size = new System.Drawing.Size(75, 75);
            this.rbDivide.TabIndex = 3;
            this.rbDivide.TabStop = true;
            this.rbDivide.Tag = "Divide";
            this.rbDivide.UseVisualStyleBackColor = true;
            this.rbDivide.Click += new System.EventHandler(this.RadioBtn_Click);
            // 
            // RBGroup
            // 
            this.RBGroup.Controls.Add(this.rbPlus);
            this.RBGroup.Controls.Add(this.rbDivide);
            this.RBGroup.Controls.Add(this.rbMinus);
            this.RBGroup.Controls.Add(this.rbMultiply);
            this.RBGroup.Location = new System.Drawing.Point(12, 31);
            this.RBGroup.Name = "RBGroup";
            this.RBGroup.Size = new System.Drawing.Size(91, 341);
            this.RBGroup.TabIndex = 4;
            this.RBGroup.TabStop = false;
            this.RBGroup.Text = "groupBox1";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(364, 121);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(35, 13);
            this.lblSum.TabIndex = 5;
            this.lblSum.Text = "label1";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(664, 372);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(35, 13);
            this.lblScore.TabIndex = 8;
            this.lblScore.Text = "label2";
            // 
            // tbAnswer
            // 
            this.tbAnswer.Location = new System.Drawing.Point(337, 159);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(100, 20);
            this.tbAnswer.TabIndex = 9;
            this.tbAnswer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TbAnswer_KeyUp_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbAnswer);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.RBGroup);
            this.Name = "Form1";
            this.Text = "Form1";
            this.RBGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbPlus;
        private System.Windows.Forms.RadioButton rbMinus;
        private System.Windows.Forms.RadioButton rbMultiply;
        private System.Windows.Forms.RadioButton rbDivide;
        private System.Windows.Forms.GroupBox RBGroup;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer GameCountDown;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox tbAnswer;
    }
}

