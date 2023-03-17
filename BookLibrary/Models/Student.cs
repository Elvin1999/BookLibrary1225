using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string  Username { get; set; }
        public string Password { get; set; }
        public List<Rent> Rents { get; set; }
        public Student()
        {
            Rents=new List<Rent>();
        }
    }
}
