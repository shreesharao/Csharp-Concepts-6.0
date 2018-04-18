using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp60New
{
    class Topic_11
    {

        public void Entry()
        {
            var classList = new Enrollment()  //this syntax will not work without 'Add' extension method 
            {
                new Student("Shreesha","rao"),
                new Student(firstaName:"Shreesha",lastName:"Rao")
            };

            foreach (var student in classList)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }

        }
    }


    public class Enrollment : IEnumerable<Student>
    {
        List<Student> students = new List<Student>();

        public void Enroll(Student student) //method to add students
        {
            students.Add(student);
        }

        public IEnumerator<Student> GetEnumerator()
        {
            return students.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Student(string firstaName, string lastName)
        {
            FirstName = firstaName;
            LastName = lastName;
        }
    }

    public static class EnrollmentExtensions
    {
        public static void Add(this Enrollment enrollment, Student s) => enrollment.Enroll(s);
    }
}
