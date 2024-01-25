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
    public partial class frmMusteri : Form
    {
        private bool isNewRecord = false; //formun içerisinde yeni kayıt mı yapıcam güncelleyecek miyim onu ayırt etmem için dışarıdan değişken tanmımlamam gerekti

        private Musteri musteri;
        public frmMusteri(bool isNewRecord, Musteri musteri)
        {
            InitializeComponent();
            this.isNewRecord = isNewRecord;
            this.musteri = musteri;
        }

        //SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthwindContext"].ToString());

        private void frmMusteri_Load(object sender, EventArgs e)
        {
            if (!isNewRecord) //Yeni bir kayıt değilse
            {
                txtCustomerID.Enabled = false;

                txtCustomerID.Text = musteri.CustomerID;
                txtCompanyName.Text = musteri.CompanyName;
                txtContactName.Text = musteri.ContactName;
                txtCity.Text = musteri.City;
                txtCountry.Text = musteri.Country;
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            musteri.CustomerID = txtCustomerID.Text;
            musteri.ContactName = txtContactName.Text;
            musteri.CompanyName = txtCompanyName.Text;
            musteri.City = txtCity.Text;
            musteri.Country = txtCountry.Text;

            if (isNewRecord)
            {
                SqlCommand cmdControl = new SqlCommand("select count(*) from dbo.Customers where CustomerID = @CustomerID", MyConnection.Connection);
                cmdControl.Parameters.AddWithValue("CustomerID", txtCustomerID.Text);
                MyConnection.Connection.Open();

                int rowCount = (int)cmdControl.ExecuteScalar();
                MyConnection.Connection.Close();
                if (rowCount == 0)
                {
                    MusteriMetotlari.KayitEkle(musteri);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Girilen CustomerID değeri zaten kayıtlı.\nLütfen farklı bir ID girin");
                }

            }
            else
            {
                //update cümlesi çalıştırılacak

                MusteriMetotlari.Guncelle(musteri);
                this.Close();
            }
        }

        private void frmMusteri_KeyDown(object sender, KeyEventArgs e) //KEydown tuşa basılınca çalışıyor elinş çektikten sonra KEyPress Elini çekmeden tetikleniyor
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnKaydet_Click(btnKaydet, null);
            }
            else if (e.KeyCode == Keys.Escape)
                btnVazgec_Click(btnVazgec, null);

        }
    }
}
