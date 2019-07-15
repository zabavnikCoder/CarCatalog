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
    public partial class CatalogList : Form
    {
        public CatalogList()
        {
            InitializeComponent();
        }

        DataGridView dataGridView = new DataGridView();
        DataTable dataTable = new DataTable();

        private void MainCarCatalog_Load(object sender, EventArgs e)
        {
            this.Size = new Size(800, 600);
            dataGridView.Size = new Size(1350, 960);
            dataGridView.Location = new Point(20, 20);

            string[] rawText = File.ReadAllLines("C:\\Users\\Admin\\Desktop\\myvehicles.csv");
            string[] dataCol = null;
            int x = 0;
            foreach (string textLine in rawText)
            {
                dataCol = textLine.Split(',');

                if (x == 0)
                {
                    for (int i = 0; i <= dataCol.Count() - 1; i++)
                    {
                        dataTable.Columns.Add(dataCol[i]);
                    }
                    x++;
                }
                else
                {
                    
                    dataTable.Rows.Add(dataCol);
                }


            }
            dataGridView.DataSource = dataTable;
            this.Controls.Add(dataGridView);
        }
    }
}
