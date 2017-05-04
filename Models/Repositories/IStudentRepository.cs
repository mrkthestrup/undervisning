using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApplication.Models.Entities;

namespace ConsoleApplication.Models.Repositories
{
    public interface IStudentRepository
    {
        //Basic CRUD opreation
        IEnumerable<Student> GetAll();
       Student Get(int id);

       void Delete(Student id);

       void Update(Student student);

       void Save(Student student);

    }
}
