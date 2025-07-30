using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Domain.Entities
{
    internal class Schools
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SchoolId { get; set; }
        public string SchoolName { get; set; }
        public string EiinNumber { get; set; }
        public string? Category { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? LogoPath { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Students>? Students { get; set; }
        public virtual ICollection<Teachers>? Teachers { get; set; }
        public virtual ICollection<Staff>? Staff { get; set; }
        public virtual ICollection<Classes>? Classes { get; set; }
        public virtual ICollection<Subjects>? Subjects { get; set; }
        public virtual ICollection<ClassSchedule>? ClassSchedules { get; set; }
        public virtual ICollection<Admins>? Admins { get; set; }
    }
}
