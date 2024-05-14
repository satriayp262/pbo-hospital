using RumahSakit.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RumahSakit.antarmuka
{
    public partial class RuanganForm : Form
    {
        RuanganCls ruangan = new RuanganCls();
        public RuanganForm()
        {
            InitializeComponent();
        }

        private void simpan_btn_Click(object sender, EventArgs e)
        {
            if (!ruangan.apakahAda(kode_kmr_txt.Text))
            {
                ruangan.setkode_ruangan = kode_kmr_txt.Text;
                ruangan.setnama_ruangan = nama_kmr_txt.Text;
                ruangan.setstatus_ruangan = status_cb.Text;


                if (ruangan.simpanData() > 0)
                {
                    MessageBox.Show("Data berhasil disimpan.",
                        "INFORMASI", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    bersihkan();
                    kode_kmr_txt.Focus();
                    tampilGrid();
                }
                else
                {
                    MessageBox.Show("Data gagal disimpan.",
                        "INFORMASI", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    bersihkan();
                    kode_kmr_txt.Focus();
                    tampilGrid();
                }
            }
            else
            {
                if (MessageBox.Show("Apakah data akan diubah?",
                    "KONFIRMASI", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ruangan.setkode_ruangan = kode_kmr_txt.Text;
                    ruangan.setnama_ruangan = nama_kmr_txt.Text;
                    ruangan.setstatus_ruangan = status_cb.Text;
                    if (ruangan.ubahData(kode_kmr_txt.Text) > 0)
                    {
                        MessageBox.Show("Data berhasil diubah.",
                            "INFORMASI", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        bersihkan();
                        kode_kmr_txt.Focus();
                        tampilGrid();
                    }
                    else
                    {
                        MessageBox.Show("Data gagal diubah.",
                            "INFORMASI", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        bersihkan();
                        kode_kmr_txt.Focus();
                        tampilGrid();
                    }
                }

            }
        }


        private void hapus_btn_Click(object sender, EventArgs e)
        {
            if (ruangan.apakahAda(kode_kmr_txt.Text))
            {
                if (MessageBox.Show("Apakah yakin akan dihapus?",
                    "KONFIRMASI", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ruangan.hapusData(kode_kmr_txt.Text) > 0)
                    {
                        MessageBox.Show("Data berhasil dihapus.",
                                "INFORMASI", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        bersihkan();
                        kode_kmr_txt.Focus();
                        tampilGrid();
                    }
                }
            }
        }

        private void batal_btn_Click(object sender, EventArgs e)
        {
            bersihkan();
            nama_kmr_txt.Clear();
            nama_kmr_txt.Focus();
            status_cb.SelectedIndex = -1;
        }

        private void tutup_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        void bersihkan()
        {
            kode_kmr_txt.Text = ruangan.buatKode();
            nama_kmr_txt.Clear();
            nama_kmr_txt.Focus();
            status_cb.SelectedIndex = -1;
        }

        void tampilGrid()
        {
            if (cari_txt.Text == "")
            {
                ruangan_dgv.DataSource = ruangan.tampilSemua();
            }
            else
            {
                ruangan_dgv.DataSource = ruangan.cariDgNama(cari_txt.Text);
            }
            belangBelang(ruangan_dgv);
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
                    {
                        kolom.Style.BackColor = Color.LightGray; //boleh tidak pake kurung kurawal jika hanya satu perintah yang dieksekusi
                    }
                }
            }
        }


        private void RuanganForm_Load(object sender, EventArgs e)
        {
            tampilGrid();
            bersihkan();
        }

        private void cari_txt_TextChanged(object sender, EventArgs e)
        {
            tampilGrid();
        }

        private void ruangan_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow baris = this.ruangan_dgv.Rows[e.RowIndex];
            kode_kmr_txt.Text = baris.Cells[0].Value.ToString();
            nama_kmr_txt.Text = baris.Cells[1].Value.ToString();
            status_cb.Text = baris.Cells[2].Value.ToString();
        }
    }
}
