using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Domain.Entities
{
    internal class Admins : Users
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AdminId { get; set; }
        [ForeignKey("Schools")]
        public int SchoolId { get; set; }
        public virtual Schools? Schools { get; set; }
    }
}
