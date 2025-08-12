using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Domain.Entities
{
    internal class Students
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SId { get; set; }
        public required string StudentId { get; set; }
        public required int ClassRoll { get; set; }
        public DateTime? EnrollmentDate { get; set; }
        public int AdmissionYear { get; set; }
        [ForeignKey("Schools")]
        public int SchoolId { get; set; }
        public virtual Schools Schools { get; set; }
        //public virtual ICollection<StudentHistory> StudentHistories { get; set; }
        public virtual ICollection<AssignmentSubmissions> assignmentSubmissions { get; set; }
        public virtual ICollection<Attendance> attendances { get; set; }
        public virtual ICollection<StudentClasses> studentClasses { get; set; }
        public virtual ICollection<StudentHistory> studentHistory { get; set; }
        public virtual ICollection<StudentMarks> studentMarks { get; set; }
    }
}
