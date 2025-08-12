using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Domain.Entities
{
    public class StudentClasses
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentClassId { get; set; }
        [ForeignKey("Students")]
        public int SId { get; set; }
        public virtual Students Students { get; set; }
        [ForeignKey("Classes")]
        public int ClassId { get; set; }
        public virtual Classes Classes { get; set; }
        public int Year { get; set; }
    }
}
