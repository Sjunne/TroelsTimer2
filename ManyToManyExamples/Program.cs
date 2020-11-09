using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using ManyToManyExamples.Models;
using ManyToManyExamples.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ManyToManyExamples
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (ManyToManyContext context = new ManyToManyContext())
            await WhichCoursesIsSteveEnrolledIn(context);
        }
        
        private static async Task AddTwoCourses(ManyToManyContext ctx)
        {
            Course sdj2 = new Course
            {
                Abbreviation = "SDJ2",
                Name = "Software Development with UML and Java 2",
                Semester = 2,
                CourseCode = "IT-SDJ2-A20",
                ECTS = 10
            };
            Course dnp1 = new Course
            {
                Abbreviation = "DNP1",
                Name = "I forgot the actual name",
                Semester = 3,
                CourseCode = "IT-DNP1Y-A20",
                ECTS = 5
            };
            await ctx.Courses.AddAsync(sdj2);
            await ctx.Courses.AddAsync(dnp1);
            await ctx.SaveChangesAsync();
        }

        private static async Task AddOneSteve(ManyToManyContext ctx)
        {
            Student s = new Student
            {
                FirstName = "Steve",
                LastName = "Doe",
                Email = "123456@via.dk",
                StudentNum = 123456
            };
            await ctx.Students.AddAsync(s);
            await ctx.SaveChangesAsync();
        }
        
        
        private static async Task EnrollSteveInDNP(ManyToManyContext ctx, string course)
        {
            Student steve = await ctx.Students.FirstAsync(s => s.StudentNum == 123456);
            Course dnp = await ctx.Courses.FirstAsync(c => c.CourseCode.Equals(course));
            StudentCourse sc = new StudentCourse
            {
                Course = dnp,
                Student = steve
            };
            
            ctx.Set<StudentCourse>().Add(sc);
            await ctx.SaveChangesAsync();
        }

        private static async Task WhichCoursesIsSteveEnrolledIn(ManyToManyContext ctx)
        {
            List<Course> courses = await ctx.Students
                .Where(s => s.StudentNum == 123456)
                .SelectMany(student => student.StudentCourses)
                .Select(studentCourse => studentCourse.Course)
                .ToListAsync();
            foreach (var course in courses)
            {
                Console.WriteLine(course);
            }
        }
        
        
        private async Task UnEnrollSteveFromCourse(ManyToManyContext ctx)
        {
            StudentCourse steveAndDnp = ctx.Students.
                Where(s => s.StudentNum == 123456).
                SelectMany(student => student.StudentCourses).
                First(studentCourse => studentCourse.Course.CourseCode.Equals("IT-SDJ2-A20"));
            ctx.Remove(steveAndDnp);
        
            await ctx.SaveChangesAsync();
        }
    }
    
    
    
}