using System;
using System.Collections;
namespace HashTableChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable h = new Hashtable();

            Student[] student = new Student[3];
            student[0] = new Student(1, "Sharan", 99);
            student[1] = new Student(2, "Aravindhan", 98);
            student[2] = new Student(3, "Gokul", 90);

            foreach(Student s in student)
            {
                if(!h.ContainsKey(s.Id))
                {
                    h.Add(s.Id, s);
                    Console.WriteLine("Student with Id {0} has beeen added", s.Id);
                }
                else
                {
                    Console.WriteLine("Student Id {0} is already in hashtable!", s.Id);
                }
            }

            Console.WriteLine("Displaying the hashtable.............");
            foreach(Student i in h.Values)
            {
                Console.WriteLine("ID:" + i.Id);
                Console.WriteLine("Name:" + i.Name);
                Console.WriteLine("GPA:" + i.GPA);
                Console.WriteLine("**********");
            }
        }
    }

    class Student
    {
        public int Id { get; set;  }
        public string Name { get; set; }

        public float GPA { get; set; }

        public Student(int id, string name, float GPA)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;
        }
    }
}
