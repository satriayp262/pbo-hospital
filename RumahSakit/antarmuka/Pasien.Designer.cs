
namespace PBO_RS.antarmuka
{
    partial class PasienFrm
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
            this.jk_radio = new System.Windows.Forms.Label();
            this.nama_txt = new System.Windows.Forms.TextBox();
            this.laki_rbn = new System.Windows.Forms.RadioButton();
            this.perempuan_rbn = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.alamat_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GolDar_cmb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Telp_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.kodeps_txt = new System.Windows.Forms.TextBox();
            this.simpan_btn = new System.Windows.Forms.Button();
            this.hps_btn = new System.Windows.Forms.Button();
            this.batal_btn = new System.Windows.Forms.Button();
            this.tutup_btn = new System.Windows.Forms.Button();
            this.tampilGrid = new System.Windows.Forms.DataGridView();
            this.id_psn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_psn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamat_psn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kelamin_psn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gol_dar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telp_psn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caritb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tampilGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATA PASIEN ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kode Pasien ";
            // 
            // jk_radio
            // 
            this.jk_radio.AutoSize = true;
            this.jk_radio.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jk_radio.Location = new System.Drawing.Point(108, 235);
            this.jk_radio.Name = "jk_radio";
            this.jk_radio.Size = new System.Drawing.Size(169, 32);
            this.jk_radio.TabIndex = 2;
            this.jk_radio.Text = "Jenis Kelamin ";
            // 
            // nama_txt
            // 
            this.nama_txt.Location = new System.Drawing.Point(327, 107);
            this.nama_txt.Name = "nama_txt";
            this.nama_txt.Size = new System.Drawing.Size(233, 26);
            this.nama_txt.TabIndex = 3;
            this.nama_txt.TextChanged += new System.EventHandler(this.nama_txt_TextChanged);
            // 
            // laki_rbn
            // 
            this.laki_rbn.AutoSize = true;
            this.laki_rbn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laki_rbn.Location = new System.Drawing.Point(327, 243);
            this.laki_rbn.Name = "laki_rbn";
            this.laki_rbn.Size = new System.Drawing.Size(93, 25);
            this.laki_rbn.TabIndex = 4;
            this.laki_rbn.TabStop = true;
            this.laki_rbn.Text = "Laki-laki";
            this.laki_rbn.UseVisualStyleBackColor = true;
            this.laki_rbn.CheckedChanged += new System.EventHandler(this.laki_rbn_CheckedChanged);
            // 
            // perempuan_rbn
            // 
            this.perempuan_rbn.AutoSize = true;
            this.perempuan_rbn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perempuan_rbn.Location = new System.Drawing.Point(424, 243);
            this.perempuan_rbn.Name = "perempuan_rbn";
            this.perempuan_rbn.Size = new System.Drawing.Size(114, 25);
            this.perempuan_rbn.TabIndex = 5;
            this.perempuan_rbn.TabStop = true;
            this.perempuan_rbn.Text = "Perempuan";
            this.perempuan_rbn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Almat ";
            // 
            // alamat_txt
            // 
            this.alamat_txt.Location = new System.Drawing.Point(327, 149);
            this.alamat_txt.Multiline = true;
            this.alamat_txt.Name = "alamat_txt";
            this.alamat_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.alamat_txt.Size = new System.Drawing.Size(233, 72);
            this.alamat_txt.TabIndex = 7;
            this.alamat_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(108, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Golongan Darah";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // GolDar_cmb
            // 
            this.GolDar_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GolDar_cmb.FormattingEnabled = true;
            this.GolDar_cmb.Location = new System.Drawing.Point(327, 305);
            this.GolDar_cmb.Name = "GolDar_cmb";
            this.GolDar_cmb.Size = new System.Drawing.Size(233, 28);
            this.GolDar_cmb.TabIndex = 9;
            this.GolDar_cmb.SelectedIndexChanged += new System.EventHandler(this.GolDar_cmb_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(108, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Telepon";
            // 
            // Telp_txt
            // 
            this.Telp_txt.Location = new System.Drawing.Point(327, 352);
            this.Telp_txt.Name = "Telp_txt";
            this.Telp_txt.Size = new System.Drawing.Size(233, 26);
            this.Telp_txt.TabIndex = 11;
            this.Telp_txt.TextChanged += new System.EventHandler(this.Telp_txt_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(108, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 32);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nama Pasien ";
            // 
            // kodeps_txt
            // 
            this.kodeps_txt.Enabled = false;
            this.kodeps_txt.Location = new System.Drawing.Point(327, 68);
            this.kodeps_txt.Name = "kodeps_txt";
            this.kodeps_txt.Size = new System.Drawing.Size(100, 26);
            this.kodeps_txt.TabIndex = 14;
            this.kodeps_txt.TextChanged += new System.EventHandler(this.kodeps_txt_TextChanged);
            // 
            // simpan_btn
            // 
            this.simpan_btn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpan_btn.Location = new System.Drawing.Point(114, 399);
            this.simpan_btn.Name = "simpan_btn";
            this.simpan_btn.Size = new System.Drawing.Size(94, 36);
            this.simpan_btn.TabIndex = 15;
            this.simpan_btn.Text = "SIMPAN";
            this.simpan_btn.UseVisualStyleBackColor = true;
            this.simpan_btn.Click += new System.EventHandler(this.SIMPAN_Click);
            // 
            // hps_btn
            // 
            this.hps_btn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hps_btn.Location = new System.Drawing.Point(243, 399);
            this.hps_btn.Name = "hps_btn";
            this.hps_btn.Size = new System.Drawing.Size(94, 36);
            this.hps_btn.TabIndex = 16;
            this.hps_btn.Text = "HAPUS";
            this.hps_btn.UseVisualStyleBackColor = true;
            this.hps_btn.Click += new System.EventHandler(this.hps_btn_Click);
            // 
            // batal_btn
            // 
            this.batal_btn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batal_btn.Location = new System.Drawing.Point(370, 399);
            this.batal_btn.Name = "batal_btn";
            this.batal_btn.Size = new System.Drawing.Size(94, 36);
            this.batal_btn.TabIndex = 17;
            this.batal_btn.Text = "BATAL";
            this.batal_btn.UseVisualStyleBackColor = true;
            this.batal_btn.Click += new System.EventHandler(this.batal_btn_Click);
            // 
            // tutup_btn
            // 
            this.tutup_btn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutup_btn.Location = new System.Drawing.Point(506, 399);
            this.tutup_btn.Name = "tutup_btn";
            this.tutup_btn.Size = new System.Drawing.Size(94, 36);
            this.tutup_btn.TabIndex = 18;
            this.tutup_btn.Text = "TUTUP";
            this.tutup_btn.UseVisualStyleBackColor = true;
            this.tutup_btn.Click += new System.EventHandler(this.tutup_btn_Click);
            // 
            // tampilGrid
            // 
            this.tampilGrid.AllowUserToAddRows = false;
            this.tampilGrid.AllowUserToDeleteRows = false;
            this.tampilGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tampilGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_psn,
            this.nama_psn,
            this.alamat_psn,
            this.kelamin_psn,
            this.gol_dar,
            this.telp_psn});
            this.tampilGrid.Location = new System.Drawing.Point(66, 508);
            this.tampilGrid.Name = "tampilGrid";
            this.tampilGrid.ReadOnly = true;
            this.tampilGrid.RowHeadersWidth = 62;
            this.tampilGrid.RowTemplate.Height = 28;
            this.tampilGrid.Size = new System.Drawing.Size(626, 233);
            this.tampilGrid.TabIndex = 19;
            this.tampilGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tampilGrid_CellClick);
            // 
            // id_psn
            // 
            this.id_psn.DataPropertyName = "id_psn";
            this.id_psn.HeaderText = "Kode Pasien";
            this.id_psn.MinimumWidth = 8;
            this.id_psn.Name = "id_psn";
            this.id_psn.ReadOnly = true;
            this.id_psn.Width = 150;
            // 
            // nama_psn
            // 
            this.nama_psn.DataPropertyName = "nama_psn";
            this.nama_psn.HeaderText = "Nama Pasien";
            this.nama_psn.MinimumWidth = 8;
            this.nama_psn.Name = "nama_psn";
            this.nama_psn.ReadOnly = true;
            this.nama_psn.Width = 150;
            // 
            // alamat_psn
            // 
            this.alamat_psn.DataPropertyName = "alamat_psn";
            this.alamat_psn.HeaderText = "Alamat Pasien";
            this.alamat_psn.MinimumWidth = 8;
            this.alamat_psn.Name = "alamat_psn";
            this.alamat_psn.ReadOnly = true;
            this.alamat_psn.Width = 150;
            // 
            // kelamin_psn
            // 
            this.kelamin_psn.DataPropertyName = "kelamin_psn";
            this.kelamin_psn.HeaderText = "Jenis Kelamin";
            this.kelamin_psn.MinimumWidth = 8;
            this.kelamin_psn.Name = "kelamin_psn";
            this.kelamin_psn.ReadOnly = true;
            this.kelamin_psn.Width = 150;
            // 
            // gol_dar
            // 
            this.gol_dar.DataPropertyName = "gol_dar";
            this.gol_dar.HeaderText = "Golongan Darah";
            this.gol_dar.MinimumWidth = 8;
            this.gol_dar.Name = "gol_dar";
            this.gol_dar.ReadOnly = true;
            this.gol_dar.Width = 150;
            // 
            // telp_psn
            // 
            this.telp_psn.DataPropertyName = "telp_psn";
            this.telp_psn.HeaderText = "Telepon Pasien";
            this.telp_psn.MinimumWidth = 8;
            this.telp_psn.Name = "telp_psn";
            this.telp_psn.ReadOnly = true;
            this.telp_psn.Width = 150;
            // 
            // caritb
            // 
            this.caritb.Location = new System.Drawing.Point(176, 458);
            this.caritb.Name = "caritb";
            this.caritb.Size = new System.Drawing.Size(384, 26);
            this.caritb.TabIndex = 20;
            this.caritb.TextChanged += new System.EventHandler(this.caritb_TextChanged);
            // 
            // PasienFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 703);
            this.Controls.Add(this.caritb);
            this.Controls.Add(this.tampilGrid);
            this.Controls.Add(this.tutup_btn);
            this.Controls.Add(this.batal_btn);
            this.Controls.Add(this.hps_btn);
            this.Controls.Add(this.simpan_btn);
            this.Controls.Add(this.kodeps_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Telp_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GolDar_cmb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.alamat_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.perempuan_rbn);
            this.Controls.Add(this.laki_rbn);
            this.Controls.Add(this.nama_txt);
            this.Controls.Add(this.jk_radio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PasienFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pasien";
            this.Load += new System.EventHandler(this.PasienFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tampilGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label jk_radio;
        private System.Windows.Forms.TextBox nama_txt;
        private System.Windows.Forms.RadioButton laki_rbn;
        private System.Windows.Forms.RadioButton perempuan_rbn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox alamat_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox GolDar_cmb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Telp_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox kodeps_txt;
        private System.Windows.Forms.Button simpan_btn;
        private System.Windows.Forms.Button hps_btn;
        private System.Windows.Forms.Button batal_btn;
        private System.Windows.Forms.Button tutup_btn;
        private System.Windows.Forms.DataGridView tampilGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_psn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_psn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamat_psn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kelamin_psn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gol_dar;
        private System.Windows.Forms.DataGridViewTextBoxColumn telp_psn;
        private System.Windows.Forms.TextBox caritb;
    }
}