using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{  
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Person NewPerson = new Person(1992, "Tom", 21);
            Console.WriteLine("Height from method - " + NewPerson.HeightOfPerson());
            Console.WriteLine("Sex from method - " + NewPerson.ReturnSex());
            NewPerson.ShowInfo();

        }
    }

    class Person
    {
        public int YearOfBirth { get; set; }
        public string Name { get; set; }

        public int Height { get; set; }
        public string Sex = "male";

        public Person(int yearOfBirth, string name, int height)
        {
            YearOfBirth = yearOfBirth;
            Name = name;
            Height = height;
        }

        public int HeightOfPerson () {        
            
            return Height;
        }

        public string ReturnSex()
        {
            return Sex;
        }

        public void ShowInfo ()
        {
            Console.WriteLine("New person mane - " + Name);
            Console.WriteLine("Year of birth - " + YearOfBirth);
            Console.WriteLine("heigst " + Height);
            Console.WriteLine("Sex " + Sex);
            Console.ReadKey();

        }




    } 
}
