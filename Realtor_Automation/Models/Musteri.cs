using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realtor_Automation.Models
{
    [Table("Musteri")]
    public class Musteri
    {
        [Column(Order = 0)]
        public int Id { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Ad { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Soyad { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string TelNo { get; set; }
        public int MusteriTurId { get; set; }
        public virtual MusteriTur MusteriTur { get; set; }
        public virtual ICollection<Satilan> SatinAlinanlar{ get; set; }
        public virtual ICollection<Kiralanan> Kiralananlar { get; set; }
        public virtual ICollection<Ev> Evler { get; set; }

    }
}
