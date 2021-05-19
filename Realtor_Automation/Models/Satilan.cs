using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realtor_Automation.Models
{
    [Table("Satilan")]
    public class Satilan
    {
        [Column(Order = 0)]
        public int Id { get; set; }
        public DateTime Tarih { get; set; }
        public int MusteriId { get; set; }
        public int EvId { get; set; }
        public virtual Ev Ev{ get; set; }
        public virtual Musteri Musteri{ get; set; }
    }
}
