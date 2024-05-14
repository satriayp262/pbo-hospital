using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using PBO_RS.model;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO_RS.antarmuka
{
    using model;
    public partial class PasienFrm : Form
    {
        PasienCls pasien = new PasienCls();
        public PasienFrm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void nama_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void laki_rbn_CheckedChanged(object sender, EventArgs e)
        {

        }
        void tampilData()
        {
            if (caritb.Text == "")
            {
                tampilGrid.DataSource = pasien.tampilkanSemua();
            }
            else
            {
                tampilGrid.DataSource = pasien.cariDgNama(caritb.Text);
            }
            belangBelang(tampilGrid);
        }
        void belangBelang(DataGridView dgv)
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
                        kolom.Style.BackColor = Color.LightGray;
                }
            }
        }
        private void PasienFrm_Load(object sender, EventArgs e)
        {
            isiComboGoldar();
            bersihkan();
            tampilData();
        }

        private void kodeps_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void GolDar_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Telp_txt_TextChanged(object sender, EventArgs e)
        {

        }
        void bersihkan()
        {

            kodeps_txt.Text=pasien.buatKode();
            nama_txt.Clear();
            alamat_txt.Clear();
            laki_rbn.Checked = false;
            perempuan_rbn.Checked = false;
            GolDar_cmb.SelectedIndex = -1;
            Telp_txt.Clear();
        }
       
        void isiComboGoldar()
        {
            GolDar_cmb.Items.Clear();
            GolDar_cmb.Items.Add("A+");
            GolDar_cmb.Items.Add("B+");
            GolDar_cmb.Items.Add("O+");
            GolDar_cmb.Items.Add("AB+");
            GolDar_cmb.Items.Add("A-");
            GolDar_cmb.Items.Add("B-");
            GolDar_cmb.Items.Add("O-");
            GolDar_cmb.Items.Add("AB-");
        }
            private void SIMPAN_Click(object sender, EventArgs e)
        {
            if (!pasien.apakahAda(kodeps_txt.Text))
            {
                pasien.KodePasien = kodeps_txt.Text;
                pasien.NamaPasien = nama_txt.Text;
                pasien.AlamatPasien = alamat_txt.Text;
                pasien.JenisKel = laki_rbn.Checked ? "Laki-laki" : "Perempuan";
                pasien.Goldar = GolDar_cmb.Text;
                pasien.TelpPasien = Telp_txt.Text;

                
                if (pasien.tambahPasien() > 0)
                {
                    MessageBox.Show("Data berhasil ditambahkan",
                  "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bersihkan();
                    kodeps_txt.Focus();
                    tampilData();
                }
                else
                {
                    MessageBox.Show("Data gagal ditambahkan",
                        "KESALAHAN", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    bersihkan();
                    kodeps_txt.Focus();
                }

            }
            else
            {
                if (MessageBox.Show("Apakah Data Akan Diubah", "KONFIRMASI",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    pasien.KodePasien = kodeps_txt.Text;
                    pasien.NamaPasien = nama_txt.Text;
                    pasien.AlamatPasien = alamat_txt.Text;
                    pasien.JenisKel = laki_rbn.Checked ? "Laki-laki" : "Perempuan";
                    pasien.Goldar = GolDar_cmb.Text;
                    pasien.TelpPasien = Telp_txt.Text;
                    if (pasien.ubah(kodeps_txt.Text) > 0)
                    {
                        MessageBox.Show("Data Berhasil Diubah", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bersihkan();
                        kodeps_txt.Focus();
                        tampilData();
                    }
                    else
                    {
                        MessageBox.Show("Data Gagal Diubah", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bersihkan();
                        kodeps_txt.Focus();
                    }
                }
            }


        }


        private void tampilGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    

    private void tampilGrid_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            DataGridViewRow baris = this.tampilGrid.Rows[e.RowIndex];
            kodeps_txt.Text = baris.Cells[0].Value.ToString();
            nama_txt.Text = baris.Cells[1].Value.ToString();
            alamat_txt.Text = baris.Cells[2].Value.ToString();
            laki_rbn.Checked = baris.Cells[3].Value.ToString() == "Laki-laki" ? true : false;
            perempuan_rbn.Checked = baris.Cells[3].Value.ToString() == "Perempuan" ? true : false;
            GolDar_cmb.Text = baris.Cells[4].Value.ToString();
            Telp_txt.Text = baris.Cells[5].Value.ToString();

        }
    }
    private void hps_btn_Click(object sender, EventArgs e)
        {
            if (pasien.apakahAda(kodeps_txt.Text))
            {
                if (MessageBox.Show("Apakah yakin akan dihapus",
                    "KONFIRMAASI", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (pasien.hapus(kodeps_txt.Text) > 0)
                    {
                        MessageBox.Show("Data berhasil dihapus.",
                            "INFORMASI", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        bersihkan();
                        kodeps_txt.Focus();
                        tampilData ();
                    }
                }
            }
        }

        private void batal_btn_Click(object sender, EventArgs e)
        {
            bersihkan();
        }

        private void tutup_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void caritb_TextChanged(object sender, EventArgs e)
        {
            tampilData();
        }
    }
}
