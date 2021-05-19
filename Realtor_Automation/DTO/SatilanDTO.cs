using Realtor_Automation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realtor_Automation.DTO
{
    public class SatilanDTO
    {
        public int Id { get; set; }
        public DateTime Tarih { get; set; }
        public string MusteriAdSoyad { get
            {
                return (Musteri.Ad+" "+Musteri.Soyad);
            } }
        //public int MusteriId { get; set; }
        public double EvFiyat { get {
                return Ev.Fiyat;
            } }
        public int EvId { get; set; }
        public virtual Ev Ev { get; set; }
        public virtual Musteri Musteri { get; set; }
    }
}
