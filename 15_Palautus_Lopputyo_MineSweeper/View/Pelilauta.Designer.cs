namespace _15_Palautus_Lopputyo_MineSweeper.View
{
    partial class Pelilauta
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
            components = new System.ComponentModel.Container();
            lblScore = new Label();
            label1 = new Label();
            lblOhjeet = new Label();
            lblHighscore = new Label();
            FlappingTimer = new System.Windows.Forms.Timer(components);
            lblRounds = new Label();
            SuspendLayout();
            // 
            // lblScore
            // 
            lblScore.Anchor = AnchorStyles.Right;
            lblScore.AutoSize = true;
            lblScore.BackColor = SystemColors.GradientInactiveCaption;
            lblScore.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScore.Location = new Point(704, 137);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(74, 23);
            lblScore.TabIndex = 0;
            lblScore.Text = "Score: 0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(62, 9);
            label1.Name = "label1";
            label1.Size = new Size(273, 23);
            label1.TabIndex = 1;
            label1.Text = "Help granny to find all sausages!";
            // 
            // lblOhjeet
            // 
            lblOhjeet.Anchor = AnchorStyles.Bottom;
            lblOhjeet.AutoSize = true;
            lblOhjeet.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOhjeet.Location = new Point(109, 418);
            lblOhjeet.Name = "lblOhjeet";
            lblOhjeet.Size = new Size(588, 23);
            lblOhjeet.TabIndex = 0;
            lblOhjeet.Text = "LMB: Smashsplode   RMB: Pick carefully, but do not freeze your fingers!";
            // 
            // lblHighscore
            // 
            lblHighscore.AutoSize = true;
            lblHighscore.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHighscore.Location = new Point(350, 9);
            lblHighscore.Name = "lblHighscore";
            lblHighscore.Size = new Size(131, 23);
            lblHighscore.TabIndex = 2;
            lblHighscore.Text = "Highest Score: ";
            // 
            // lblRounds
            // 
            lblRounds.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRounds.AutoSize = true;
            lblRounds.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRounds.Location = new Point(657, 9);
            lblRounds.Name = "lblRounds";
            lblRounds.Size = new Size(74, 23);
            lblRounds.TabIndex = 3;
            lblRounds.Text = "Rounds:";
            // 
            // Pelilauta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            BackgroundImage = Properties.Resources.PohjaIceSmall;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(lblRounds);
            Controls.Add(lblHighscore);
            Controls.Add(lblOhjeet);
            Controls.Add(label1);
            Controls.Add(lblScore);
            Name = "Pelilauta";
            Text = "Sausage Hideout";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblScore;
        private Label label1;
        private Label lblOhjeet;
        private Label lblHighscore;
        public System.Windows.Forms.Timer FlappingTimer;
        private Label lblRounds;
    }
}