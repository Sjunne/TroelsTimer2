﻿using ManyToManyExamples.Models;
using Microsoft.EntityFrameworkCore;

namespace ManyToManyExamples.Persistence
{
    public class ManyToManyContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            // name of database
            optionsBuilder.UseSqlite(@"Data Source = C:\Users\Mattias Leth\RiderProjects\TroelsTimer2\ManyToManyExamples\ManyToMany.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<StudentCourse>()
                .HasKey(sc => 
                    new
                    {
                        sc.StudentNum, 
                        sc.CourseCode
                    }
                );

            modelBuilder.Entity<StudentCourse>()
                .HasOne(studentCourse => studentCourse.Course)
                .WithMany(course => course.StudentCourses)
                .HasForeignKey(studentCourse => studentCourse.CourseCode);
            
            modelBuilder.Entity<StudentCourse>()
                .HasOne(studentCourse => studentCourse.Student)
                .WithMany(student => student.StudentCourses)
                .HasForeignKey(studentCourse => studentCourse.StudentNum);
        }
    }
}