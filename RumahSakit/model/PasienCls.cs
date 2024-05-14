using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PBO_RS.model
{
    using konfigurasi;
    class PasienCls
    {
        private string _kode_pasien;
        private string _nama_pasien;
        private string _alamat_pasien;
        private string _jns_kel_pasien;
        private string gol_dar;
        private string telp_pasien;

        KonfigurasiCls konfigDB;
        DataTable temp;
        string Query = "";


        public PasienCls()
        {
            _kode_pasien = "";
            _nama_pasien = "";
            _alamat_pasien = "";
            _jns_kel_pasien = "";
            gol_dar = "";
            telp_pasien = "";

            konfigDB = new LayananCls();
            temp = new DataTable();
            Query = "";
        }
        //Property
        public string KodePasien
        {
            set { _kode_pasien = value; }
            //get { return _kode_pasien; }
        }

        public string NamaPasien
        {
            set { _nama_pasien = value; }
        }

        public string AlamatPasien {
            set { _alamat_pasien = value; }
        }

        public string JenisKel
        {
            set { _jns_kel_pasien = value; }
        }

        public string Goldar
        {
            set { gol_dar = value; }
        }

        public string TelpPasien
        {
            set { telp_pasien = value; }
        }

        //Methode
        public bool apakahAda(string kode)
        {
            bool cek = false;
            Query = "select * from pasien where id_psn='" + kode + "'";
            temp = konfigDB.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }

            
        public int tambahPasien()
        {
            int result = -1;
            Query = "INSERT INTO pasien (id_psn, nama_psn, alamat_psn, kelamin_psn, gol_dar, telp_psn) VALUES ('" + _kode_pasien + "', '" + _nama_pasien + "', '" + _alamat_pasien + "', '" + _jns_kel_pasien + "', '" + gol_dar + "', '" + telp_pasien + "')";
            try
            {
                result = konfigDB.eksekusiNonQuery(Query);
                if (result < 0)
                {
                    throw new Exception("Gagal menambahkan data pasien");
                }
            }
            catch (Exception e)
            {
                
            }
            return result;
        }

        public int ubah(string kode)
        {
            int result = -1;
            Query = "UPDATE pasien SET nama_psn = '" + _nama_pasien + "', alamat_psn = '" + _alamat_pasien + "', kelamin_psn = '" + _jns_kel_pasien + "', gol_dar = '" + gol_dar + "', telp_psn = '" + telp_pasien + "' WHERE id_psn = '" + kode + "'";
            try
            {
                result = konfigDB.eksekusiNonQuery(Query);
                if (result < 0)
                {
                    throw new Exception("Proses ubah data pasien gagal");
                }
            }
            catch (Exception e)
            {

            }
            return result;
        }

        public int hapus(string kode)
        {
            int result = -1;
            Query = "delete from pasien where id_psn='" +
                kode + "'";
            try
            {
                result = konfigDB.eksekusiNonQuery(Query);
                if (result < 0)
                {
                    throw new Exception("Proses ubah data pasien gagal");
                }
            }
            catch (Exception e)
            {

            }
            return result;
        }

        public string buatKode()
        {
            string kode = "";
            int nilai = 0;
            Query = "SELECT IFNULL (MAX(id_psn),0)+1 AS kode FROM pasien";
            temp = konfigDB.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                foreach (DataRow data in temp.Rows)
                {
                    nilai = Convert.ToInt32(data[0]);
                }
                if (nilai > 0 && nilai < 10)
                {
                    kode = "000" + nilai.ToString();
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
            Query = "select * from pasien where nama_dr like '%" + nama + "%'";
            return konfigDB.eksekusiQuery(Query);
        }

        public DataTable tampilkanSemua()//fungsi menampilkan data pasien
        {
            Query = "select * from pasien";
            return konfigDB.eksekusiQuery(Query);
        }

    }

    }

