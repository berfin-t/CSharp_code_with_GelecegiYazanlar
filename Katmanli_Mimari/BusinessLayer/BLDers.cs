using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace BusinessLayer
{
    public class BLDers
    {
        public static int DersEkleBL(EntityDers p)
        {
            if(p.DersAd!=null && p.DersAd.Length>=3 && p.DersAd.Length<=30)
            {
                return DalDers.DersEkle(p);
            }
            return -1;
            
        }
        public static List<EntityDers> DersListesiBL()
        {
            return DalDers.DersListesi();
        }
        public static int DersSilBL(byte p)
        {
            if(p<=1)
            {
                return DalDers.DersSil(p);
            }
            else
            {
                return -1;
            }
        }
        public static int DersGuncelleBL(EntityDers p)
        {
            if(p.DersAd!="" && p.DersAd.Length>=3 && p.DersAd.Length<=30 && p.DersID>=1)
            {
                return DalDers.DersGuncelle(p);
            }
            return -1;
        }
    }
}
