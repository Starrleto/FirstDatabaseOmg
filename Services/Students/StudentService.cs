using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using RasuliEDatabase.Data;
using RasuliEDatabase.Models;

namespace RasuliEDatabase.Services.Students
{
    public class StudentService : IStudentService
    {
        private readonly DataContext _db;

        public StudentService(DataContext d){
            _db = d;
        }

        public Student GetStudent(string name){
            var s = _db.Students.FirstOrDefault(studen => studen.FirstName.ToLower() == name.ToLower());
            if(s!= null)
                return s;
            else
                return new Student("student not found");
        }
        public List<Student> GetStudents(){
            return _db.Students.ToList();
        }
        public List<Student> AddStudent(string name, string lastname, string hobby){
            _db.Students.Add(new Student(name, lastname, hobby));
            _db.SaveChanges();
            return _db.Students.ToList();
        }
        public List<Student> RemoveStudent(string name){
            var s = _db.Students.FirstOrDefault(studen => studen.FirstName.ToLower() == name.ToLower());
            if(s != null)
                _db.Students.Remove(s);
            _db.SaveChanges();
            return _db.Students.ToList();
        }
    }
}