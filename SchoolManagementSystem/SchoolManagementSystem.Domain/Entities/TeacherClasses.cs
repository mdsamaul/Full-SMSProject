using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Domain.Entities
{
    internal class TeacherClasses
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TeacherClasseId { get; set; }
        [ForeignKey("Teachers")]
        public int TeacherId { get; set; }
        public virtual Teachers Teachers { get; set; }
        [ForeignKey("Classes")]
        public int ClassId { get; set; }
        public virtual Classes Classes { get; set; }
        [ForeignKey("Subjects")]
        public int SubjectId { get; set; }
        public virtual Subjects Subjects { get; set; }
        public int Year { get; set; }
    }
}
