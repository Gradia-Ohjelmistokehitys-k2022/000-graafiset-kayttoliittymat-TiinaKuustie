namespace _04_Switch
{
    public partial class Form1 : Form
    {
        public Button painettuNappi = new Button();
        public Form1()
        {
            InitializeComponent();
        }

        private void viestiMB()
        {
            MessageBox.Show("Painoit nappia " + painettuNappi.Text);
        }
        private void button_Click(object sender, EventArgs e)
        {
            painettuNappi = sender as Button;
            viestiMB();
        }

    
    }
}
