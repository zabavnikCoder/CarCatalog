using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CarCatalog
{
    public partial class MainForm : Form
    {
        DataGridView my_datagridview = new DataGridView();
        DataTable my_datatable = new DataTable();

        public MainForm()
        {
            InitializeComponent();
        }

       

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CarsCatalog ct = new CarsCatalog();
            ct.ShowDialog();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CarsCatalog ct = new CarsCatalog();
            ct.ShowDialog();
           
        }

       
    }
}
