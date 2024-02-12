namespace _06_palautus_While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool continues = true;
            while (continues)
            {
                DialogResult Result = MessageBox.Show("Vieläkö jatketaan?","Huom!",MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
                if (Result == DialogResult.No) { continues = false; }

            }
        }
    }
}
