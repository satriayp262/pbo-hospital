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
   
    public partial class splash : Form
    {
        byte count = 0;
        public splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;

            if (count == 6)
            {
                timer1.Enabled = false;
                login login = new login();
                login.Show();
                this.Hide();
            }

        }
    }
}
