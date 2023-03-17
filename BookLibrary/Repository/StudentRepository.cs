using BookLibrary.Helpers;
using BookLibrary.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Repository
{
    public class StudentRepository
    {
        public List<Student> Students { get; set; }
        public StudentRepository()
        {
            Students=new List<Student>();
            if (File.Exists("students.json"))
            {
                Students = FileHelper.ReadStudents();
            }
        }
        public void AddStudent(Student student)
        {
            Students.Add(student);
            FileHelper.WriteStudents(Students);
        }
    }
}
