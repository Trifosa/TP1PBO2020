using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)     // Yang akan terjadi ketika tombol login diklik
        {
            Login lgn = new Login();

            // Mengambil username dan password dari form
            lgn.username = Convert.ToString(tbName.Text);
            lgn.pass = Convert.ToString(tbPass.Text);

            if (String.Equals(lgn.pass, "pbo123"))
            {
                // Jika password yang dimasukkan user sama dengan pbo123
                this.Hide();
                Form kedua = new MenuUtama();
                kedua.Show();
            }       
            else
                MessageBox.Show("Maaf, password atau Username anda salah", "Warning!!!");
        }
    }
}
