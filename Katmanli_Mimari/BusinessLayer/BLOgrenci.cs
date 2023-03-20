using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public  class BLOgrenci
    {
        public static int OgrenciEkleBL(EntityOgrenci p)
        {
            if (p.Ad == "" && p.Ad.Length>=2 && p.Ad.Length<=30 && p.Soyad!="" && p.Bölüm!="" && p.Numara.Length==5) 
            {
                return DalOgrenci.OgrenciEkle(p);
            }
            return -1;
        }
    }
}
