using Realtor_Automation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realtor_Automation.DTO
{
    public class MusteriDTO
    {
        public int Id { get; set; }        
        public string Ad { get; set; }       
        public string Soyad { get; set; }      
        public string TelNo { get; set; }
        public string MusteriTurAdi
        {
            get
            {
                return MusteriTur.Ad;
            }
        }

        public virtual MusteriTur MusteriTur { get; set; }
    }
}
