using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realtor_Automation.Models
{
    [Table("Admin")]
    public class Admin
    {
        [Column(Order = 0)]
        public int Id { get; set; }
        [Column(TypeName="varchar")]
        [StringLength(30)]
        public string Ad { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Parola { get; set; }
    }
}
