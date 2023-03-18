using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Baglanti
    {
        public static SqlConnection bgl = new SqlConnection("Data Source=DESKTOP-NBHVRA9\\SQLEXPRESS;Initial Catalog=DbKatmanliMimari;Integrated Security=True");
    }
}
