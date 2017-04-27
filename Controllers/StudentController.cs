using System.Collections.Generic;
using System.Linq;
using ConsoleApplication.Models;
using ConsoleApplication.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleApplication.Controllers
{
    public class StudentController : Controller
    {
        // Tight Couple
       // MyDbContext db = new MyDbContext();


       //Loosly Coupled 
        private IStudentRepository studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        // Read
        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<Student> students = studentRepository.GetAll();
            //List<Student> students = db.Students.ToList();
            return View(students);
        }

        // Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        //Create
        [HttpPost]
        public IActionResult Create(Student st)
        {
            if (ModelState.IsValid)
            {
                studentRepository.Save(st);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        // Update
        public IActionResult Update(int id)
        {
            Student student =  studentRepository.Get(id);
           
            return View(student);
        }
        [HttpPost]
        public IActionResult Update(Student student)
        {
            if (ModelState.IsValid)
            {
                studentRepository.Update(student);
           
                return RedirectToAction("Index");
            }
            return View(student);
        }

        //Delete
        [HttpGet]
        public IActionResult Delete(int id)
        {
           Student student =  studentRepository.Get(id);
           
            return View(student);
        }

        [HttpPost]
        public IActionResult Delete(Student st)
        {
            studentRepository.Delete(st);
            
            return RedirectToAction("Index");
        }

    }
}