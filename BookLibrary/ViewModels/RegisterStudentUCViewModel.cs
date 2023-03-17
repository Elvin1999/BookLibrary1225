using BookLibrary.Commands;
using BookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BookLibrary.ViewModels
{
    public class RegisterStudentUCViewModel:BaseViewModel
    {
        private Student student;

        public Student Student
        {
            get { return student; }
            set { student = value; OnPropertyChanged(); }
        }

        public RelayCommand RegisterCommand { get; set; }
        public RegisterStudentUCViewModel()
        {
            Student = new Student();

            RegisterCommand = new RelayCommand((o) =>
            {
                Student.Id = (new Random()).Next(1, 1000000);
                App.StudentRepo.AddStudent(Student);
                MessageBox.Show($"{Student.Fullname} student added successfully");
                Student=new Student();
            });
        }
    }
}
