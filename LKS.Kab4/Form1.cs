using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS.Kab4
{
    public partial class Form1 : Form
    {
        Koneksi konn = new Koneksi();
        private SqlCommand cmd;
        private SqlDataReader rd;
        public static string Username;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = konn.Getconn();
            con.Open();
            cmd = new SqlCommand("select * from tbAdmin where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'", con);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                Username = textBox1.Text;
                MainMenu A = new MainMenu();
                A.Show();
                this.Hide();
                MessageBox.Show("Selamat Datang " + textBox1.Text);
            }
            else
            {
                MessageBox.Show("Password/Username Salah!!!");
            }
            rd.Close();
            con.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) 
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }
    }
}
