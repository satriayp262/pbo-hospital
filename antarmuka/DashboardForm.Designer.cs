namespace RumahSakit
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dokterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ruanganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rekamMedisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataMasterToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataMasterToolStripMenuItem
            // 
            this.dataMasterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dokterToolStripMenuItem,
            this.ruanganToolStripMenuItem,
            this.pasienToolStripMenuItem,
            this.rekamMedisToolStripMenuItem});
            this.dataMasterToolStripMenuItem.Name = "dataMasterToolStripMenuItem";
            this.dataMasterToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.dataMasterToolStripMenuItem.Text = "Data Master";
            // 
            // dokterToolStripMenuItem
            // 
            this.dokterToolStripMenuItem.Name = "dokterToolStripMenuItem";
            this.dokterToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dokterToolStripMenuItem.Text = "Dokter";
            // 
            // ruanganToolStripMenuItem
            // 
            this.ruanganToolStripMenuItem.Name = "ruanganToolStripMenuItem";
            this.ruanganToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ruanganToolStripMenuItem.Text = "Ruangan";
            this.ruanganToolStripMenuItem.Click += new System.EventHandler(this.ruanganToolStripMenuItem_Click);
            // 
            // pasienToolStripMenuItem
            // 
            this.pasienToolStripMenuItem.Name = "pasienToolStripMenuItem";
            this.pasienToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pasienToolStripMenuItem.Text = "Pasien";
            // 
            // rekamMedisToolStripMenuItem
            // 
            this.rekamMedisToolStripMenuItem.Name = "rekamMedisToolStripMenuItem";
            this.rekamMedisToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.rekamMedisToolStripMenuItem.Text = "Rekam Medis";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.logOutToolStripMenuItem.Text = "Log out";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DashboardForm";
            this.Text = "CareConnect";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dokterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ruanganToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rekamMedisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}

