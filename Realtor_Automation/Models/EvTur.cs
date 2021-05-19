using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realtor_Automation.Models
{
    [Table("EvTur")]
    public class EvTur
    {
        [Column(Order = 0)]
        public int Id { get; set; }
        public string Ad { get; set; }
        public virtual ICollection<Ev> Evler { get; set; }
    }
}
