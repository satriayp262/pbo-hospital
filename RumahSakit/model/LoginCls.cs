using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PBO_RS.model
{
    using konfigurasi;
    class LoginCls
    {
        LayananCls server;
        DataTable temp; string Query;

        public LoginCls()
        {
            server = new LayananCls();
            temp = new DataTable();
            Query = "";
        }

        public bool apakahAda(string uid, string pwd)
        {
            bool cek = false;
            Query = "select * from user where user_id='" + uid + "' and " +
                "password='" + pwd + "'";
            temp = server.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                cek = true;
            }

            return cek;
        }
    }
}
