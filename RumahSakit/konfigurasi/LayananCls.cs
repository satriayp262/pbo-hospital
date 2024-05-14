using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using MySql.Data.MySqlClient;


namespace RumahSakit.konfigurasi
{
    class LayananCls:KonfigurasiCls
    {
        MySqlConnection mCon;
        MySqlCommand mCom;
        MySqlDataAdapter mAdP;

        string link = "server=localhost;port=3306;database=rumah_sakit;uid=root;pwd=";



        //constructor
        public LayananCls()
        {
            //mengkoneksikan dengan server
            mCon = new MySqlConnection(link);
            //memberikan perintah
            mCom = new MySqlCommand();
            //menampung data hasil select
            mAdP = new MySqlDataAdapter();
        }


        //method untuk membuka dan menutup koneksi
        void bukaKoneksi()
        {
            try
            {
                if (mCon.State == ConnectionState.Closed)
                {
                    mCon.Open();
                }
            }
            catch (Exception e) { }
        }

        void tutupKoneksi()
        {
            mCon.Close();
        }

        //untuk eksekusi insert update delete
        public override int eksekusiNonQuery(string query)
        {
            //throw new NotImplementedException();

            int result = -1;

            try
            {
                //koneksi dibuka terlebih dahulu
                bukaKoneksi();
                mCom.Connection = mCon;
                mCom.CommandText = query;
                result = mCom.ExecuteNonQuery();
            }
            //catch (Exception e) { }

            finally
            {
                tutupKoneksi();
            }

            return result;
        }

        //untuk mengeksekusi select
        public override DataTable eksekusiQuery(string query)
        {
            //throw new NotImplementedException(); bisa dihilangkan
            DataTable result = new DataTable();

            try
            {
                //koneksi dibuka terlebih dahulu
                bukaKoneksi();
                mCom.Connection = mCon;
                mCom.CommandText = query; //select ditampung (isi sql)
                mAdP.SelectCommand = mCom;
                mAdP.Fill(result); //(akan diisikan ke result)
            }
            catch (Exception e) { }

            finally
            {
                tutupKoneksi();
            }

            return result;
        }
    }
}
