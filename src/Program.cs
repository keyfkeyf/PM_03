using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    public class Subject
        {
            public string name;
            public string surname;
            public int semester;

            public Subject(string Name, string Surname, int Semester)
            {
                this.name = Name;
                this.surname = Surname;
                this.semester = Semester;
            }
        }
    class Program
    {
       
            static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Введите размер массива");
            n = Convert.ToInt32(Console.ReadLine());
            Subject[] mas = new Subject[n];
           
        }
    }
}
