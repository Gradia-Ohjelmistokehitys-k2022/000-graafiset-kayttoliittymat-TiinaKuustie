namespace _15_Palautus_Lopputyo_MineSweeper
{
    partial class Valinta
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
            btnEasy = new Button();
            btnMid = new Button();
            btnHard = new Button();
            lblDifficulty = new Label();
            rbSingle = new RadioButton();
            rbContinuous = new RadioButton();
            SendSausage = new System.Windows.Forms.Timer(components);
            DirectionAndScreenshot = new System.Windows.Forms.Timer(components);
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnEasy
            // 
            btnEasy.Location = new Point(266, 298);
            btnEasy.Name = "btnEasy";
            btnEasy.Size = new Size(94, 29);
            btnEasy.TabIndex = 3;
            btnEasy.Text = "Small";
            btnEasy.UseVisualStyleBackColor = true;
            btnEasy.Click += btnEasy_Click;
            // 
            // btnMid
            // 
            btnMid.Location = new Point(366, 298);
            btnMid.Name = "btnMid";
            btnMid.Size = new Size(94, 29);
            btnMid.TabIndex = 4;
            btnMid.Text = "Middle";
            btnMid.UseVisualStyleBackColor = true;
            btnMid.Click += btnMid_Click;
            // 
            // btnHard
            // 
            btnHard.Location = new Point(466, 298);
            btnHard.Name = "btnHard";
            btnHard.Size = new Size(94, 29);
            btnHard.TabIndex = 5;
            btnHard.Text = "Big";
            btnHard.UseVisualStyleBackColor = true;
            btnHard.Click += btnHard_Click;
            // 
            // lblDifficulty
            // 
            lblDifficulty.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblDifficulty.AutoSize = true;
            lblDifficulty.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDifficulty.Location = new Point(309, 262);
            lblDifficulty.Name = "lblDifficulty";
            lblDifficulty.Size = new Size(201, 24);
            lblDifficulty.TabIndex = 0;
            lblDifficulty.Text = "Pick the freezer size";
            // 
            // rbSingle
            // 
            rbSingle.AutoSize = true;
            rbSingle.Checked = true;
            rbSingle.Location = new Point(176, 207);
            rbSingle.Name = "rbSingle";
            rbSingle.Size = new Size(114, 24);
            rbSingle.TabIndex = 2;
            rbSingle.TabStop = true;
            rbSingle.Text = "Single Game";
            rbSingle.UseVisualStyleBackColor = true;
            rbSingle.CheckedChanged += rbSingle_CheckedChanged;
            // 
            // rbContinuous
            // 
            rbContinuous.AutoSize = true;
            rbContinuous.Location = new Point(176, 237);
            rbContinuous.Name = "rbContinuous";
            rbContinuous.Size = new Size(104, 24);
            rbContinuous.TabIndex = 1;
            rbContinuous.Text = "Continuous";
            rbContinuous.UseVisualStyleBackColor = true;
            rbContinuous.CheckedChanged += rbContinuous_CheckedChanged;
            // 
            // SendSausage
            // 
            SendSausage.Tick += timer1_Tick;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(696, 418);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Valinta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImage = Properties.Resources.BoxFreezer2;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(rbContinuous);
            Controls.Add(rbSingle);
            Controls.Add(lblDifficulty);
            Controls.Add(btnHard);
            Controls.Add(btnMid);
            Controls.Add(btnEasy);
            Name = "Valinta";
            Text = "Tiina-granny's missing sausages";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEasy;
        private Button btnMid;
        private Button btnHard;
        private Label lblDifficulty;
        private RadioButton rbSingle;
        private RadioButton rbContinuous;
        public System.Windows.Forms.Timer DirectionAndScreenshot;
        private Button btnExit;
        public System.Windows.Forms.Timer SendSausage;
    }
}
