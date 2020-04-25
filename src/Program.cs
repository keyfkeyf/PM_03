using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
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

        public Subject()
        {
            this.name = "";
            this.surname = "";
            this.semester = 0;
        }

    }


    public  class Mass
    {
      
        public static Subject[] Create(Subject[] plan, int n)
        {
            //Subject[] plan = new Subject[n];
            for (int i = 0; i < n; i++)
            {
                plan[i] = new Subject();

                Console.WriteLine("Введите название предмета");
                plan[i].name = Console.ReadLine();
                //do
                //{
                //} while ();

                Console.WriteLine("Введите фамилию преподавателя");
                plan[i].surname = Console.ReadLine();
                Console.WriteLine("Введите семестр");
                plan[i].semester = Convert.ToInt32(Console.ReadLine());

            }
           
            return plan;
        }


    }
    class Program
        {

        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Введите размер массива");
            n = Convert.ToInt32(Console.ReadLine());
          
          
            Console.ReadKey();
        }
      

    }
}
