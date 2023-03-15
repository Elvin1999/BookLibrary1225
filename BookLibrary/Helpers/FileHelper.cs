using BookLibrary.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;

namespace BookLibrary.Helpers
{
    public class FileHelper
    {
        public static void WriteBooks(List<Book> books)
        {
            var serializer = new JsonSerializer();

            using (var sw = new StreamWriter("books.json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Formatting.Indented;
                    serializer.Serialize(jw, books);
                }
            }
        }

        public static void WriteStudents(List<Student> students)
        {
            var serializer = new JsonSerializer();

            using (var sw = new StreamWriter("students.json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Formatting.Indented;
                    serializer.Serialize(jw, students);
                }
            }
        }

        public static List<Student> ReadStudents()
        {
            List<Student> students = null;
            var serializer = new JsonSerializer();
            using (var sr = new StreamReader("students.json"))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    students = serializer.Deserialize<List<Student>>(jr);
                }
            }
            return students;
        }

        public static List<Book> ReadBooks()
        {
            List<Book> books = null;
            var serializer = new JsonSerializer();
            using (var sr = new StreamReader("books.json"))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    books = serializer.Deserialize<List<Book>>(jr);
                }
            }
            return books;
        }
    }
}
