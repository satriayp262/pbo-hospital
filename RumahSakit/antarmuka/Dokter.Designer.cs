
namespace PBO_RS.antarmuka
{
    partial class Dokter
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.kodeDktr_txt = new System.Windows.Forms.TextBox();
            this.namaDktr_txt = new System.Windows.Forms.TextBox();
            this.alamatDktr_txt = new System.Windows.Forms.TextBox();
            this.telp_txt = new System.Windows.Forms.TextBox();
            this.katrgotiDktr_txt = new System.Windows.Forms.TextBox();
            this.Simpan_btn = new System.Windows.Forms.Button();
            this.hps_btn = new System.Windows.Forms.Button();
            this.tampilgrid = new System.Windows.Forms.DataGridView();
            this.id_dr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaDokter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnbatal = new System.Windows.Forms.Button();
            this.btnkeluar = new System.Windows.Forms.Button();
            this.cari = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tampilgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "DOKTER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kode Dokter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(171, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama Dokter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(171, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alamat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(171, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telepon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(171, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kategori";
            // 
            // kodeDktr_txt
            // 
            this.kodeDktr_txt.Enabled = false;
            this.kodeDktr_txt.Location = new System.Drawing.Point(379, 77);
            this.kodeDktr_txt.Name = "kodeDktr_txt";
            this.kodeDktr_txt.Size = new System.Drawing.Size(164, 26);
            this.kodeDktr_txt.TabIndex = 6;
            // 
            // namaDktr_txt
            // 
            this.namaDktr_txt.Location = new System.Drawing.Point(379, 122);
            this.namaDktr_txt.Name = "namaDktr_txt";
            this.namaDktr_txt.Size = new System.Drawing.Size(196, 26);
            this.namaDktr_txt.TabIndex = 7;
            // 
            // alamatDktr_txt
            // 
            this.alamatDktr_txt.Location = new System.Drawing.Point(379, 169);
            this.alamatDktr_txt.Multiline = true;
            this.alamatDktr_txt.Name = "alamatDktr_txt";
            this.alamatDktr_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.alamatDktr_txt.Size = new System.Drawing.Size(238, 75);
            this.alamatDktr_txt.TabIndex = 8;
            // 
            // telp_txt
            // 
            this.telp_txt.Location = new System.Drawing.Point(379, 264);
            this.telp_txt.Name = "telp_txt";
            this.telp_txt.Size = new System.Drawing.Size(196, 26);
            this.telp_txt.TabIndex = 9;
            // 
            // katrgotiDktr_txt
            // 
            this.katrgotiDktr_txt.Location = new System.Drawing.Point(379, 320);
            this.katrgotiDktr_txt.Name = "katrgotiDktr_txt";
            this.katrgotiDktr_txt.Size = new System.Drawing.Size(196, 26);
            this.katrgotiDktr_txt.TabIndex = 10;
            // 
            // Simpan_btn
            // 
            this.Simpan_btn.Location = new System.Drawing.Point(177, 377);
            this.Simpan_btn.Name = "Simpan_btn";
            this.Simpan_btn.Size = new System.Drawing.Size(87, 35);
            this.Simpan_btn.TabIndex = 11;
            this.Simpan_btn.Text = "SIMPAN";
            this.Simpan_btn.UseVisualStyleBackColor = true;
            this.Simpan_btn.Click += new System.EventHandler(this.Simpan_btn_Click);
            // 
            // hps_btn
            // 
            this.hps_btn.Location = new System.Drawing.Point(311, 377);
            this.hps_btn.Name = "hps_btn";
            this.hps_btn.Size = new System.Drawing.Size(87, 35);
            this.hps_btn.TabIndex = 12;
            this.hps_btn.Text = "HAPUS";
            this.hps_btn.UseVisualStyleBackColor = true;
            this.hps_btn.Click += new System.EventHandler(this.hps_btn_Click);
            // 
            // tampilgrid
            // 
            this.tampilgrid.AllowUserToAddRows = false;
            this.tampilgrid.AllowUserToDeleteRows = false;
            this.tampilgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tampilgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_dr,
            this.NamaDokter,
            this.Column1,
            this.Column2,
            this.Column3});
            this.tampilgrid.Location = new System.Drawing.Point(42, 484);
            this.tampilgrid.Name = "tampilgrid";
            this.tampilgrid.ReadOnly = true;
            this.tampilgrid.RowHeadersWidth = 62;
            this.tampilgrid.RowTemplate.Height = 28;
            this.tampilgrid.Size = new System.Drawing.Size(822, 187);
            this.tampilgrid.TabIndex = 13;
            this.tampilgrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tampilgrid_CellClick);
            // 
            // id_dr
            // 
            this.id_dr.DataPropertyName = "id_dr";
            this.id_dr.HeaderText = "Kode Dokter";
            this.id_dr.MinimumWidth = 8;
            this.id_dr.Name = "id_dr";
            this.id_dr.ReadOnly = true;
            this.id_dr.Width = 150;
            // 
            // NamaDokter
            // 
            this.NamaDokter.DataPropertyName = "nama_dr";
            this.NamaDokter.HeaderText = "Nama Dokter";
            this.NamaDokter.MinimumWidth = 8;
            this.NamaDokter.Name = "NamaDokter";
            this.NamaDokter.ReadOnly = true;
            this.NamaDokter.Width = 150;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "alamat_dr";
            this.Column1.HeaderText = "Alamat";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "telp_dr";
            this.Column2.HeaderText = "Telepon";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "kategori";
            this.Column3.HeaderText = "Kategori";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // btnbatal
            // 
            this.btnbatal.Location = new System.Drawing.Point(470, 376);
            this.btnbatal.Name = "btnbatal";
            this.btnbatal.Size = new System.Drawing.Size(87, 35);
            this.btnbatal.TabIndex = 14;
            this.btnbatal.Text = "BATAL";
            this.btnbatal.UseVisualStyleBackColor = true;
            this.btnbatal.Click += new System.EventHandler(this.btnbatal_Click);
            // 
            // btnkeluar
            // 
            this.btnkeluar.Location = new System.Drawing.Point(624, 377);
            this.btnkeluar.Name = "btnkeluar";
            this.btnkeluar.Size = new System.Drawing.Size(87, 35);
            this.btnkeluar.TabIndex = 15;
            this.btnkeluar.Text = "KELUAR";
            this.btnkeluar.UseVisualStyleBackColor = true;
            this.btnkeluar.Click += new System.EventHandler(this.btnkeluar_Click);
            // 
            // cari
            // 
            this.cari.Location = new System.Drawing.Point(258, 435);
            this.cari.Name = "cari";
            this.cari.Size = new System.Drawing.Size(385, 26);
            this.cari.TabIndex = 16;
            this.cari.TextChanged += new System.EventHandler(this.cari_TextChanged);
            // 
            // Dokter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 700);
            this.Controls.Add(this.cari);
            this.Controls.Add(this.btnkeluar);
            this.Controls.Add(this.btnbatal);
            this.Controls.Add(this.tampilgrid);
            this.Controls.Add(this.hps_btn);
            this.Controls.Add(this.Simpan_btn);
            this.Controls.Add(this.katrgotiDktr_txt);
            this.Controls.Add(this.telp_txt);
            this.Controls.Add(this.alamatDktr_txt);
            this.Controls.Add(this.namaDktr_txt);
            this.Controls.Add(this.kodeDktr_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Dokter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dokter";
            this.Load += new System.EventHandler(this.Dokter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tampilgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox kodeDktr_txt;
        private System.Windows.Forms.TextBox namaDktr_txt;
        private System.Windows.Forms.TextBox alamatDktr_txt;
        private System.Windows.Forms.TextBox telp_txt;
        private System.Windows.Forms.TextBox katrgotiDktr_txt;
        private System.Windows.Forms.Button Simpan_btn;
        private System.Windows.Forms.Button hps_btn;
        private System.Windows.Forms.DataGridView tampilgrid;
        private System.Windows.Forms.Button btnbatal;
        private System.Windows.Forms.Button btnkeluar;
        private System.Windows.Forms.TextBox cari;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_dr;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaDokter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}