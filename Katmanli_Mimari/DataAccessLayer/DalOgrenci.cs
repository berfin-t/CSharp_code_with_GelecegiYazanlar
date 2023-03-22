using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient;
using System.Data;

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
        public static List<EntityOgrenci> OgrenciListesi()
        {
            List<EntityOgrenci> ogrenciler = new List<EntityOgrenci>();
            SqlCommand cmd2 = new SqlCommand("Select * From TblOgrenci", Baglanti.bgl);
            if(cmd2.Connection.State!= ConnectionState.Open)
            {
                cmd2.Connection.Open();
            }
            SqlDataReader dr = cmd2.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent =new EntityOgrenci();
                ent.OgrenciID = int.Parse(dr[0].ToString());
                ent.Ad = dr[1].ToString();
                ent.Soyad= dr[2].ToString();
                ent.Numara = dr[3].ToString();
                ent.Bölüm = dr[4].ToString();
                ogrenciler.Add(ent);
            }
            dr.Close();
            return ogrenciler;
        }
        public static int OgrenciSil(int p)
        {
            SqlCommand cmd3 = new SqlCommand("Delete from TblOgrenci where OGrenciID=@p1", Baglanti.bgl);
            if (cmd3.Connection.State != ConnectionState.Open)
            {
                cmd3.Connection.Open();
            }
            cmd3.Parameters.AddWithValue("@p1", p);
            return cmd3.ExecuteNonQuery();
        }
        public static int DersGuncelle(EntityDers p)
        {
            SqlCommand cmd4 = new SqlCommand("Update TblDersler set DersAd=@p1 where DersID=@p2", Baglanti.bgl);
            if(cmd4.Connection.State != ConnectionState.Open)
            {
                cmd4.Connection.Open();
            }
            cmd4.Parameters.AddWithValue("@p1", p.DersAd);
            cmd4.Parameters.AddWithValue("@p2", p.DersID);
            return cmd4.ExecuteNonQuery();
        }
    }
}
