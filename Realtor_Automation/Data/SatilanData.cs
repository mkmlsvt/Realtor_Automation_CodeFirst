using Realtor_Automation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realtor_Automation.Data
{
    public class SatilanData
    {
        DatabaseContext db;
        public SatilanData()
        {
            db = new DatabaseContext();
        }
        public void AddSatilan(Satilan satilan)
        {
            db.TBLSatilan.Add(satilan);
            db.SaveChanges();
        }

        public List<Satilan> GetAllSatilan()
        {
            var tumSatilanlar = db.TBLSatilan.ToList();
            return tumSatilanlar;
        }
    }
}
