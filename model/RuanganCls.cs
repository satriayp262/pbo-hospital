using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumahSakit.model
{
    using konfigurasi;
    using System.Data;

    internal class RuanganCls
    {
        string kode_ruangan;
        string nama_ruangan;
        string status_ruangan;

        LayananCls server;
        string Query;
        DataTable temp;


        public RuanganCls()
            {
                kode_ruangan = "";
                nama_ruangan = "";
                status_ruangan = "";
                server = new LayananCls();
                temp = new DataTable();
                Query = "";
            }

        public string setkode_ruangan
        {
            set { kode_ruangan = value; }
        }


        public string setnama_ruangan
        {
            set { nama_ruangan = value; }
        }


        public string setstatus_ruangan
        {
            set { status_ruangan = value; }
        }

        public bool apakahAda(string kode)
        {
            bool cek = false;
            Query = "select * from kamar where no_kmr ='" + kode + "'";
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

            Query = "insert into kamar (no_kmr, nama_kmr, status_kmr) values('" + kode_ruangan + "', " +
                "'" + nama_ruangan + "', '" + status_ruangan + "')";

            try
            {
                // Eksekusi kueri menggunakan objek server
                result = server.eksekusiNonQuery(Query);
                if (result < 0)
                {
                    throw new Exception("Gagal menyimpan data");
                }
            }
            catch (Exception e) { }

            return result;
        }

        public int ubahData(string kode)
        {
            int result = -1;

            Query = "update kamar set nama_kmr='" + nama_ruangan + "', status_kmr='" + status_ruangan + "' where no_kmr='" + kode + "'";

            try
            {
                result = server.eksekusiNonQuery(Query);
                if (result < 0)
                {
                    throw new Exception("Gagal mengubah data");
                }
            }
            catch (Exception e) { }

            return result;
        }

        public int hapusData(string kode)
        {
            int result = -1;

            Query = "delete from kamar where no_kmr='" + kode + "'";

            try
            {
                result = server.eksekusiNonQuery(Query);
                if (result < 0)
                {
                    throw new Exception("Gagal menghapus data");
                }
            }
            catch (Exception e) { }

            return result;
        }

        public DataTable tampilSemua()
        {
            Query = "select * from kamar";

            return server.eksekusiQuery(Query);
        }


        public string buatKode()
        {
            string kode = "";
            int nilai = 0;

            Query = "SELECT IFNULL(MAX(no_kmr),0)+1 AS kode FROM kamar";

            temp = server.eksekusiQuery(Query);

            if (temp.Rows.Count > 0)
            {
                foreach (DataRow data in temp.Rows)
                {
                    nilai = Convert.ToInt32(data[0]);
                }
                if (nilai > 0 && nilai < 10)
                {
                    kode = "00" + nilai.ToString();
                }
                else if (nilai >= 10 && nilai < 100)
                {
                    kode = nilai.ToString();
                }
            }
            return kode;
        }


        public DataTable cariDgNama(string nama)
        {
            Query = "select * from kamar where nama_kmr like '%" + nama + "%'";
            return server.eksekusiQuery(Query);
        }


        public bool getStatusKamar(string noRuangan)
        {
            // Query untuk mengecek apakah kamar sudah terisi
            Query = "select count(*) from rekam_medis where no_kmr = '" + noRuangan + "'";

            // Eksekusi query
            int count = Convert.ToInt32(server.eksekusiQuery(Query).Rows[0][0]);

            // Jika ada data di tabel medis dengan no ruangan yang sama
            // Maka status kamar dianggap penuh
            if (count > 0)
                return false; // Kamar terisi
            else
                return true; // Kamar kosong
        }




    }
}
