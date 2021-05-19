using Realtor_Automation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Realtor_Automation.Data
{
    public class EvTurData
    {
        DatabaseContext db;
        public EvTurData()
        {
            db = new DatabaseContext();
        }
        public List<EvTur> GetAllEvTur()
        {
            var evTurs = db.TBLEvTur.ToList();
            return evTurs;
        }
    }
}
