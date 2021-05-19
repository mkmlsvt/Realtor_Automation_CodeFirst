using Realtor_Automation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realtor_Automation.DTO
{
    public class EvDTO
    {
        public int Id { get; set; }
        //public int MusteriId { get; set; }
        public double Fiyat { get; set; }
        public int Kat { get; set; }
        public DateTime Tarih { get; set; }
        public bool Musait { get; set; }
        public string Resim { get; set; }
        public bool Esyali { get; set; }
        public int OdaSayi { get; set; }
        public int Metrekare { get; set; }
        public string Adres { get; set; }
        //public int EvTurId { get; set; }
        public string KiralikSatilik { get; set; }
        public string MusteriAdi { get
            {
                return Musteri.Ad;
            }
        }
        public string EvTurAdi { get
            {
                return EvTur.Ad;
            }
        }
        public virtual Musteri Musteri { get; set; }
        public virtual EvTur EvTur { get; set; }
    }
}
