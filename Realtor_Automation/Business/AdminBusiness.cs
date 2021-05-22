using Realtor_Automation.Data;
using Realtor_Automation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realtor_Automation.Business
{
    public class AdminBusiness
    {
        AdminData admindata;
        public AdminBusiness()
        {
            admindata = new AdminData();
        }
        public bool GirisKontrol(Admin admin)
        {
            var TrueorFalse = admindata.GirisKontrol(admin);
            return TrueorFalse;
        }
    }
}
