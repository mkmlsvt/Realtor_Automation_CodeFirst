using Realtor_Automation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realtor_Automation.Data
{
    public class AdminData
    {
        DatabaseContext db;
        public AdminData()
        {
            db = new DatabaseContext();
        }
        public bool GirisKontrol(Admin admin)
        {
            var giris = db.TBLAdmin.FirstOrDefault(q => q.Ad == admin.Ad && q.Parola == admin.Parola);
            if(giris==null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
