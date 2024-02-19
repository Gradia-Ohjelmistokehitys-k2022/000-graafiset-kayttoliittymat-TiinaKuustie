namespace _18_palautus_DelegatesandEvents
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
            tbNimi = new TextBox();
            dtpPVM = new DateTimePicker();
            label1 = new Label();
            tbHylly = new TextBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            lblKoodi = new Label();
            rtbInfo = new RichTextBox();
            btnTallenna = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // tbNimi
            // 
            tbNimi.Location = new Point(126, 104);
            tbNimi.Name = "tbNimi";
            tbNimi.Size = new Size(125, 27);
            tbNimi.TabIndex = 0;
            // 
            // dtpPVM
            // 
            dtpPVM.Location = new Point(445, 104);
            dtpPVM.Name = "dtpPVM";
            dtpPVM.Size = new Size(250, 27);
            dtpPVM.TabIndex = 1;
            dtpPVM.ValueChanged += dtpPVM_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 81);
            label1.Name = "label1";
            label1.Size = new Size(147, 20);
            label1.TabIndex = 0;
            label1.Text = "Syötä asiakkaan nimi";
            label1.Click += label1_Click;
            // 
            // tbHylly
            // 
            tbHylly.Location = new Point(285, 104);
            tbHylly.Name = "tbHylly";
            tbHylly.Size = new Size(125, 27);
            tbHylly.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(285, 81);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 4;
            label2.Text = "Syötä hyllypaikka";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(445, 81);
            label3.Name = "label3";
            label3.Size = new Size(154, 20);
            label3.TabIndex = 5;
            label3.Text = "Viimeinen noutopäivä";
            // 
            // button1
            // 
            button1.Location = new Point(126, 167);
            button1.Name = "button1";
            button1.Size = new Size(125, 29);
            button1.TabIndex = 6;
            button1.Text = "Lue viivakoodi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblKoodi
            // 
            lblKoodi.AutoSize = true;
            lblKoodi.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKoodi.Location = new Point(316, 171);
            lblKoodi.Name = "lblKoodi";
            lblKoodi.Size = new Size(92, 25);
            lblKoodi.TabIndex = 0;
            lblKoodi.Text = "12345678";
            // 
            // rtbInfo
            // 
            rtbInfo.Location = new Point(447, 181);
            rtbInfo.Name = "rtbInfo";
            rtbInfo.Size = new Size(248, 190);
            rtbInfo.TabIndex = 7;
            rtbInfo.Text = "";
            // 
            // btnTallenna
            // 
            btnTallenna.Location = new Point(285, 287);
            btnTallenna.Name = "btnTallenna";
            btnTallenna.Size = new Size(125, 29);
            btnTallenna.TabIndex = 8;
            btnTallenna.Text = "Tallenna noudettava tilaus";
            btnTallenna.UseVisualStyleBackColor = true;
            btnTallenna.Click += btnTallenna_Click;
            // 
            // timer1
            // 
            timer1.Tick += AIKAILMOITUS;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTallenna);
            Controls.Add(rtbInfo);
            Controls.Add(lblKoodi);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbHylly);
            Controls.Add(label1);
            Controls.Add(dtpPVM);
            Controls.Add(tbNimi);
            Name = "Form1";
            Text = "Tiinan TuoteTilaus";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNimi;
        private DateTimePicker dtpPVM;
        private Label label1;
        private TextBox tbHylly;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label lblKoodi;
        private RichTextBox rtbInfo;
        private Button btnTallenna;
        private System.Windows.Forms.Timer timer1;
    }
}
