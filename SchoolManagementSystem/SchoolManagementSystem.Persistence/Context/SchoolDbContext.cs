using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Domain.Entities;

namespace SchoolManagementSystem.Persistence.Context
{
    public class SchoolDbContext :DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
        {
        }
       
        // DbSet properties for your entities can be added here
        public DbSet<Admins> Admins { get; set; }
        public DbSet<Assignments> Assignments { get; set; }
        public DbSet<AssignmentSubmissions> AssignmentSubmissions { get; set; }
        public DbSet<Attendance> Attendance { get; set; }
        public DbSet<Classes> Classes { get; set; }
        public DbSet<ClassSchedule> ClassSchedule { get; set; }
        public DbSet<LoginHistory> LoginHistory { get; set; }
        public DbSet<Schools> Schools { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<StudentClasses> StudentClasses { get; set; }
        public DbSet<StudentHistory> StudentHistory { get; set; }
        public DbSet<StudentMarks> StudentMarks { get; set; }
        public DbSet<Students> Students { get; set; }
        public DbSet<Subjects> Subjects { get; set; }
        public DbSet<TeacherClasses> TeacherClasses { get; set; }
        public DbSet<Teachers> Teachers { get; set; }
        //public DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Assignments → Subjects
            modelBuilder.Entity<Assignments>()
                .HasOne(a => a.Subjects)
                .WithMany(s => s.assignments)
                .HasForeignKey(a => a.SubjectId)
                .OnDelete(DeleteBehavior.Restrict);

            // Assignments → Classes
            modelBuilder.Entity<Assignments>()
                .HasOne(a => a.Classes)
                .WithMany(c => c.assignments)
                .HasForeignKey(a => a.ClassId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Assignments>()
   .HasOne(a => a.Teachers)
   .WithMany(t => t.assignments)
   .HasForeignKey(a => a.TeacherId)
   .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ClassSchedule>()
       .HasOne(cs => cs.Classes)
       .WithMany(c => c.classSchedule)
       .HasForeignKey(cs => cs.ClassId)
       .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ClassSchedule>()
                .HasOne(cs => cs.Subjects)
                .WithMany(s => s.classSchedule)
                .HasForeignKey(cs => cs.SubjectId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ClassSchedule>()
                .HasOne(cs => cs.Schools)
                .WithMany(sch => sch.ClassSchedules)
                .HasForeignKey(cs => cs.SchoolId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<TeacherClasses>()
       .HasOne(tc => tc.Classes)
       .WithMany(c => c.teacherClasses)
       .HasForeignKey(tc => tc.ClassId)
       .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<TeacherClasses>()
                .HasOne(tc => tc.Subjects)
                .WithMany(s => s.teacherClasses)
                .HasForeignKey(tc => tc.SubjectId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Attendance>().HasOne(a => a.Classes).WithMany(c => c.attendances).HasForeignKey(a => a.SId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Attendance>()
                .HasOne(a => a.Students)
                .WithMany(s => s.attendances)
                .HasForeignKey(a => a.ClassId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<StudentClasses>()
    .HasOne(sc => sc.Students)
    .WithMany(s => s.studentClasses)
    .HasForeignKey(sc => sc.SId)
    .OnDelete(DeleteBehavior.Restrict);  

            modelBuilder.Entity<StudentClasses>()
                .HasOne(sc => sc.Classes)
                .WithMany(c => c.studentClasses)
                .HasForeignKey(sc => sc.ClassId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<StudentMarks>()
    .HasOne(sm => sm.Students)
    .WithMany(s => s.studentMarks)
    .HasForeignKey(sm => sm.SId)
    .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<StudentMarks>()
                .HasOne(sm => sm.Subjects)
                .WithMany(su => su.studentMarks)
                .HasForeignKey(sm => sm.SubjectId)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<ClassSchedule>()
    .HasOne(cs => cs.Classes)
    .WithMany(c => c.classSchedule)
    .HasForeignKey(cs => cs.ClassId)
    .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ClassSchedule>()
                .HasOne(cs => cs.Schools)
                .WithMany(sch => sch.ClassSchedules)
                .HasForeignKey(cs => cs.SchoolId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ClassSchedule>()
                .HasOne(cs => cs.Subjects)
                .WithMany(s => s.classSchedule)
                .HasForeignKey(cs => cs.SubjectId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ClassSchedule>()
                .HasOne(cs => cs.Teachers)
                .WithMany(t => t.classSchedule)
                .HasForeignKey(cs => cs.TeacherId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
