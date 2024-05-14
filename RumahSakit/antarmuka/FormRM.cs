using MySql.Data.MySqlClient;
using Rekam_Medis.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Rekam_Medis
{
    public partial class FormRM : Form

    {
        RekamMedisCls rekamMedis;
        public FormRM()
        {
            InitializeComponent();
            rekamMedis = new RekamMedisCls();
            FillComboBoxes();
            rekammedis_txt.KeyPress += new KeyPressEventHandler(rekammedis_txt_KeyPress);
            pasien_combo.SelectedIndex = -1;
            dokter_combo.SelectedIndex = -1;
            kamar_combo.SelectedIndex = -1;
        }

        private void rekammedis_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Hanya izinkan angka, tombol backspace, dan tombol delete
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FillComboBoxes()
        {
            DataTable pasienData = rekamMedis.GetPasienData();
            pasien_combo.DataSource = pasienData;
            pasien_combo.DisplayMember = "nama_psn";
            pasien_combo.ValueMember = "id_psn"; 

            DataTable dokterData = rekamMedis.GetDokterData();
            dokter_combo.DataSource = dokterData;
            dokter_combo.DisplayMember = "nama_dr"; 
            dokter_combo.ValueMember = "id_dr"; 

            DataTable kamarData = rekamMedis.GetKamarData();
            kamar_combo.DataSource = kamarData;
            kamar_combo.DisplayMember = "no_kmr";
            kamar_combo.ValueMember = "no_kmr";
        }


        private void rekammedis_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void diagnosa_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void pasien_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dokter_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kamar_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void simpan_btn_Click(object sender, EventArgs e)
        {
            // Mengambil data dari combo box
            string idPasien = pasien_combo.SelectedValue?.ToString();
            string idDokter = dokter_combo.SelectedValue?.ToString();
            string noKamar = kamar_combo.SelectedValue?.ToString();

            // Memeriksa apakah semua combo box telah dipilih
            if (string.IsNullOrWhiteSpace(idPasien) || string.IsNullOrWhiteSpace(idDokter) || string.IsNullOrWhiteSpace(noKamar))
            {
                MessageBox.Show("Semua data harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string idRekamMedis = rekammedis_txt.Text;
                string diagnosa = diagnosa_txt.Text;

                // Memeriksa apakah id rekam medis dan diagnosa tidak kosong
                if (string.IsNullOrWhiteSpace(idRekamMedis) || string.IsNullOrWhiteSpace(diagnosa))
                {
                    MessageBox.Show("Semua data harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (IsDuplicateKamar(noKamar))
                {
                    MessageBox.Show("Kamar sudah terisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    rekamMedis.setIdRekamMedis = idRekamMedis;
                    rekamMedis.setDiagnosa = diagnosa;
                    rekamMedis.setIdDokter = idDokter;
                    rekamMedis.setIdPasien = idPasien;
                    rekamMedis.setNoKamar = noKamar;

                    int result = rekamMedis.simpanData();
                    if (result > 0)
                    {
                        MessageBox.Show("Data berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        rekammedis_txt.Text = "";
                        diagnosa_txt.Text = "";
                        rekammedis_txt.Focus();
                        pasien_combo.SelectedIndex = -1;
                        dokter_combo.SelectedIndex = -1;
                        kamar_combo.SelectedIndex = -1;
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Apakah Data akan Diubah?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            if (rekamMedis.ubahData(idRekamMedis, diagnosa, idPasien, idDokter, noKamar) > 0)
                            {
                                MessageBox.Show("Data Berhasil Diubah.", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                rekammedis_txt.Text = "";
                                diagnosa_txt.Text = "";
                                diagnosa_txt.Focus();
                                pasien_combo.SelectedIndex = -1;
                                dokter_combo.SelectedIndex = -1;
                                kamar_combo.SelectedIndex = -1;
                            }
                            else
                            {
                                MessageBox.Show("Gagal mengubah data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            rekammedis_txt.Text = "";
                            diagnosa_txt.Text = "";
                            pasien_combo.SelectedIndex = -1;
                            dokter_combo.SelectedIndex = -1;
                            kamar_combo.SelectedIndex = -1;
                        }
                    }
                    tampilGrid();
                }
            }
        }




        private bool IsDuplicateKamar(string noKamar)
        {
            DataTable rekamData = rekamMedis.GetRekamMedisKamarData();
            foreach (DataRow row in rekamData.Rows)
            {
                if (row["no_kmr"].ToString() == noKamar)
                {
                    return true;
                }
            }
            return false;
        }


        private void keluar_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       
        void tampilGrid()
        {
            if (cari_txt.Text == "")
            {
                dgrekammedis.DataSource = rekamMedis.tampilkanSemua();
            }
            else
            {
                dgrekammedis.DataSource = rekamMedis.cariNama(cari_txt.Text);
            }
            belang(dgrekammedis);
        }

        void belang(DataGridView dgv)
        {
            foreach (DataGridViewRow baris in dgv.Rows)
            {
                foreach (DataGridViewCell kolom in baris.Cells)
                {
                    if (baris.Index % 2 == 1)
                    {
                        kolom.Style.BackColor = Color.WhiteSmoke;
                    }
                    else
                    {
                        kolom.Style.BackColor = Color.LightGray;
                    }
                }
            }
        }

        private void dgrekammedis_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tampilGrid();
        }

        private void dgrekammedis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow baris = this.dgrekammedis.Rows[e.RowIndex];
            rekammedis_txt.Text = baris.Cells[0].Value.ToString();
            diagnosa_txt.Text = baris.Cells[4].Value.ToString();
            pasien_combo.Text = baris.Cells[1].Value.ToString();
            dokter_combo.Text = baris.Cells[2].Value.ToString();
            kamar_combo.Text = baris.Cells[3].Value.ToString();
        }

        private void cari_txt_TextChanged(object sender, EventArgs e)
        {
            tampilGrid();
        }

      
        private void Form1_Load(object sender, EventArgs e)
        { 
            tampilGrid();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (rekamMedis.apakahAda(rekammedis_txt.Text))
            {
                if (MessageBox.Show("Apakah Data akan Dihapus?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (rekamMedis.hapusData(rekammedis_txt.Text) > 0)
                    {
                        MessageBox.Show("Data Berhasil Dihapus.", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        rekammedis_txt.Text = "";
                        diagnosa_txt.Text = "";
                        rekammedis_txt.Focus();
                        pasien_combo.SelectedIndex = -1;
                        dokter_combo.SelectedIndex = -1;
                        kamar_combo.SelectedIndex = -1;
                        tampilGrid();
                    }
                    else
                    {
                        MessageBox.Show("Gagal menghapus data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Data tidak ditemukan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}

