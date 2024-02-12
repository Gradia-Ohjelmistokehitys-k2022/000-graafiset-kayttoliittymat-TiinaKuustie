namespace _07_palautus_Array
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
            tbKoko = new TextBox();
            tbNumero = new TextBox();
            tbIndeksi = new TextBox();
            tbHaku = new TextBox();
            btnTaulukko = new Button();
            btnTalleta = new Button();
            btnHae = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lblResult = new Label();
            label8 = new Label();
            lblMuistipaikat = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // tbKoko
            // 
            tbKoko.Location = new Point(356, 88);
            tbKoko.Name = "tbKoko";
            tbKoko.Size = new Size(62, 27);
            tbKoko.TabIndex = 0;
            // 
            // tbNumero
            // 
            tbNumero.Location = new Point(356, 195);
            tbNumero.Name = "tbNumero";
            tbNumero.Size = new Size(125, 27);
            tbNumero.TabIndex = 1;
            // 
            // tbIndeksi
            // 
            tbIndeksi.Location = new Point(356, 228);
            tbIndeksi.Name = "tbIndeksi";
            tbIndeksi.Size = new Size(125, 27);
            tbIndeksi.TabIndex = 2;
            // 
            // tbHaku
            // 
            tbHaku.Location = new Point(356, 339);
            tbHaku.Name = "tbHaku";
            tbHaku.Size = new Size(125, 27);
            tbHaku.TabIndex = 3;
            // 
            // btnTaulukko
            // 
            btnTaulukko.Location = new Point(554, 86);
            btnTaulukko.Name = "btnTaulukko";
            btnTaulukko.Size = new Size(149, 29);
            btnTaulukko.TabIndex = 4;
            btnTaulukko.Text = "Luo Taulukko";
            btnTaulukko.UseVisualStyleBackColor = true;
            btnTaulukko.Click += btnTaulukko_Click;
            // 
            // btnTalleta
            // 
            btnTalleta.Location = new Point(554, 228);
            btnTalleta.Name = "btnTalleta";
            btnTalleta.Size = new Size(149, 29);
            btnTalleta.TabIndex = 5;
            btnTalleta.Text = "Talleta";
            btnTalleta.UseVisualStyleBackColor = true;
            btnTalleta.Click += btnTalleta_Click;
            // 
            // btnHae
            // 
            btnHae.Location = new Point(554, 337);
            btnHae.Name = "btnHae";
            btnHae.Size = new Size(149, 29);
            btnHae.TabIndex = 6;
            btnHae.Text = "Hae";
            btnHae.UseVisualStyleBackColor = true;
            btnHae.Click += btnHae_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(169, 95);
            label1.Name = "label1";
            label1.Size = new Size(162, 20);
            label1.TabIndex = 7;
            label1.Text = "Muistipaikkojen määrä:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(169, 202);
            label2.Name = "label2";
            label2.Size = new Size(154, 20);
            label2.TabIndex = 8;
            label2.Text = "Tallennettava numero:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(169, 235);
            label3.Name = "label3";
            label3.Size = new Size(166, 20);
            label3.TabIndex = 9;
            label3.Text = "Tallennuspaikan indeksi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(169, 346);
            label4.Name = "label4";
            label4.Size = new Size(166, 20);
            label4.TabIndex = 10;
            label4.Text = "Tallennuspaikan indeksi:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.Location = new Point(335, 27);
            label5.Name = "label5";
            label5.Size = new Size(185, 28);
            label5.TabIndex = 11;
            label5.Text = "TAULUKON LUONTI";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label6.Location = new Point(335, 141);
            label6.Name = "label6";
            label6.Size = new Size(117, 28);
            label6.TabIndex = 12;
            label6.Text = "TALLENNUS";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label7.Location = new Point(335, 275);
            label7.Name = "label7";
            label7.Size = new Size(65, 28);
            label7.TabIndex = 13;
            label7.Text = "HAKU";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(356, 400);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(23, 28);
            lblResult.TabIndex = 14;
            lblResult.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(525, 149);
            label8.Name = "label8";
            label8.Size = new Size(162, 20);
            label8.TabIndex = 15;
            label8.Text = "Vapaita muistipaikkoja:";
            // 
            // lblMuistipaikat
            // 
            lblMuistipaikat.AutoSize = true;
            lblMuistipaikat.Location = new Point(703, 148);
            lblMuistipaikat.Name = "lblMuistipaikat";
            lblMuistipaikat.Size = new Size(17, 20);
            lblMuistipaikat.TabIndex = 16;
            lblMuistipaikat.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(169, 408);
            label9.Name = "label9";
            label9.Size = new Size(167, 20);
            label9.TabIndex = 17;
            label9.Text = "Tallennuspaikasta löytyi:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label9);
            Controls.Add(lblMuistipaikat);
            Controls.Add(label8);
            Controls.Add(lblResult);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnHae);
            Controls.Add(btnTalleta);
            Controls.Add(btnTaulukko);
            Controls.Add(tbHaku);
            Controls.Add(tbIndeksi);
            Controls.Add(tbNumero);
            Controls.Add(tbKoko);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbKoko;
        private TextBox tbNumero;
        private TextBox tbIndeksi;
        private TextBox tbHaku;
        private Button btnTaulukko;
        private Button btnTalleta;
        private Button btnHae;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lblResult;
        private Label label8;
        private Label lblMuistipaikat;
        private Label label9;
    }
}
