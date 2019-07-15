using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarCatalog
{
    public partial class CarsCatalog : Form
    {
        public CarsCatalog()
        {
            InitializeComponent();
        }

        private void CatalogaventadorpictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CatalogList ctl = new CatalogList();
            ctl.ShowDialog();
        }
    }
}
