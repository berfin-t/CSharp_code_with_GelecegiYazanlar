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
        public static List<EntityDers> DersListesi()
        {
            List<EntityDers> dersler=new List<EntityDers>();
            SqlCommand cmd2 = new SqlCommand("Select * Form TblDersler", Baglanti.bgl);
            if(cmd2.Connection.State!=ConnectionState.Open)
            {
                cmd2.Connection.Open();
            }
            SqlDataReader dr=cmd2.ExecuteReader();
            while(dr.Read())
            {
                EntityDers ent = new EntityDers();
                ent.DersID = byte.Parse(dr["DersID"].ToString());
                ent.DersAd= dr["DersAd"].ToString();
                dersler.Add(ent);
            }
            dr.Close();
            return dersler;
        }
        public static int DersSil(byte p)
        {
            SqlCommand cmd3 = new SqlCommand("Delete From TblDersler where DersID=@p1", Baglanti.bgl);
            if (cmd3.Connection.State!=ConnectionState.Open)
            {
                cmd3.Connection.Open();
            }
            cmd3.Parameters.AddWithValue("@p1", p);
            return cmd3.ExecuteNonQuery();

        }
        public static int DersGuncelle(EntityDers p)
        {
            SqlCommand cmd4 = new SqlCommand("Update TblDersler set DersAd=@p1 where DersID=@p2",Baglanti.bgl);
            if (cmd4.Connection.State!=ConnectionState.Open)
            {
                cmd4.Connection.Open();
            }
            cmd4.Parameters.AddWithValue("@p1", p.DersAd);
            cmd4.Parameters.AddWithValue("@p2",p.DersID); 
            return cmd4.ExecuteNonQuery();

        }
    }
}
