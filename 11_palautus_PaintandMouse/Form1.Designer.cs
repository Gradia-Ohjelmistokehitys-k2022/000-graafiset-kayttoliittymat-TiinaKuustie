﻿namespace _11_palautus_PaintandMouse
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnPaint = new Button();
            tbX = new TextBox();
            tbY = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnPaint
            // 
            btnPaint.Location = new Point(678, 151);
            btnPaint.Name = "btnPaint";
            btnPaint.Size = new Size(110, 29);
            btnPaint.TabIndex = 0;
            btnPaint.Text = "Siirrä";
            btnPaint.UseVisualStyleBackColor = true;
            btnPaint.Click += btnPaint_Click;
            // 
            // tbX
            // 
            tbX.Location = new Point(678, 105);
            tbX.Name = "tbX";
            tbX.Size = new Size(39, 27);
            tbX.TabIndex = 1;
            tbX.Text = "X";
            // 
            // tbY
            // 
            tbY.Location = new Point(749, 105);
            tbY.Name = "tbY";
            tbY.Size = new Size(39, 27);
            tbY.TabIndex = 2;
            tbY.Text = "Y";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(651, 112);
            label1.Name = "label1";
            label1.Size = new Size(21, 20);
            label1.TabIndex = 3;
            label1.Text = "X:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(723, 112);
            label2.Name = "label2";
            label2.Size = new Size(20, 20);
            label2.TabIndex = 4;
            label2.Text = "Y:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbY);
            Controls.Add(tbX);
            Controls.Add(btnPaint);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Paint += MainForm_Paint;
            MouseDown += MainForm_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPaint;
        private TextBox textBox1;
        private TextBox textBox2;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox tbX;
        private TextBox tbY;
        private Label label1;
        private Label label2;
    }
}
