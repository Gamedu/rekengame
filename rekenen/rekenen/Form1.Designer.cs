namespace rekenen
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
            this.tbGroup = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.rbPlus = new System.Windows.Forms.RadioButton();
            this.rbMinus = new System.Windows.Forms.RadioButton();
            this.rbMultiply = new System.Windows.Forms.RadioButton();
            this.rbDivide = new System.Windows.Forms.RadioButton();
            this.rbTest = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnNewEquation = new System.Windows.Forms.Button();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEquation = new System.Windows.Forms.Label();
            this.tbScore = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbGroup
            // 
            this.tbGroup.Location = new System.Drawing.Point(6, 19);
            this.tbGroup.Name = "tbGroup";
            this.tbGroup.Size = new System.Drawing.Size(100, 20);
            this.tbGroup.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(112, 19);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(125, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Go";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // rbPlus
            // 
            this.rbPlus.AutoSize = true;
            this.rbPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPlus.Location = new System.Drawing.Point(6, 19);
            this.rbPlus.Name = "rbPlus";
            this.rbPlus.Size = new System.Drawing.Size(77, 67);
            this.rbPlus.TabIndex = 2;
            this.rbPlus.TabStop = true;
            this.rbPlus.Text = "+";
            this.rbPlus.UseVisualStyleBackColor = true;
            // 
            // rbMinus
            // 
            this.rbMinus.AutoSize = true;
            this.rbMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMinus.Location = new System.Drawing.Point(20, 92);
            this.rbMinus.Name = "rbMinus";
            this.rbMinus.Size = new System.Drawing.Size(63, 67);
            this.rbMinus.TabIndex = 3;
            this.rbMinus.TabStop = true;
            this.rbMinus.Text = "-";
            this.rbMinus.UseVisualStyleBackColor = true;
            // 
            // rbMultiply
            // 
            this.rbMultiply.AutoSize = true;
            this.rbMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMultiply.Location = new System.Drawing.Point(17, 165);
            this.rbMultiply.Name = "rbMultiply";
            this.rbMultiply.Size = new System.Drawing.Size(66, 67);
            this.rbMultiply.TabIndex = 4;
            this.rbMultiply.TabStop = true;
            this.rbMultiply.Text = "*";
            this.rbMultiply.UseVisualStyleBackColor = true;
            // 
            // rbDivide
            // 
            this.rbDivide.AutoSize = true;
            this.rbDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDivide.Location = new System.Drawing.Point(20, 238);
            this.rbDivide.Name = "rbDivide";
            this.rbDivide.Size = new System.Drawing.Size(60, 67);
            this.rbDivide.TabIndex = 5;
            this.rbDivide.TabStop = true;
            this.rbDivide.Text = "/";
            this.rbDivide.UseVisualStyleBackColor = true;
            // 
            // rbTest
            // 
            this.rbTest.AutoSize = true;
            this.rbTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTest.Location = new System.Drawing.Point(17, 311);
            this.rbTest.Name = "rbTest";
            this.rbTest.Size = new System.Drawing.Size(180, 67);
            this.rbTest.TabIndex = 6;
            this.rbTest.TabStop = true;
            this.rbTest.Text = "Toets";
            this.rbTest.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMinus);
            this.groupBox1.Controls.Add(this.rbPlus);
            this.groupBox1.Controls.Add(this.rbTest);
            this.groupBox1.Controls.Add(this.rbMultiply);
            this.groupBox1.Controls.Add(this.rbDivide);
            this.groupBox1.Location = new System.Drawing.Point(18, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 376);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Instellingen";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbGroup);
            this.groupBox2.Controls.Add(this.btnStart);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 49);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Klas";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnNewEquation);
            this.groupBox3.Controls.Add(this.tbAnswer);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lblEquation);
            this.groupBox3.Location = new System.Drawing.Point(321, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(482, 422);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sommen";
            // 
            // btnNewEquation
            // 
            this.btnNewEquation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewEquation.Location = new System.Drawing.Point(152, 212);
            this.btnNewEquation.Name = "btnNewEquation";
            this.btnNewEquation.Size = new System.Drawing.Size(233, 51);
            this.btnNewEquation.TabIndex = 3;
            this.btnNewEquation.Text = "Start";
            this.btnNewEquation.UseVisualStyleBackColor = true;
            this.btnNewEquation.Click += new System.EventHandler(this.BtnNewEquation_Click);
            // 
            // tbAnswer
            // 
            this.tbAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAnswer.Location = new System.Drawing.Point(152, 159);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(100, 38);
            this.tbAnswer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Antwoord:";
            // 
            // lblEquation
            // 
            this.lblEquation.AutoSize = true;
            this.lblEquation.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquation.Location = new System.Drawing.Point(6, 22);
            this.lblEquation.Name = "lblEquation";
            this.lblEquation.Size = new System.Drawing.Size(140, 39);
            this.lblEquation.TabIndex = 0;
            this.lblEquation.Text = "Welkom";
            // 
            // tbScore
            // 
            this.tbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 65F);
            this.tbScore.Location = new System.Drawing.Point(6, 19);
            this.tbScore.Multiline = true;
            this.tbScore.Name = "tbScore";
            this.tbScore.Size = new System.Drawing.Size(188, 98);
            this.tbScore.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbScore);
            this.groupBox4.Location = new System.Drawing.Point(879, 414);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 123);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Score";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 609);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbGroup;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RadioButton rbPlus;
        private System.Windows.Forms.RadioButton rbMinus;
        private System.Windows.Forms.RadioButton rbMultiply;
        private System.Windows.Forms.RadioButton rbDivide;
        private System.Windows.Forms.RadioButton rbTest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEquation;
        private System.Windows.Forms.TextBox tbScore;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnNewEquation;
    }
}

