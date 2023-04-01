using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoVerkoop
{
    public partial class frmSplash : Form
    {
        private int i = 1;

        Form parent;

        public frmSplash(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            if (i < 7)
            {
                i++;
                picLogoSplash.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\sides\\" + Convert.ToString(i) + ".png");
            }
        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            tmrSplash.Enabled = false;
            this.Close();
        }
    }
}
