using Realtor_Automation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realtor_Automation.DTO
{
    public class EvFilterDTO
    {
        public int? MinFiyat{ get; set; }
        public int? MaxFiyat{ get; set; }
        public int? MetreKare{ get; set; }
        public int? Kat { get; set; }
        public bool? Esyali{ get; set; }
        public bool? Musait{ get; set; }
        public int? OdaSayisi{ get; set; }
        public string SatilikKiralik{ get; set; }
        public string MusteriAd{ get; set; }
        public string MusteriSoyad { get; set; }
    }
}
