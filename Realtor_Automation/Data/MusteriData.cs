using Realtor_Automation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realtor_Automation.Data
{
    public class MusteriData
    {
        DatabaseContext db;
        public MusteriData()
        {
            db = new DatabaseContext();
        }
        public void AddCustomer(Musteri musteri)
        {
            db.TBLMusteri.Add(musteri);
            db.SaveChanges();
        }
        public List<Musteri> GetAllCustomers()
        {
            List<Musteri> musteriler =  db.TBLMusteri.ToList();
            return musteriler;
        }

    }
}
