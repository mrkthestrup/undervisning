using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApplication.Models.Entities;

namespace ConsoleApplication.Models.Repositories
{
    public interface ICourseRepository
    {
    
       IEnumerable<Course> GetAll();
       Course Get(int id);

       void Delete(Course id);

       void Update(Course student);

       void Save(Course student);

    }

    }