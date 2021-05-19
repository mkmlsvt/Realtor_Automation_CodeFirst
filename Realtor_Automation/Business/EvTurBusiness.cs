using Realtor_Automation.Data;
using Realtor_Automation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Realtor_Automation.Business
{
    public class EvTurBusiness
    {
        EvTurData evTurData;
        public EvTurBusiness()
        {
            evTurData = new EvTurData();
        }
        public Dictionary<int,string> GetAllEvTur()
        {          
            var evTurleri = evTurData.GetAllEvTur();
            var evTurleriDict = evTurleri.ToDictionary(q =>  q.Id, q=> q.Ad );
            return evTurleriDict;
        }
    }
}
