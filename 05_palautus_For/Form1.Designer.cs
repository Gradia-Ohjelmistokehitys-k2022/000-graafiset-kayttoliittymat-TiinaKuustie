namespace _05_palautus_For
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
            button1 = new Button();
            tbSyote = new TextBox();
            lblLuvut = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(251, 69);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "START";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbSyote
            // 
            tbSyote.Location = new Point(74, 69);
            tbSyote.Name = "tbSyote";
            tbSyote.Size = new Size(125, 27);
            tbSyote.TabIndex = 2;
            tbSyote.TextChanged += tbSyote_TextChanged;
            // 
            // lblLuvut
            // 
            lblLuvut.AutoSize = true;
            lblLuvut.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLuvut.Location = new Point(174, 157);
            lblLuvut.Name = "lblLuvut";
            lblLuvut.Size = new Size(385, 159);
            lblLuvut.TabIndex = 3;
            lblLuvut.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblLuvut);
            Controls.Add(tbSyote);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox tbSyote;
        private Label lblLuvut;
    }
}
