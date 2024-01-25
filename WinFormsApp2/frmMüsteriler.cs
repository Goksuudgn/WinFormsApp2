using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class frmMüsteriler : Form
    {
        public frmMüsteriler()
        {
            InitializeComponent();
        }

        //string connectionString = "server = GOKSU\\SQLEXPRESS; database = Northwind; Trusted_Connection = true;";
        //string connectionString1 = "server = GOKSU\\SQLEXPRESS; database = Northwind ;uid = GOKSU//goksu; pwd = Goksu729659;";


        private void frmMüsteriler_Load(object sender, EventArgs e)
        {
            ////SqlCommand sqlCommand = new SqlCommand("", connection);
            //SqlCommand sqlCommand = new SqlCommand("", connection);
            //sqlCommand.Connection = connection;
            //SqlCommand.CommandType = CommandType.StoredProcedure; //eğer ki store procedure tetikleyeceksek
            //sqlCommand.CommandText = "select CustomerID, CompanyName, ContactName, City, Country from dbo.Customers order by CompanyName";
            //connection.Open();

            //SqlDataReader reader = sqlCommand.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Columns.Add("CustomerID");
            //dt.Columns.Add("CompanyName");
            //dt.Columns.Add("ContactName");
            //dt.Columns.Add("City");
            //dt.Columns.Add("Country");

            //while (reader.Read())
            //{
            //    dt.Rows.Add(reader["CustomerID"] , reader["CompanyName"], reader["ContactName"], reader["City"], reader["Country"]);
            //}
            //reader.Close();
            //connection.Close();


            SqlDataAdapter da = new SqlDataAdapter("select top 20 CustomerID, CompanyName, ContactName, City, Country from dbo.Customers order by CompanyName", MyConnection.Connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridList.DataSource = dt;



            //DataSet dataSet = new DataSet(); // eğer ki sorgu sonucunda birden fazla tablo dönecek isek DataSet sınıfı kullnaılır
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            //string sql = "select CustomerID, CompanyName, ContactName, City, Country from dbo.Customers where CompanyName like '%" + txtAra.Text + "%' order by CompanyName";
            //string sql = "select CustomerID, CompanyName, ContactName, City, Country from dbo.Customers where CompanyName = '" + txtAra.Text + "'";
            string sql = "select CustomerID, CompanyName, ContactName, City, Country from dbo.Customers where CompanyName like '%' + @param1 + '%' order by CompanyName";

            //string sql = "select CustomerID, CompanyName, ContactName, City, Country from dbo.Customers where CompanyName = '"+ txtAra.Text + "'";

            SqlDataAdapter da = new SqlDataAdapter(sql, MyConnection.Connection);
            //da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("param1", txtAra.Text);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridList.DataSource = dt;

        }

        private void txtAra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnAra_Click(btnAra, null);
            }
        }

        private void menuItemSil_Click(object sender, EventArgs e)
        {
            if (gridList.SelectedRows.Count == 0)
                return;

            Musteri musteri = MusteriMetotlari.Getir(gridList.CurrentRow.Cells[0].Value.ToString());

            frmMusteriSil frm = new frmMusteriSil(musteri);
            frm.ShowDialog();
            VerileriListele();
        }

        private void menuItemDuzenle_Click(object sender, EventArgs e)
        {
            if (gridList.SelectedRows.Count == 0)
                return;

            Musteri musteri = MusteriMetotlari.Getir(gridList.CurrentRow.Cells[0].Value.ToString());

            if (string.IsNullOrEmpty(musteri.CustomerID))
            {
                MessageBox.Show($"{gridList.CurrentRow.Cells[0].Value} ID'li kayıt bulunamadı..");
                return;
            }

            frmMusteri frmMusteri = new frmMusteri(false, musteri);
            frmMusteri.ShowDialog();
            VerileriListele();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            frmMusteri frmMusteri = new frmMusteri(true, new Musteri());
            frmMusteri.ShowDialog();
            VerileriListele();
        }
        private void VerileriListele()
        {
            //if (txtAra.TextLength == 0)
            if (string.IsNullOrEmpty(txtAra.Text))
                frmMüsteriler_Load(this, null);
            else
                btnAra_Click(btnAra, null);
        }
    }

}
