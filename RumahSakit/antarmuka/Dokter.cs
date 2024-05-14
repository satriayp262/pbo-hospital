using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO_RS.antarmuka
{
    using model;
    public partial class Dokter : Form
    {
        DokterCls dokter = new DokterCls();
        public Dokter()
        {
            InitializeComponent();
        }

        private void Dokter_Load(object sender, EventArgs e)
        {
            bersihkan();
            tampilGrid();
            
        }

        void bersihkan()
        {
            kodeDktr_txt.Text= dokter.buatKode();
            namaDktr_txt.Clear();
            alamatDktr_txt.Clear();
            telp_txt.Clear();
            katrgotiDktr_txt.Clear();
        }
        private void Simpan_btn_Click(object sender, EventArgs e)
        {
            if (!dokter.apakahAda(kodeDktr_txt.Text))
            {
                dokter.setId_dr = kodeDktr_txt.Text;
                dokter.setNama_dr = namaDktr_txt.Text;
                dokter.setAlamat_dr = alamatDktr_txt.Text;
                dokter.setTelp_dr = telp_txt.Text;
                dokter.setKategori = katrgotiDktr_txt.Text;


                if (dokter.simpanData() > 0)
                {
                    MessageBox.Show("Data berhasil ditambahkan",
                  "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bersihkan();
                    kodeDktr_txt.Focus();
                    tampilGrid();
                }
                else
                {
                    MessageBox.Show("Data gagal ditambahkan",
                        "KESALAHAN", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    bersihkan();
                    kodeDktr_txt.Focus();
                }

            }
            else
            {
                if (MessageBox.Show("Apakah Data Akan Diubah", "KONFIRMASI",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dokter.setId_dr = kodeDktr_txt.Text;
                    dokter.setNama_dr = namaDktr_txt.Text;
                    dokter.setAlamat_dr = alamatDktr_txt.Text;
                    dokter.setTelp_dr = telp_txt.Text;
                    dokter.setKategori = katrgotiDktr_txt.Text;
                    if (dokter.ubahData(kodeDktr_txt.Text) > 0)
                    {
                        MessageBox.Show("Data Berhasil Diubah", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bersihkan();
                        kodeDktr_txt.Focus();
                        tampilGrid();
                    }
                    else
                    {
                        MessageBox.Show("Data Gagal Diubah", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bersihkan();
                        kodeDktr_txt.Focus();
                    }
                }
            }
        }

        void tampilGrid()
        {
            if (cari.Text == "")
            {
                tampilgrid.DataSource = dokter.tampilkanSemua();
            }
            else
            {
                tampilgrid.DataSource = dokter.cariDgNama(cari.Text);
            }
            belangBelang(tampilgrid);
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

        private void tampilgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow baris = this.tampilgrid.Rows[e.RowIndex];
                kodeDktr_txt.Text = baris.Cells[0].Value.ToString();
                namaDktr_txt.Text = baris.Cells[1].Value.ToString();
                alamatDktr_txt.Text = baris.Cells[2].Value.ToString();
                telp_txt.Text = baris.Cells[3].Value.ToString();
                katrgotiDktr_txt.Text = baris.Cells[4].Value.ToString();

            }
        }

        private void btnbatal_Click(object sender, EventArgs e)
        {
            bersihkan();
        }

        private void btnkeluar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void hps_btn_Click(object sender, EventArgs e)
        {
            if (dokter.apakahAda(kodeDktr_txt.Text))
            {
                if (MessageBox.Show("Apakah yakin akan dihapus",
                    "KONFIRMAASI", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (dokter.hapusData(kodeDktr_txt.Text) > 0)
                    {
                        MessageBox.Show("Data berhasil dihapus.",
                            "INFORMASI", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        bersihkan();
                        kodeDktr_txt.Focus();
                        tampilGrid();
                    }
                }
            }
        }

        private void cari_TextChanged(object sender, EventArgs e)
        {
            tampilGrid();
        }
    }
}

