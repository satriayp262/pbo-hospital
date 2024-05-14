using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumahSakit.konfigurasi
{
    abstract class KonfigurasiCls
    {
        //untuk menangani instruksi select
        public abstract DataTable eksekusiQuery(string query);

        //untuk menangai instruksi insert, update, delete
        public abstract int eksekusiNonQuery(string query);
    }
}
