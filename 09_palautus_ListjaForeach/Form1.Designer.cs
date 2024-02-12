namespace _09_palautus_ListjaForeach
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
            btnCreate = new Button();
            btnAdd = new Button();
            btnSearch = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbSanat = new TextBox();
            cbHae = new ComboBox();
            lblLista = new Label();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(279, 77);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Luo lista";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(565, 210);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Lisää";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(565, 354);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Hae";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(279, 9);
            label1.Name = "label1";
            label1.Size = new Size(157, 28);
            label1.TabIndex = 3;
            label1.Text = "LUODAAN LISTA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(279, 143);
            label2.Name = "label2";
            label2.Size = new Size(247, 28);
            label2.TabIndex = 4;
            label2.Text = "Lisätään listaan merkkijono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(279, 290);
            label3.Name = "label3";
            label3.Size = new Size(218, 28);
            label3.TabIndex = 5;
            label3.Text = "Haetaan listan sisällöstä";
            // 
            // tbSanat
            // 
            tbSanat.Location = new Point(279, 212);
            tbSanat.Name = "tbSanat";
            tbSanat.Size = new Size(237, 27);
            tbSanat.TabIndex = 7;
            // 
            // cbHae
            // 
            cbHae.FormattingEnabled = true;
            cbHae.Location = new Point(279, 354);
            cbHae.Name = "cbHae";
            cbHae.Size = new Size(218, 28);
            cbHae.TabIndex = 8;
            // 
            // lblLista
            // 
            lblLista.AutoSize = true;
            lblLista.Location = new Point(571, 88);
            lblLista.Name = "lblLista";
            lblLista.Size = new Size(60, 20);
            lblLista.TabIndex = 9;
            lblLista.Text = "Ei listaa";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblLista);
            Controls.Add(cbHae);
            Controls.Add(tbSanat);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Controls.Add(btnAdd);
            Controls.Add(btnCreate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreate;
        private Button btnAdd;
        private Button btnSearch;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbSanat;
        private ComboBox cbHae;
        private Label lblLista;
    }
}
