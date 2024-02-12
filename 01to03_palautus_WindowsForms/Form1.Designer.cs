namespace _01WindowsForms
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
            groupBox1 = new GroupBox();
            button5 = new Button();
            button4 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            tbKesto = new TextBox();
            tbVuosi = new TextBox();
            tbNimi = new TextBox();
            tbID = new TextBox();
            groupBox2 = new GroupBox();
            rtbArvio = new RichTextBox();
            label6 = new Label();
            nudSecond = new NumericUpDown();
            nudFirst = new NumericUpDown();
            label2 = new Label();
            groupBox3 = new GroupBox();
            btnPoista = new Button();
            btnTallenna = new Button();
            btnUusi = new Button();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            poistuToolStripMenuItem = new ToolStripMenuItem();
            tietojaToolStripMenuItem = new ToolStripMenuItem();
            testaaTietokantayhteyttäToolStripMenuItem = new ToolStripMenuItem();
            infoToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSecond).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFirst).BeginInit();
            groupBox3.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbKesto);
            groupBox1.Controls.Add(tbVuosi);
            groupBox1.Controls.Add(tbNimi);
            groupBox1.Controls.Add(tbID);
            groupBox1.Location = new Point(37, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(366, 277);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Elokuvan tiedot";
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ControlLight;
            button5.Location = new Point(213, 220);
            button5.Name = "button5";
            button5.Size = new Size(104, 43);
            button5.TabIndex = 10;
            button5.Text = "Seuraava";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlLight;
            button4.Location = new Point(38, 220);
            button4.Name = "button4";
            button4.Size = new Size(104, 43);
            button4.TabIndex = 9;
            button4.Text = "Edellinen";
            button4.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 186);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 8;
            label5.Text = "Kesto (min):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 142);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 7;
            label4.Text = "Julkaisuvuosi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 98);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 6;
            label3.Text = "Nimi:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 55);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 4;
            label1.Text = "ID:";
            // 
            // tbKesto
            // 
            tbKesto.Location = new Point(147, 179);
            tbKesto.Name = "tbKesto";
            tbKesto.Size = new Size(125, 27);
            tbKesto.TabIndex = 3;
            tbKesto.MouseClick += tbKesto_MouseClick;
            tbKesto.MouseLeave += tbKesto_MouseLeave;
            // 
            // tbVuosi
            // 
            tbVuosi.Location = new Point(147, 135);
            tbVuosi.Name = "tbVuosi";
            tbVuosi.Size = new Size(125, 27);
            tbVuosi.TabIndex = 2;
            // 
            // tbNimi
            // 
            tbNimi.Location = new Point(147, 95);
            tbNimi.Name = "tbNimi";
            tbNimi.Size = new Size(196, 27);
            tbNimi.TabIndex = 1;
            tbNimi.MouseClick += tbNimi_MouseClick;
            tbNimi.MouseLeave += tbNimi_MouseLeave;
            // 
            // tbID
            // 
            tbID.Location = new Point(147, 48);
            tbID.Name = "tbID";
            tbID.ReadOnly = true;
            tbID.Size = new Size(125, 27);
            tbID.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rtbArvio);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(nudSecond);
            groupBox2.Controls.Add(nudFirst);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(37, 316);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(366, 252);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Arvio";
            // 
            // rtbArvio
            // 
            rtbArvio.Location = new Point(36, 36);
            rtbArvio.Name = "rtbArvio";
            rtbArvio.Size = new Size(305, 144);
            rtbArvio.TabIndex = 16;
            rtbArvio.Text = "";
            rtbArvio.MouseClick += rtbArvio_MouseClick;
            rtbArvio.MouseLeave += rtbArvio_MouseLeave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(195, 218);
            label6.Name = "label6";
            label6.Size = new Size(12, 20);
            label6.TabIndex = 15;
            label6.Text = ".";
            // 
            // nudSecond
            // 
            nudSecond.Increment = new decimal(new int[] { 50, 0, 0, 0 });
            nudSecond.Location = new Point(213, 211);
            nudSecond.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            nudSecond.Name = "nudSecond";
            nudSecond.Size = new Size(52, 27);
            nudSecond.TabIndex = 14;
            nudSecond.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // nudFirst
            // 
            nudFirst.Location = new Point(134, 211);
            nudFirst.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudFirst.Name = "nudFirst";
            nudFirst.Size = new Size(52, 27);
            nudFirst.TabIndex = 13;
            nudFirst.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 218);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 11;
            label2.Text = "Arvosana:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnPoista);
            groupBox3.Controls.Add(btnTallenna);
            groupBox3.Controls.Add(btnUusi);
            groupBox3.Location = new Point(422, 33);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(366, 535);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Toiminnallisuus";
            // 
            // btnPoista
            // 
            btnPoista.BackColor = Color.Firebrick;
            btnPoista.FlatAppearance.BorderColor = Color.Gray;
            btnPoista.FlatStyle = FlatStyle.Flat;
            btnPoista.ForeColor = SystemColors.ButtonFace;
            btnPoista.Location = new Point(46, 220);
            btnPoista.Name = "btnPoista";
            btnPoista.Size = new Size(270, 57);
            btnPoista.TabIndex = 2;
            btnPoista.Text = "Poista";
            btnPoista.UseVisualStyleBackColor = false;
            // 
            // btnTallenna
            // 
            btnTallenna.BackColor = Color.MediumSeaGreen;
            btnTallenna.FlatAppearance.BorderColor = Color.Gray;
            btnTallenna.FlatStyle = FlatStyle.Flat;
            btnTallenna.Location = new Point(46, 135);
            btnTallenna.Name = "btnTallenna";
            btnTallenna.Size = new Size(270, 57);
            btnTallenna.TabIndex = 1;
            btnTallenna.Text = "Tallenna";
            btnTallenna.UseVisualStyleBackColor = false;
            btnTallenna.Click += btnTallenna_Click;
            // 
            // btnUusi
            // 
            btnUusi.BackColor = SystemColors.ControlLight;
            btnUusi.FlatAppearance.BorderColor = Color.Gray;
            btnUusi.FlatStyle = FlatStyle.Flat;
            btnUusi.Location = new Point(46, 48);
            btnUusi.Name = "btnUusi";
            btnUusi.Size = new Size(270, 57);
            btnUusi.TabIndex = 0;
            btnUusi.Text = "Uusi tietue";
            btnUusi.UseVisualStyleBackColor = false;
            btnUusi.Click += btnUusi_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, tietojaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { poistuToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(81, 24);
            toolStripMenuItem1.Text = "Tiedosto";
            // 
            // poistuToolStripMenuItem
            // 
            poistuToolStripMenuItem.Name = "poistuToolStripMenuItem";
            poistuToolStripMenuItem.Size = new Size(131, 26);
            poistuToolStripMenuItem.Text = "Poistu";
            poistuToolStripMenuItem.Click += poistuToolStripMenuItem_Click;
            // 
            // tietojaToolStripMenuItem
            // 
            tietojaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { testaaTietokantayhteyttäToolStripMenuItem, infoToolStripMenuItem });
            tietojaToolStripMenuItem.Name = "tietojaToolStripMenuItem";
            tietojaToolStripMenuItem.Size = new Size(69, 24);
            tietojaToolStripMenuItem.Text = "Tietoja";
            // 
            // testaaTietokantayhteyttäToolStripMenuItem
            // 
            testaaTietokantayhteyttäToolStripMenuItem.Name = "testaaTietokantayhteyttäToolStripMenuItem";
            testaaTietokantayhteyttäToolStripMenuItem.Size = new Size(258, 26);
            testaaTietokantayhteyttäToolStripMenuItem.Text = "Testaa tietokantayhteyttä";
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(258, 26);
            infoToolStripMenuItem.Text = "Info";
            infoToolStripMenuItem.Click += infoToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 580);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Elokuvasovellus";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSecond).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFirst).EndInit();
            groupBox3.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox tbKesto;
        private TextBox tbVuosi;
        private TextBox tbNimi;
        private TextBox tbID;
        private Button btnPoista;
        private Button btnTallenna;
        private Button btnUusi;
        private Button button5;
        private Button button4;
        private Label label6;
        private NumericUpDown nudSecond;
        private NumericUpDown nudFirst;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem tietojaToolStripMenuItem;
        private ToolStripMenuItem poistuToolStripMenuItem;
        private ToolStripMenuItem testaaTietokantayhteyttäToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem;
        private RichTextBox rtbArvio;
    }
}
