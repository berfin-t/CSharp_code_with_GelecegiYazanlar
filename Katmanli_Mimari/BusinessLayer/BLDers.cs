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
    }
}
