using Realtor_Automation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realtor_Automation.Data
{
    public class KiralananData
    {
        DatabaseContext db;
        public KiralananData()
        {
            db = new DatabaseContext();
        }
        public void AddKiralanan(Kiralanan kiralanan)
        {
            db.TBLKiralanan.Add(kiralanan);
            db.SaveChanges();
        }
        public List<Kiralanan> GetAllKiralanan()
        {
            var kiralananlar = db.TBLKiralanan.ToList();
            return kiralananlar;
        }
    }
}
