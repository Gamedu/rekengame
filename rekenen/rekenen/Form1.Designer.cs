﻿namespace rekenen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbGroup = new System.Windows.Forms.TextBox();
            this.btnGroup = new System.Windows.Forms.Button();
            this.rbPlus = new System.Windows.Forms.RadioButton();
            this.rbMinus = new System.Windows.Forms.RadioButton();
            this.rbMultiply = new System.Windows.Forms.RadioButton();
            this.rbDivide = new System.Windows.Forms.RadioButton();
            this.btnNewEquation = new System.Windows.Forms.Button();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.lblEquation = new System.Windows.Forms.Label();
            this.tbScore = new System.Windows.Forms.TextBox();
            this.btnExam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbGroup
            // 
            this.tbGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGroup.Location = new System.Drawing.Point(383, 46);
            this.tbGroup.Multiline = true;
            this.tbGroup.Name = "tbGroup";
            this.tbGroup.Size = new System.Drawing.Size(65, 48);
            this.tbGroup.TabIndex = 0;
            // 
            // btnGroup
            // 
            this.btnGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGroup.Location = new System.Drawing.Point(318, 139);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(393, 106);
            this.btnGroup.TabIndex = 1;
            this.btnGroup.Text = "Start";
            this.btnGroup.UseVisualStyleBackColor = true;
            this.btnGroup.Click += new System.EventHandler(this.BtnGroup_Click);
            // 
            // rbPlus
            // 
            this.rbPlus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbPlus.BackgroundImage")));
            this.rbPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPlus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbPlus.Location = new System.Drawing.Point(28, 26);
            this.rbPlus.Name = "rbPlus";
            this.rbPlus.Size = new System.Drawing.Size(80, 80);
            this.rbPlus.TabIndex = 2;
            this.rbPlus.TabStop = true;
            this.rbPlus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbPlus.UseVisualStyleBackColor = true;
            this.rbPlus.Click += new System.EventHandler(this.RbPlus_Click);
            // 
            // rbMinus
            // 
            this.rbMinus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbMinus.BackgroundImage")));
            this.rbMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMinus.Location = new System.Drawing.Point(28, 112);
            this.rbMinus.Name = "rbMinus";
            this.rbMinus.Size = new System.Drawing.Size(80, 80);
            this.rbMinus.TabIndex = 3;
            this.rbMinus.TabStop = true;
            this.rbMinus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbMinus.UseVisualStyleBackColor = true;
            this.rbMinus.Click += new System.EventHandler(this.RbMinus_Click);
            // 
            // rbMultiply
            // 
            this.rbMultiply.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbMultiply.BackgroundImage")));
            this.rbMultiply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMultiply.Location = new System.Drawing.Point(28, 198);
            this.rbMultiply.Name = "rbMultiply";
            this.rbMultiply.Size = new System.Drawing.Size(80, 80);
            this.rbMultiply.TabIndex = 4;
            this.rbMultiply.TabStop = true;
            this.rbMultiply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbMultiply.UseVisualStyleBackColor = true;
            this.rbMultiply.Click += new System.EventHandler(this.RbMultiply_Click);
            // 
            // rbDivide
            // 
            this.rbDivide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbDivide.BackgroundImage")));
            this.rbDivide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDivide.Location = new System.Drawing.Point(28, 284);
            this.rbDivide.Name = "rbDivide";
            this.rbDivide.Size = new System.Drawing.Size(80, 80);
            this.rbDivide.TabIndex = 5;
            this.rbDivide.TabStop = true;
            this.rbDivide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbDivide.UseVisualStyleBackColor = true;
            this.rbDivide.Click += new System.EventHandler(this.RbDivide_Click);
            // 
            // btnNewEquation
            // 
            this.btnNewEquation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewEquation.Location = new System.Drawing.Point(331, 352);
            this.btnNewEquation.Name = "btnNewEquation";
            this.btnNewEquation.Size = new System.Drawing.Size(184, 44);
            this.btnNewEquation.TabIndex = 3;
            this.btnNewEquation.Text = "Controleer";
            this.btnNewEquation.UseVisualStyleBackColor = true;
            this.btnNewEquation.Click += new System.EventHandler(this.BtnNewEquation_Click);
            // 
            // tbAnswer
            // 
            this.tbAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAnswer.Location = new System.Drawing.Point(331, 317);
            this.tbAnswer.Multiline = true;
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(348, 29);
            this.tbAnswer.TabIndex = 2;
            // 
            // lblEquation
            // 
            this.lblEquation.AutoSize = true;
            this.lblEquation.BackColor = System.Drawing.Color.Transparent;
            this.lblEquation.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEquation.Location = new System.Drawing.Point(440, 275);
            this.lblEquation.Name = "lblEquation";
            this.lblEquation.Size = new System.Drawing.Size(140, 39);
            this.lblEquation.TabIndex = 0;
            this.lblEquation.Text = "Welkom";
            // 
            // tbScore
            // 
            this.tbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F);
            this.tbScore.Location = new System.Drawing.Point(408, 456);
            this.tbScore.Multiline = true;
            this.tbScore.Name = "tbScore";
            this.tbScore.Size = new System.Drawing.Size(206, 73);
            this.tbScore.TabIndex = 3;
            // 
            // btnExam
            // 
            this.btnExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExam.Location = new System.Drawing.Point(521, 352);
            this.btnExam.Name = "btnExam";
            this.btnExam.Size = new System.Drawing.Size(158, 44);
            this.btnExam.TabIndex = 6;
            this.btnExam.Text = "Toets";
            this.btnExam.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1011, 541);
            this.Controls.Add(this.rbDivide);
            this.Controls.Add(this.rbMultiply);
            this.Controls.Add(this.rbMinus);
            this.Controls.Add(this.rbPlus);
            this.Controls.Add(this.btnExam);
            this.Controls.Add(this.tbScore);
            this.Controls.Add(this.btnNewEquation);
            this.Controls.Add(this.btnGroup);
            this.Controls.Add(this.tbAnswer);
            this.Controls.Add(this.tbGroup);
            this.Controls.Add(this.lblEquation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbGroup;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.RadioButton rbPlus;
        private System.Windows.Forms.RadioButton rbMinus;
        private System.Windows.Forms.RadioButton rbMultiply;
        private System.Windows.Forms.RadioButton rbDivide;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.Label lblEquation;
        private System.Windows.Forms.TextBox tbScore;
        private System.Windows.Forms.Button btnNewEquation;
        private System.Windows.Forms.Button btnExam;
    }
}

