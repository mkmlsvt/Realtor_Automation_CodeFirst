using Realtor_Automation.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realtor_Automation.Business
{
    public class MusteriTurBusiness
    {
        MusteriTurData musteriTurData;
        public MusteriTurBusiness()
        {
            musteriTurData = new MusteriTurData();
        }
        public Dictionary<int, string> GetAllMusteriTurData()
        {
            var musteriTurleri = musteriTurData.GetAllMusteriTurData();
            var musteriTurleriDict = musteriTurleri.ToDictionary(q => q.Id, q => q.Ad);
            return musteriTurleriDict;
        }
    }
}
