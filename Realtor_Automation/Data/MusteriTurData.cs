using Realtor_Automation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realtor_Automation.Data
{
    public class MusteriTurData
    {
        DatabaseContext db;
        public MusteriTurData()
        {
            db = new DatabaseContext();
        }
        public List<MusteriTur> GetAllMusteriTurData()
        {
            var musteriTurs = db.TBLMusteriTur.ToList();
            return musteriTurs;
        }
    }
}
