namespace _08_palautus_ArrayLotto
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
            btnArvo = new Button();
            lblLottorivi = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label2 = new Label();
            btnTarkista = new Button();
            lblTulokset = new Label();
            lblLisa = new Label();
            SuspendLayout();
            // 
            // btnArvo
            // 
            btnArvo.Location = new Point(469, 115);
            btnArvo.Name = "btnArvo";
            btnArvo.Size = new Size(94, 29);
            btnArvo.TabIndex = 1;
            btnArvo.Text = "Arvo";
            btnArvo.UseVisualStyleBackColor = true;
            btnArvo.Click += btnArvo_Click;
            // 
            // lblLottorivi
            // 
            lblLottorivi.AutoSize = true;
            lblLottorivi.Location = new Point(239, 118);
            lblLottorivi.Name = "lblLottorivi";
            lblLottorivi.Size = new Size(64, 20);
            lblLottorivi.TabIndex = 0;
            lblLottorivi.Text = "Lottorivi";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(210, 273);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(42, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(261, 273);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(42, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(309, 273);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(42, 27);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(357, 273);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(42, 27);
            textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(405, 273);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(42, 27);
            textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.White;
            textBox6.Location = new Point(453, 273);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(42, 27);
            textBox6.TabIndex = 7;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(501, 273);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(42, 27);
            textBox7.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 280);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 0;
            label2.Text = "Oma rivi:";
            // 
            // btnTarkista
            // 
            btnTarkista.Location = new Point(574, 271);
            btnTarkista.Name = "btnTarkista";
            btnTarkista.Size = new Size(94, 29);
            btnTarkista.TabIndex = 9;
            btnTarkista.Text = "Tarkista";
            btnTarkista.UseVisualStyleBackColor = true;
            btnTarkista.Click += btnTarkista_Click;
            // 
            // lblTulokset
            // 
            lblTulokset.AutoSize = true;
            lblTulokset.Location = new Point(246, 226);
            lblTulokset.Name = "lblTulokset";
            lblTulokset.Size = new Size(64, 20);
            lblTulokset.TabIndex = 10;
            lblTulokset.Text = "Tulokset";
            // 
            // lblLisa
            // 
            lblLisa.AutoSize = true;
            lblLisa.Location = new Point(239, 155);
            lblLisa.Name = "lblLisa";
            lblLisa.Size = new Size(90, 20);
            lblLisa.TabIndex = 11;
            lblLisa.Text = "Lisänumerot";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblLisa);
            Controls.Add(lblTulokset);
            Controls.Add(btnTarkista);
            Controls.Add(label2);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblLottorivi);
            Controls.Add(btnArvo);
            Name = "Form1";
            Text = "Lottorivigeneraattori";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnArvo;
        private Label label1;
        private Label lblLottorivi;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label2;
        private Button btnTarkista;
        private Label lblTulokset;
        private Label lblLisa;
    }
}
