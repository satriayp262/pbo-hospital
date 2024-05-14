namespace Rekam_Medis
{
    partial class FormRM
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
            this.rekammedis_txt = new System.Windows.Forms.TextBox();
            this.diagnosa_txt = new System.Windows.Forms.TextBox();
            this.pasien_combo = new System.Windows.Forms.ComboBox();
            this.kamar_combo = new System.Windows.Forms.ComboBox();
            this.dokter_combo = new System.Windows.Forms.ComboBox();
            this.simpan_btn = new System.Windows.Forms.Button();
            this.keluar_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgrekammedis = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.cari_txt = new System.Windows.Forms.TextBox();
            this.id_rekammedis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_pasien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_dokter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no_kamar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrekammedis)).BeginInit();
            this.SuspendLayout();
            // 
            // rekammedis_txt
            // 
            this.rekammedis_txt.Location = new System.Drawing.Point(195, 107);
            this.rekammedis_txt.Name = "rekammedis_txt";
            this.rekammedis_txt.Size = new System.Drawing.Size(399, 26);
            this.rekammedis_txt.TabIndex = 0;
            this.rekammedis_txt.TextChanged += new System.EventHandler(this.rekammedis_txt_TextChanged);
            // 
            // diagnosa_txt
            // 
            this.diagnosa_txt.Location = new System.Drawing.Point(195, 176);
            this.diagnosa_txt.Name = "diagnosa_txt";
            this.diagnosa_txt.Size = new System.Drawing.Size(399, 26);
            this.diagnosa_txt.TabIndex = 1;
            this.diagnosa_txt.TextChanged += new System.EventHandler(this.diagnosa_txt_TextChanged);
            // 
            // pasien_combo
            // 
            this.pasien_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pasien_combo.FormattingEnabled = true;
            this.pasien_combo.Location = new System.Drawing.Point(195, 256);
            this.pasien_combo.Name = "pasien_combo";
            this.pasien_combo.Size = new System.Drawing.Size(121, 28);
            this.pasien_combo.TabIndex = 2;
            this.pasien_combo.SelectedIndexChanged += new System.EventHandler(this.pasien_combo_SelectedIndexChanged);
            // 
            // kamar_combo
            // 
            this.kamar_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kamar_combo.FormattingEnabled = true;
            this.kamar_combo.Location = new System.Drawing.Point(473, 256);
            this.kamar_combo.Name = "kamar_combo";
            this.kamar_combo.Size = new System.Drawing.Size(121, 28);
            this.kamar_combo.TabIndex = 3;
            this.kamar_combo.SelectedIndexChanged += new System.EventHandler(this.kamar_combo_SelectedIndexChanged);
            // 
            // dokter_combo
            // 
            this.dokter_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dokter_combo.FormattingEnabled = true;
            this.dokter_combo.Location = new System.Drawing.Point(335, 256);
            this.dokter_combo.Name = "dokter_combo";
            this.dokter_combo.Size = new System.Drawing.Size(121, 28);
            this.dokter_combo.TabIndex = 4;
            this.dokter_combo.SelectedIndexChanged += new System.EventHandler(this.dokter_combo_SelectedIndexChanged);
            // 
            // simpan_btn
            // 
            this.simpan_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.simpan_btn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpan_btn.Location = new System.Drawing.Point(216, 323);
            this.simpan_btn.Name = "simpan_btn";
            this.simpan_btn.Size = new System.Drawing.Size(100, 35);
            this.simpan_btn.TabIndex = 5;
            this.simpan_btn.Text = "Simpan";
            this.simpan_btn.UseVisualStyleBackColor = false;
            this.simpan_btn.Click += new System.EventHandler(this.simpan_btn_Click);
            // 
            // keluar_btn
            // 
            this.keluar_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.keluar_btn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keluar_btn.Location = new System.Drawing.Point(473, 323);
            this.keluar_btn.Name = "keluar_btn";
            this.keluar_btn.Size = new System.Drawing.Size(100, 35);
            this.keluar_btn.TabIndex = 6;
            this.keluar_btn.Text = "Keluar";
            this.keluar_btn.UseVisualStyleBackColor = false;
            this.keluar_btn.Click += new System.EventHandler(this.keluar_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID Rekam Medis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Diagnosa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(204, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nama Pasien";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(342, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nama Dokter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(494, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "No Kamar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(249, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(276, 54);
            this.label6.TabIndex = 12;
            this.label6.Text = "Rekam Medis";
            // 
            // dgrekammedis
            // 
            this.dgrekammedis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrekammedis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_rekammedis,
            this.nama_pasien,
            this.nama_dokter,
            this.no_kamar,
            this.diagnosa});
            this.dgrekammedis.Location = new System.Drawing.Point(25, 433);
            this.dgrekammedis.Name = "dgrekammedis";
            this.dgrekammedis.RowHeadersWidth = 62;
            this.dgrekammedis.RowTemplate.Height = 28;
            this.dgrekammedis.Size = new System.Drawing.Size(780, 150);
            this.dgrekammedis.TabIndex = 13;
            this.dgrekammedis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrekammedis_CellContentClick);
            this.dgrekammedis.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrekammedis_CellContentDoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(149, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cari";
            // 
            // cari_txt
            // 
            this.cari_txt.Location = new System.Drawing.Point(195, 392);
            this.cari_txt.Name = "cari_txt";
            this.cari_txt.Size = new System.Drawing.Size(399, 26);
            this.cari_txt.TabIndex = 15;
            this.cari_txt.TextChanged += new System.EventHandler(this.cari_txt_TextChanged);
            // 
            // id_rekammedis
            // 
            this.id_rekammedis.DataPropertyName = "id_rm";
            this.id_rekammedis.HeaderText = "ID Rekam Medis";
            this.id_rekammedis.MinimumWidth = 8;
            this.id_rekammedis.Name = "id_rekammedis";
            this.id_rekammedis.Width = 150;
            // 
            // nama_pasien
            // 
            this.nama_pasien.DataPropertyName = "nama_psn";
            this.nama_pasien.HeaderText = "Nama Pasien";
            this.nama_pasien.MinimumWidth = 8;
            this.nama_pasien.Name = "nama_pasien";
            this.nama_pasien.Width = 150;
            // 
            // nama_dokter
            // 
            this.nama_dokter.DataPropertyName = "nama_dr";
            this.nama_dokter.HeaderText = "Nama Dokter";
            this.nama_dokter.MinimumWidth = 8;
            this.nama_dokter.Name = "nama_dokter";
            this.nama_dokter.Width = 150;
            // 
            // no_kamar
            // 
            this.no_kamar.DataPropertyName = "no_kmr";
            this.no_kamar.HeaderText = "No Kamar";
            this.no_kamar.MinimumWidth = 8;
            this.no_kamar.Name = "no_kamar";
            this.no_kamar.Width = 150;
            // 
            // diagnosa
            // 
            this.diagnosa.DataPropertyName = "diagnosa";
            this.diagnosa.HeaderText = "Diagnosa";
            this.diagnosa.MinimumWidth = 8;
            this.diagnosa.Name = "diagnosa";
            this.diagnosa.Width = 150;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(346, 323);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(100, 35);
            this.deleteBtn.TabIndex = 16;
            this.deleteBtn.Text = "Hapus";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 613);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.cari_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgrekammedis);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keluar_btn);
            this.Controls.Add(this.simpan_btn);
            this.Controls.Add(this.dokter_combo);
            this.Controls.Add(this.kamar_combo);
            this.Controls.Add(this.pasien_combo);
            this.Controls.Add(this.diagnosa_txt);
            this.Controls.Add(this.rekammedis_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrekammedis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rekammedis_txt;
        private System.Windows.Forms.TextBox diagnosa_txt;
        private System.Windows.Forms.ComboBox pasien_combo;
        private System.Windows.Forms.ComboBox kamar_combo;
        private System.Windows.Forms.ComboBox dokter_combo;
        private System.Windows.Forms.Button simpan_btn;
        private System.Windows.Forms.Button keluar_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgrekammedis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cari_txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_rekammedis;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_pasien;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_dokter;
        private System.Windows.Forms.DataGridViewTextBoxColumn no_kamar;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosa;
        private System.Windows.Forms.Button deleteBtn;
    }
}

