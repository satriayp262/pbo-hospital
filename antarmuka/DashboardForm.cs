using RumahSakit.antarmuka;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RumahSakit
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void ruanganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RuanganForm ruangan = new RuanganForm();
            ruangan.ShowDialog();
        }
    }
}
