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
            this.semester = 1;
        }

    }


   
    class Program
        {
        static public List<Subject>  Plan =  new List<Subject>();
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.WriteLine("Введите размер массива");
                n = Convert.ToInt32(Console.ReadLine());
                if (n==0 || n<0) { Console.WriteLine("Массив не может быть пустым, а также не может содержать отрицательное количество элементов"); }
            }

            while (n == 0 || n<0);
          
      

            Create(n);
            //foreach (Subject s in Plan)
            //{
            //   Console.Write(s.name + "; " + s.surname + "; " + s.semester.ToString());
            //}
            Sort();
            //Console.Write("Отсортированный массив");
            //foreach (Subject s in Plan)
            //{
            //    Console.Write(s.name + "; " + s.surname + "; " + s.semester.ToString());
            //}
            Write();


            Console.ReadKey();
        }

        public static void Create(int n)
        {

            for (int i = 0; i < n; i++)
            {
                try
                {
                    Subject sub = new Subject();
                    Console.WriteLine("Предмет"+ " "+ (i+1).ToString());
                    Console.WriteLine("Введите название предмета");
                    sub.name = Console.ReadLine();
                   Console.WriteLine("Введите фамилию преподавателя");
                        sub.surname = Console.ReadLine();
                   
                    do
                    {
                        Console.WriteLine("Введите семестр");
                        sub.semester = Convert.ToInt32(Console.ReadLine());
                        if (sub.semester == 0 || sub.semester < 0) { Console.WriteLine("Нет такого семестра (не бывает отрицательных и нулевых)"); }
                    }

                    while (sub.semester == 0 || sub.semester < 0);

                    
                    Plan.Add(sub);
                }


                catch (Exception)
                {
                    Console.WriteLine("Некорректные данные");
                }
            }

}

public static void Sort()
        {
            Plan.Sort((first, second) => string.Compare(first.semester.ToString(), second.name));
        }

        public static void Write()
        {
            using (StreamWriter w = new StreamWriter("Предметы.txt"))
            {
                foreach (Subject s in Plan)
                    w.WriteLine(s.name + "; " +s.surname + "; " + s.semester.ToString());
            }

            Console.WriteLine("Данные записаны!");
        
            
        }


    }
}
