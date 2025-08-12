using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Domain.Entities
{
    internal class Subjects
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        [ForeignKey("Schools")]
        public int SchoolId { get; set; }
        public virtual Schools Schools { get; set; }
        public virtual ICollection<Assignments> assignments { get; set; }
        public virtual ICollection<ClassSchedule> classSchedule { get; set; }
        public virtual ICollection<StudentMarks> studentMarks { get; set; }
        public virtual ICollection<TeacherClasses> teacherClasses { get; set; }
    }
}
