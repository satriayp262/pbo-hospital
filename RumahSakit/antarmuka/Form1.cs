using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using PBO_RS.antarmuka;
using PBO_RS.model;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO_RS
{
    
    public partial class login : Form
    {
        LoginCls Login = new LoginCls();
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uid = userid_txt.Text;
            string pwd = password_txt.Text;
            LoginCls loginCls = new LoginCls();
            if (Login.apakahAda(userid_txt.Text, password_txt.Text))
            {
                PasienFrm Pasien = new PasienFrm();
                Pasien.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Maaf, User ID/ Password Anda Salah.", "" +
                    "KESALAHAN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                userid_txt.SelectAll();
                password_txt.SelectAll();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
