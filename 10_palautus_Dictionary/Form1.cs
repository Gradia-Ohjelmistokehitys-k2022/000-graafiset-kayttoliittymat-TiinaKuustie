using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _10_palautus_Dictionary
{
    public partial class Form1 : Form
    {
        IDictionary<int, string> numberNames;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            numberNames = new Dictionary<int, string>();
            lblLuotu.Text = "Dictionary luotu";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(tbAddKey.Text, @"^[0-9]+$"))
                { 
                     numberNames.Add(Convert.ToInt32(tbAddKey.Text), tbAddValue.Text);
                      MessageBox.Show($"Lis‰tty avaimelle {Convert.ToInt32(tbAddKey.Text)} arvo {tbAddValue.Text}");
                }
                else
                {
                    MessageBox.Show($"Lis‰‰ vain numeroita avaimeksi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHae_Click(object sender, EventArgs e)
        {
            int avain = Convert.ToInt32(tbHaeKey.Text);
            if (numberNames.ContainsKey(avain))
            {
                lblHakutulos.Text = "Hakutulos: " + numberNames[avain];

            }
            else
            {
                lblHakutulos.Text = "Ei hakutuloksia";
            }
        }

      
    }
}
