using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realtor_Automation.Models
{
    [Table("Ev")]
    public class Ev
    {
        [Column(Order =0)]
        public int Id { get; set; }
        public int MusteriId { get; set; }
        public double Fiyat { get; set; }
        public int Kat { get; set; }
        public DateTime Tarih { get; set; }
        public bool Musait { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(60)]
        public string Resim { get; set; }
        public bool Esyali { get; set; }
        public int OdaSayi{ get; set; }
        public int Metrekare { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string Adres { get; set; }
        public int EvTurId { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string KiralikSatilik { get; set; }
        public virtual Musteri Musteri { get; set; }
        public virtual EvTur EvTur { get; set; }

    }
}
