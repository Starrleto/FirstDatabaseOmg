
namespace RasuliEDatabase.Models
{
    public class Student
    {
        public int Id {get; set;}
        public string FirstName {get; set;} = "";
        public string LastName {get; set;} = "";
        public string Hobby {get; set;} = "";

        public Student(string firstName){
            FirstName = firstName;
        }
        public Student(string firstName, string lastName, string hobby){
            FirstName = firstName;
            LastName = lastName;
            Hobby = hobby;
        }
    }
}