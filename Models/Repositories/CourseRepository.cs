using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleApplication.Models;
using ConsoleApplication.Models.Entities;
using ConsoleApplication.Models.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApplication.Models.Repositories
{
    

public class CourseRepository : ICourseRepository
    {
        private MyDbContext _db;
        private DbSet<Course> _course;
        
        public CourseRepository(MyDbContext db)
        {
            _db = db;
            _course = db.Courses;
        }

        public void Delete(Course id)
        {
            throw new NotImplementedException();
        }

        public Course Get(int id)
        {
            Course course = _db.Courses.Find(id);
           
       return course;
        }

        public IEnumerable<Course> GetAll()
        {
            
        return _course;
        }

        public void Save(Course c)
        {
            _db.Courses.Add(c);
            _db.SaveChanges();
        }

        public void Update(Course c)
        {
            _db.Courses.Update(c);
            _db.SaveChanges();
        }
    }

}