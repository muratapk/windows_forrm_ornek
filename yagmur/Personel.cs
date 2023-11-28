using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace yagmur
{
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            string cumle = "insert into personel (kul,sifre) values ('"+ txtkul.Text + "','"+ txtsifre.Text+"')";
            crud islem = new crud();
            islem.openConnection();
            int sonuc = islem.sorgu(cumle);
            if (sonuc == 1)
            {
                MessageBox.Show("Kaydınız Eklenmiştir");
            }
            else
            {
                MessageBox.Show("Kayıt Eklenmedi");
            }
            islem.closeConnection();
            doldur();
            temizle();

        }
        void doldur()
        {
            crud dosya = new crud();
            dosya.openConnection();
            string cumle = "Select * from personel";
            dosya.cmd = new SqlCommand(cumle, dosya.con);
            dosya.da = new SqlDataAdapter(dosya.cmd);
            dosya.ds = new DataSet();
            dosya.da.Fill(dosya.ds);
            dataGridView1.DataSource = dosya.ds.Tables[0];

            dosya.closeConnection();
        }

        private void Personel_Load(object sender, EventArgs e)
        {
            doldur();
        }
        void temizle()
        {
            txtkul.Text = "";
            txtsifre.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sira=dataGridView1.CurrentCell.RowIndex;
            txtkul.Text = dataGridView1.Rows[sira].Cells[1].Value.ToString();
            txtsifre.Text = dataGridView1.Rows[sira].Cells[2].Value.ToString();
            textBox1.Text= dataGridView1.Rows[sira].Cells[0].Value.ToString();
        }
    }
}
