using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PBO_RS.model
{
    using konfigurasi;
    class DokterCls
    {
        private string _id_dr;
        private string _nama_dr;
        private string _alamat_dr;
        private string _telp_dr;
        private string _kategori;
        LayananCls server;
        DataTable temp;
        string Query;
        public DokterCls()
        {
            _id_dr = "";
            _nama_dr = "";
            _alamat_dr = "";
            _telp_dr = "";
            _kategori = "";
            server = new LayananCls();
            temp = new DataTable();
            Query = "";
        }

        public string setId_dr
        {
            set { _id_dr = value; }

        }
        public string setNama_dr
        {
            set { _nama_dr = value; }
        }

        public string setAlamat_dr
        {
            set { _alamat_dr = value; }
        }

        public string setTelp_dr
        {
            set { _telp_dr = value; }
        }

        public string setKategori
        {
            set { _kategori = value; }
        }

        public bool apakahAda(string kode)
        {
            bool cek = false;
            Query = "select * from dokter where id_dr ='" + kode + "'";
            temp = server.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }

        public int simpanData()
        {
            int result = -1;
            Query = "insert into dokter values ('" + _id_dr + "','" + _nama_dr + "','" + _alamat_dr + "','" + _telp_dr + "','" + _kategori + "')";

            try
            {
                result = server.eksekusiNonQuery(Query);
                if (result < 0)
                {
                    throw new Exception("Gagal menyimpan :");
                }
            }
            catch (Exception e)
            { }
            return result;
        }

        public int ubahData(string kode)
        {

            int result = -1;
            Query = "update dokter set nama_dr='" +
                  _nama_dr + "',alamat_dr='" +
                  _alamat_dr + "',telp_dr='" +
                  _telp_dr + "',kategori='" +
                  _kategori + "' where id_dr='" +
                  kode + "'";
            try
            {
                result = server.eksekusiNonQuery(Query);
                if (result < 0)
                {
                    throw new Exception("Gagal Mengedit Data :");
                }
            }
            catch (Exception e)
            { }
            return result;
        }

        public int hapusData(string kode)
        {
            int result = -1;
            Query = "delete from dokter where id_dokter='" +
                kode + "'";

            try
            {
                result = server.eksekusiNonQuery(Query);
                if (result < 0)
                {
                    throw new Exception("Gagal menghapus data.");
                }
            }
            catch (Exception e) { }
            return result;
        }
        public DataTable cariDgNama(string nama)
        {
            Query = "select * from dokter where nama_dr like '%" + nama + "%'";
            return server.eksekusiQuery(Query);
        }

        public string buatKode()
        {
            string kode = "";
            int nilai = 0;
            Query = "SELECT IFNULL (MAX(id_dr),0)+1 AS kode FROM dokter";
            temp = server.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                foreach (DataRow data in temp.Rows)
                {
                    nilai = Convert.ToInt32(data[0]);
                }
                if (nilai > 0 && nilai < 10)
                {
                    kode = "0" + nilai.ToString();
                }
                else if (nilai >= 10 && nilai < 100)
                {
                    kode = nilai.ToString();
                }
            }
            return kode;

        }

        public DataTable tampilkanSemua()
        {
            Query = "select * from dokter";
            return server.eksekusiQuery(Query);
        }
    }
}