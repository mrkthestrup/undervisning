using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ConsoleApplication.Models.Entities;

namespace ConsoleApplication.Models.ViewModels 
{
    public class StudentCourseViewModel
    {
        public Student Student { get; set; }

        public IEnumerable<Course> Courses { get; set; }
    }
}
       