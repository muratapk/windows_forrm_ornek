using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace yagmur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ayak;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into musteri (adi,ilcesi,cep) values (@adi,@ilcesi,@cep)",con);
            cmd.Parameters.AddWithValue("@adi", txtadi.Text);
            cmd.Parameters.AddWithValue("@ilcesi", txtilce.Text);
            cmd.Parameters.AddWithValue("@cep", txtcep.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kaydınız Eklenmiştir");
            doldur();
            con.Close();
            temizle();
        }
        void doldur()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ayak;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from musteri", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            doldur();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sira = dataGridView1.CurrentRow.Index;
            txtId.Text = dataGridView1.Rows[sira].Cells[0].Value.ToString();
            txtadi.Text = dataGridView1.Rows[sira].Cells[1].Value.ToString();
            txtilce.Text= dataGridView1.Rows[sira].Cells[2].Value.ToString();
            txtcep.Text = dataGridView1.Rows[sira].Cells[3].Value.ToString();
        }

        private void btnduzelt_Click(object sender, EventArgs e)
        {
            int Id =Convert.ToInt16(txtId.Text);
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ayak;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update musteri set adi=@adi,ilcesi=@ilcesi,cep=@cep where Id=@Id",con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@adi", txtadi.Text);
            cmd.Parameters.AddWithValue("@ilcesi", txtilce.Text);
            cmd.Parameters.AddWithValue("@cep", txtcep.Text);
            cmd.Parameters.AddWithValue("@Id", txtId.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kaydınız Düzeltilmiştir");
            doldur();
            con.Close();
            temizle();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult cevap=MessageBox.Show("Bu Kaydı Silmek İstiyor musunuz?","Dikkat",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {

                int Id = Convert.ToInt16(txtId.Text);
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ayak;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from musteri where Id=@Id", con);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Id", txtId.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kaydınız Silinmiştir");
                doldur();
                con.Close();
                temizle();
            }
            else
            {
                MessageBox.Show("Silme İşlemi İptal Edilmiştir");
            }
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ayak;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from musteri where adi=@adi", con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@adi", txtadi.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        void temizle()
        {
            txtadi.Text = "";
            txtilce.Text = "";
            txtcep.Text = "";
        }
    }
}
