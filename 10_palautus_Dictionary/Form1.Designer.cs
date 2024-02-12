namespace _10_palautus_Dictionary
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
            btnNew = new Button();
            btnAdd = new Button();
            btnHae = new Button();
            tbAddKey = new TextBox();
            tbAddValue = new TextBox();
            tbHaeKey = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblHakutulos = new Label();
            label2 = new Label();
            label7 = new Label();
            lblLuotu = new Label();
            SuspendLayout();
            // 
            // btnNew
            // 
            btnNew.Location = new Point(338, 94);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 29);
            btnNew.TabIndex = 0;
            btnNew.Text = "Luo uusi";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(604, 232);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Lisää";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnHae
            // 
            btnHae.Location = new Point(604, 322);
            btnHae.Name = "btnHae";
            btnHae.Size = new Size(94, 29);
            btnHae.TabIndex = 2;
            btnHae.Text = "Hae";
            btnHae.UseVisualStyleBackColor = true;
            btnHae.Click += btnHae_Click;
            // 
            // tbAddKey
            // 
            tbAddKey.Location = new Point(321, 186);
            tbAddKey.Name = "tbAddKey";
            tbAddKey.Size = new Size(125, 27);
            tbAddKey.TabIndex = 3;
            // 
            // tbAddValue
            // 
            tbAddValue.Location = new Point(321, 234);
            tbAddValue.Name = "tbAddValue";
            tbAddValue.Size = new Size(125, 27);
            tbAddValue.TabIndex = 4;
            // 
            // tbHaeKey
            // 
            tbHaeKey.Location = new Point(321, 324);
            tbHaeKey.Name = "tbHaeKey";
            tbHaeKey.Size = new Size(125, 27);
            tbHaeKey.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(295, 50);
            label1.Name = "label1";
            label1.Size = new Size(182, 28);
            label1.TabIndex = 7;
            label1.Text = "Luodaan Dictionary";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(212, 193);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 9;
            label3.Text = "Avain (int):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(212, 241);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 10;
            label4.Text = "Sisältö (str):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(185, 331);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 11;
            label5.Text = "Hae avaimella:";
            // 
            // lblHakutulos
            // 
            lblHakutulos.AutoSize = true;
            lblHakutulos.Location = new Point(321, 379);
            lblHakutulos.Name = "lblHakutulos";
            lblHakutulos.Size = new Size(78, 20);
            lblHakutulos.TabIndex = 12;
            lblHakutulos.Text = "Hakutulos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(297, 142);
            label2.Name = "label2";
            label2.Size = new Size(189, 28);
            label2.TabIndex = 13;
            label2.Text = "Lisätään elementtejä";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label7.Location = new Point(295, 277);
            label7.Name = "label7";
            label7.Size = new Size(191, 28);
            label7.TabIndex = 14;
            label7.Text = "Haetaan elementtejä";
            // 
            // lblLuotu
            // 
            lblLuotu.AutoSize = true;
            lblLuotu.Location = new Point(553, 103);
            lblLuotu.Name = "lblLuotu";
            lblLuotu.Size = new Size(101, 20);
            lblLuotu.TabIndex = 15;
            lblLuotu.Text = "Ei Dictionaryä";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblLuotu);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(lblHakutulos);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(tbHaeKey);
            Controls.Add(tbAddValue);
            Controls.Add(tbAddKey);
            Controls.Add(btnHae);
            Controls.Add(btnAdd);
            Controls.Add(btnNew);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNew;
        private Button btnAdd;
        private Button button3;
        private TextBox tbAddKey;
        private TextBox tbAddValue;
        private TextBox tbHaeKey;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblHakutulos;
        private Label label2;
        private Label label7;
        private Button btnHae;
        private Label lblLuotu;
    }
}
