using MySql.Data.MySqlClient;
using Rekam_Medis.konfigurasi;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekam_Medis.model
{
    class RekamMedisCls
    {
        private string id_rekammedis;
        private string diagnosa;
        private string id_dr;
        private string id_psn;
        private string no_kmr;

        LayananCls server;
        DataTable temp;
        string Query;

        public RekamMedisCls()
        {
            id_rekammedis = "";
            diagnosa = "";
            id_dr = "";
            id_psn = "";
            no_kmr = "";

            server = new LayananCls();
            temp = new DataTable();
            Query = "";
        }

        public string setIdRekamMedis
        {
            set { id_rekammedis = value; }
        }

        public string setDiagnosa
        {
            set { diagnosa = value; }
        }

        public string setIdDokter
        {
            set { id_dr = value; }
        }

        public string setIdPasien
        {
            set { id_psn = value; }
        }

        public string setNoKamar
        {
            set { no_kmr = value; }
        }

        public DataTable tampilkanSemua()
        {
            Query = @"
            SELECT 
            rm.id_rm,
            p.nama_psn,
            d.nama_dr,
            rm.no_kmr,
            rm.diagnosa
            FROM rekam_medis rm
            JOIN pasien p ON rm.id_psn = p.id_psn
            JOIN dokter d ON rm.id_dr = d.id_dr
            JOIN kamar k ON rm.no_kmr = k.no_kmr";
            return server.eksekusiQuery(Query);
        }
        public DataTable cariNama(string identitas)
        {
            Query = @"
            SELECT 
            rm.id_rm,
            p.nama_psn,
            d.nama_dr,
            rm.no_kmr,
            rm.diagnosa
            FROM rekam_medis rm
            JOIN pasien p ON rm.id_psn = p.id_psn
            JOIN dokter d ON rm.id_dr = d.id_dr
            JOIN kamar k ON rm.no_kmr = k.no_kmr
            WHERE rm.id_rm LIKE '%" + identitas + "%' OR " +
            "p.nama_psn LIKE '%" + identitas + "%' OR " +
            "d.nama_dr LIKE '%" + identitas + "%' OR " +
            "rm.no_kmr LIKE '%" + identitas + "%' OR " +
            "rm.diagnosa LIKE '%" + identitas + "%'";

            return server.eksekusiQuery(Query);
        }

        public int simpanData()
        {
            int result = -1;

            Query = "INSERT INTO rekam_medis (id_rm, id_psn, id_dr, no_kmr, diagnosa) VALUES ('" + id_rekammedis + "','" + id_psn + "','" + id_dr + "','" + no_kmr + "','" + diagnosa + "')";
            try
            {
                result = server.eksekusiNonQuery(Query);
                if (result < 0)
                {
                    throw new Exception("Gagal Menyimpan");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return result;
        }

        public int ubahData(string id, string diagnosa, string idPasien, string idDokter, string noKamar)
        {
            int result = -1;

            
            Query = @"UPDATE rekam_medis SET diagnosa 
                    = '" + diagnosa + "', id_psn = '" + idPasien + "', " +
                    "id_dr = '" + idDokter + "', no_kmr = '" + noKamar + "' " +
                    "WHERE id_rm = '" + id + "'";
            try
            {
                // Eksekusi query
                result = server.eksekusiNonQuery(Query);
                if (result < 0)
                {
                    throw new Exception("Gagal Menyimpan");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return result;
        }


        public DataTable GetPasienData()
        {
            DataTable pasienData = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(server.GetConnectionString()))
            {
                string query = "SELECT id_psn, nama_psn FROM pasien";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            pasienData.Load(reader);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            return pasienData;
        }

        public DataTable GetDokterData()
        {
            DataTable dokterData = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(server.GetConnectionString()))
            {
                string query = "SELECT id_dr, nama_dr FROM dokter";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            dokterData.Load(reader);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            return dokterData;
        }

        public DataTable GetKamarData()
        {
            DataTable kamarData = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(server.GetConnectionString()))
            {
                string query = "SELECT no_kmr FROM kamar";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            kamarData.Load(reader);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            return kamarData;
        }

        public bool apakahAda(string id)
        {
            bool cek = false;

            Query = "select * from rekam_medis where id_rm='" + id + "'";
            temp = server.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;

        }

        public DataTable GetRekamMedisKamarData()
        {
            DataTable rekamData = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(server.GetConnectionString()))
            {
                string query = "SELECT no_kmr FROM rekam_medis";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            rekamData.Load(reader);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            return rekamData;
        }
        public int hapusData(string id)
        {
            int result = 0;
            string query = "DELETE FROM rekam_medis WHERE id_rm = @id";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(server.GetConnectionString()))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        result = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return result;
        }


    }
}
