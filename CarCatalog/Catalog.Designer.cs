namespace CarCatalog
{
    partial class CarsCatalog
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
            this.aventadorlabel = new System.Windows.Forms.Label();
            this.catalogaventadorpictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.catalogaventadorpictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // aventadorlabel
            // 
            this.aventadorlabel.AutoSize = true;
            this.aventadorlabel.Location = new System.Drawing.Point(12, 9);
            this.aventadorlabel.Name = "aventadorlabel";
            this.aventadorlabel.Size = new System.Drawing.Size(75, 19);
            this.aventadorlabel.TabIndex = 0;
            this.aventadorlabel.Text = "Aventador";
            // 
            // catalogaventadorpictureBox1
            // 
            this.catalogaventadorpictureBox1.Image = global::CarCatalog.Properties.Resources.Lamborghini_Aventador_S_Coupe;
            this.catalogaventadorpictureBox1.Location = new System.Drawing.Point(12, 31);
            this.catalogaventadorpictureBox1.Name = "catalogaventadorpictureBox1";
            this.catalogaventadorpictureBox1.Size = new System.Drawing.Size(100, 50);
            this.catalogaventadorpictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.catalogaventadorpictureBox1.TabIndex = 2;
            this.catalogaventadorpictureBox1.TabStop = false;
            this.catalogaventadorpictureBox1.Click += new System.EventHandler(this.CatalogaventadorpictureBox1_Click);
            // 
            // CarsCatalog
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.catalogaventadorpictureBox1);
            this.Controls.Add(this.aventadorlabel);
            this.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CarsCatalog";
            this.Text = "Catalog";
            ((System.ComponentModel.ISupportInitialize)(this.catalogaventadorpictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aventadorlabel;
        private System.Windows.Forms.PictureBox catalogaventadorpictureBox1;
    }
}