using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DalOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci p)
        {
            SqlCommand cmd1 = new SqlCommand("insert into TblOgrenci (Ad,Soyad,Numara,Bolum) values (@p1,@p2,@p3,@p4)", 
                Baglanti.bgl);
            if (cmd1.Connection.State!= System.Data.ConnectionState.Open)
            {
                cmd1.Connection.Open();
            }
            cmd1.Parameters.AddWithValue("@p1", p.Ad);
            cmd1.Parameters.AddWithValue("@p2", p.Soyad);
            cmd1.Parameters.AddWithValue("@p3", p.Numara);
            cmd1.Parameters.AddWithValue("@p4", p.Bölüm);
            return cmd1.ExecuteNonQuery();
        }
    }
}
