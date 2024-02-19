using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_palautus_DelegatesandEvents.Model
{
    public partial class Hakuilmoitus : Form
    {
        public Hakuilmoitus(string ilmo)
        {
            InitializeComponent();
            lblIlmo.Text = ilmo;
        }

        private void Hakuilmoitus_Load(object sender, EventArgs e)
        {

        }
    }
}
