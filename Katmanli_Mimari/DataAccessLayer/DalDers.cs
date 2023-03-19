using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data;

namespace DataAccessLayer
{
    public class DalDers
    {
        // Crud Metotları
        // Ekle Silme Güncelleme Listeleme
        public static int DersEkle(EntityDers p) 
        {
            SqlCommand cmd1 = new SqlCommand("insert into TblDersler (DersAd) values (@p1)", Baglanti.bgl);
            if(cmd1.Connection.State!=System.Data.ConnectionState.Open)
            {
                cmd1.Connection.Open();

            }
            cmd1.Parameters.AddWithValue("@p1", p.DersAd);
            return cmd1.ExecuteNonQuery();
        }
    }
}
