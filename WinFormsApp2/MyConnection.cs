using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public static class MyConnection //static olması her yerden erişilebilir ve newlemeye gerek yok
    {
       public static SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthwindContext"].ToString()); // artık bu bir property oldu
    }
}
