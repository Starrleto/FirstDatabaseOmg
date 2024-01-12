using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RasuliEDatabase.Models;

namespace RasuliEDatabase.Services.Students
{
    public interface IStudentService
    {
        public List<Student> GetStudents();
        public Student GetStudent(string name);
        public List<Student> AddStudent(string name, string lastname, string hobby);
        public List<Student> RemoveStudent(string name);
    }
}