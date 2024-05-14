namespace RumahSakit.antarmuka
{
    partial class RuanganForm
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
            this.kode_kmr_txt = new System.Windows.Forms.TextBox();
            this.nama_kmr_txt = new System.Windows.Forms.TextBox();
            this.status_cb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.simpan_btn = new System.Windows.Forms.Button();
            this.hapus_btn = new System.Windows.Forms.Button();
            this.batal_btn = new System.Windows.Forms.Button();
            this.ruangan_dgv = new System.Windows.Forms.DataGridView();
            this.cNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRuangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutup_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cari_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ruangan_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // kode_kmr_txt
            // 
            this.kode_kmr_txt.Location = new System.Drawing.Point(370, 75);
            this.kode_kmr_txt.Name = "kode_kmr_txt";
            this.kode_kmr_txt.Size = new System.Drawing.Size(117, 22);
            this.kode_kmr_txt.TabIndex = 0;
            // 
            // nama_kmr_txt
            // 
            this.nama_kmr_txt.Location = new System.Drawing.Point(370, 126);
            this.nama_kmr_txt.Name = "nama_kmr_txt";
            this.nama_kmr_txt.Size = new System.Drawing.Size(194, 22);
            this.nama_kmr_txt.TabIndex = 1;
            // 
            // status_cb
            // 
            this.status_cb.FormattingEnabled = true;
            this.status_cb.Items.AddRange(new object[] {
            "Terisi",
            "Kosong"});
            this.status_cb.Location = new System.Drawing.Point(370, 176);
            this.status_cb.Name = "status_cb";
            this.status_cb.Size = new System.Drawing.Size(117, 24);
            this.status_cb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "NO. RUANGAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "NAMA RUANGAN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "STATUS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(309, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "DATA RUANGAN";
            // 
            // simpan_btn
            // 
            this.simpan_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpan_btn.Location = new System.Drawing.Point(218, 216);
            this.simpan_btn.Name = "simpan_btn";
            this.simpan_btn.Size = new System.Drawing.Size(75, 23);
            this.simpan_btn.TabIndex = 7;
            this.simpan_btn.Text = "SIMPAN";
            this.simpan_btn.UseVisualStyleBackColor = true;
            this.simpan_btn.Click += new System.EventHandler(this.simpan_btn_Click);
            // 
            // hapus_btn
            // 
            this.hapus_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapus_btn.Location = new System.Drawing.Point(314, 216);
            this.hapus_btn.Name = "hapus_btn";
            this.hapus_btn.Size = new System.Drawing.Size(75, 23);
            this.hapus_btn.TabIndex = 8;
            this.hapus_btn.Text = "HAPUS";
            this.hapus_btn.UseVisualStyleBackColor = true;
            this.hapus_btn.Click += new System.EventHandler(this.hapus_btn_Click);
            // 
            // batal_btn
            // 
            this.batal_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batal_btn.Location = new System.Drawing.Point(412, 216);
            this.batal_btn.Name = "batal_btn";
            this.batal_btn.Size = new System.Drawing.Size(75, 23);
            this.batal_btn.TabIndex = 9;
            this.batal_btn.Text = "BATAL";
            this.batal_btn.UseVisualStyleBackColor = true;
            this.batal_btn.Click += new System.EventHandler(this.batal_btn_Click);
            // 
            // ruangan_dgv
            // 
            this.ruangan_dgv.AllowUserToAddRows = false;
            this.ruangan_dgv.AllowUserToDeleteRows = false;
            this.ruangan_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ruangan_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNo,
            this.cRuangan,
            this.cStatus});
            this.ruangan_dgv.Location = new System.Drawing.Point(12, 292);
            this.ruangan_dgv.Name = "ruangan_dgv";
            this.ruangan_dgv.ReadOnly = true;
            this.ruangan_dgv.RowHeadersWidth = 51;
            this.ruangan_dgv.RowTemplate.Height = 24;
            this.ruangan_dgv.Size = new System.Drawing.Size(776, 146);
            this.ruangan_dgv.TabIndex = 10;
            this.ruangan_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ruangan_dgv_CellClick);
            // 
            // cNo
            // 
            this.cNo.DataPropertyName = "no_kmr";
            this.cNo.HeaderText = "NOMOR";
            this.cNo.MinimumWidth = 6;
            this.cNo.Name = "cNo";
            this.cNo.ReadOnly = true;
            this.cNo.Width = 125;
            // 
            // cRuangan
            // 
            this.cRuangan.DataPropertyName = "nama_kmr";
            this.cRuangan.HeaderText = "RUANGAN";
            this.cRuangan.MinimumWidth = 6;
            this.cRuangan.Name = "cRuangan";
            this.cRuangan.ReadOnly = true;
            this.cRuangan.Width = 200;
            // 
            // cStatus
            // 
            this.cStatus.DataPropertyName = "status_kmr";
            this.cStatus.HeaderText = "STATUS";
            this.cStatus.MinimumWidth = 6;
            this.cStatus.Name = "cStatus";
            this.cStatus.ReadOnly = true;
            this.cStatus.Width = 200;
            // 
            // tutup_btn
            // 
            this.tutup_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutup_btn.Location = new System.Drawing.Point(511, 216);
            this.tutup_btn.Name = "tutup_btn";
            this.tutup_btn.Size = new System.Drawing.Size(75, 23);
            this.tutup_btn.TabIndex = 11;
            this.tutup_btn.Text = "TUTUP";
            this.tutup_btn.UseVisualStyleBackColor = true;
            this.tutup_btn.Click += new System.EventHandler(this.tutup_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label5.Location = new System.Drawing.Point(12, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Pencarian berdasarkan nama ruangan";
            // 
            // cari_txt
            // 
            this.cari_txt.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cari_txt.Location = new System.Drawing.Point(12, 264);
            this.cari_txt.Name = "cari_txt";
            this.cari_txt.Size = new System.Drawing.Size(776, 22);
            this.cari_txt.TabIndex = 26;
            this.cari_txt.TextChanged += new System.EventHandler(this.cari_txt_TextChanged);
            // 
            // RuanganForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cari_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tutup_btn);
            this.Controls.Add(this.ruangan_dgv);
            this.Controls.Add(this.batal_btn);
            this.Controls.Add(this.hapus_btn);
            this.Controls.Add(this.simpan_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.status_cb);
            this.Controls.Add(this.nama_kmr_txt);
            this.Controls.Add(this.kode_kmr_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RuanganForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.RuanganForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ruangan_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kode_kmr_txt;
        private System.Windows.Forms.TextBox nama_kmr_txt;
        private System.Windows.Forms.ComboBox status_cb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button simpan_btn;
        private System.Windows.Forms.Button hapus_btn;
        private System.Windows.Forms.Button batal_btn;
        private System.Windows.Forms.DataGridView ruangan_dgv;
        private System.Windows.Forms.Button tutup_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cari_txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRuangan;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStatus;
    }
}