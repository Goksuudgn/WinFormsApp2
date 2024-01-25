using System.Data.SqlClient;
using System.Data;

namespace WinFormsApp2
{
    public static class MusteriMetotlari
    {
        public static void KayitEkle(Musteri musteri)
        {
            SqlCommand cmd = new SqlCommand("insert into dbo.Customers (CustomerID, CompanyName, ContactName, City, Country) values (@CustomerID, @CompanyName, @ContactName, @City, @Country)", MyConnection.Connection);
            cmd.Parameters.AddWithValue("CustomerID", musteri.CustomerID);
            cmd.Parameters.AddWithValue("CompanyName", musteri.CompanyName);
            cmd.Parameters.AddWithValue("ContactName", musteri.ContactName);
            cmd.Parameters.AddWithValue("City", musteri.City);
            cmd.Parameters.AddWithValue("Country", musteri.Country);

            MyConnection.Connection.Open();
            cmd.ExecuteNonQuery(); // Sql tarafını çalıştırmak için
            MyConnection.Connection.Close();
        }

        public static void Guncelle(Musteri musteri)
        {
            SqlCommand cmd = new SqlCommand("update dbo.Customers set CompanyName =@CompanyName ,ContactName =@ContactName, City =@City, Country =@Country where CustomerID = @CustomerID", MyConnection.Connection);
            cmd.Parameters.AddWithValue("CustomerID", musteri.CustomerID);
            cmd.Parameters.AddWithValue("CompanyName", musteri.CompanyName);
            cmd.Parameters.AddWithValue("ContactName", musteri.ContactName);
            cmd.Parameters.AddWithValue("City", musteri.City);
            cmd.Parameters.AddWithValue("Country", musteri.Country);

            MyConnection.Connection.Open();
            cmd.ExecuteNonQuery(); // Sql tarafını çalıştırmak için
            MyConnection.Connection.Close();
        }

        public static void Sil(string customerId)
        {
            SqlCommand cmd = new SqlCommand("delete from dbo.Customers where CustomerID = @CustomerID", MyConnection.Connection);
            cmd.Parameters.AddWithValue("CustomerID", customerId);
            

            MyConnection.Connection.Open();
            cmd.ExecuteNonQuery(); // Sql tarafını çalıştırmak için
            MyConnection.Connection.Close();
        }

        public static Musteri Getir(string customerId)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from dbo.Customers where CustomerID = @CustomerID", MyConnection.Connection);
            da.SelectCommand.Parameters.AddWithValue("CustomerID", customerId); //mouseun focus olduğu satırı veriyor
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                return new Musteri();
            }


            Musteri musteri = new Musteri()
            {

                CustomerID = dt.Rows[0]["CustomerID"].ToString(),
                CompanyName = dt.Rows[0]["CompanyName"].ToString(),
                ContactName = dt.Rows[0]["ContactName"].ToString(),
                City = dt.Rows[0]["City"].ToString(),
                Country = dt.Rows[0]["Country"].ToString()

            };

            //musteri.CustomerID = dt.Rows[0]["CustomerID"].ToString();
            //musteri.CompanyName = dt.Rows[0]["CompanyName"].ToString();
            //musteri.ContactName = dt.Rows[0]["ContactName"].ToString();
            //musteri.City= dt.Rows[0]["City"].ToString();
            //musteri.Country = dt.Rows[0]["Country"].ToString();


            return musteri;




        }
    }
}
