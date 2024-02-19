namespace _18_palautus_DelegatesandEvents.Model
{
    partial class Hakuilmoitus
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
            lblIlmo = new Label();
            SuspendLayout();
            // 
            // lblIlmo
            // 
            lblIlmo.AutoSize = true;
            lblIlmo.Location = new Point(117, 91);
            lblIlmo.Name = "lblIlmo";
            lblIlmo.Size = new Size(111, 20);
            lblIlmo.TabIndex = 0;
            lblIlmo.Text = "Tilaamasi tuote";
            // 
            // Hakuilmoitus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblIlmo);
            Name = "Hakuilmoitus";
            Text = "Hakuilmoitus";
            Load += Hakuilmoitus_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIlmo;
    }
}