using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RasuliEDatabase.Models;
using RasuliEDatabase.Services.Students;

namespace RasuliEDatabase.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService i)
        {
            _studentService = i;
        }

        [HttpGet]
        [Route("GetStudents")]
        public List<Student> GetStudents(){
            return _studentService.GetStudents();
        }

        [HttpGet]
        [Route("GetStudent/{name}")]
        public Student getStudent(string name){
            return _studentService.GetStudent(name);
        }

        [HttpPost]
        [Route("AddStudent/{name}/{lastname}/{hobby}")]
        public List<Student> AddStudent(string name, string lastname, string hobby){
            return _studentService.AddStudent(name, lastname, hobby);
        }

        [HttpDelete]
        [Route("RemoveStudent/{name}")]
        public List<Student> RemoveStudent(string name){
            return _studentService.RemoveStudent(name);
        }

    }
}