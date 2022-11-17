using System;

namespace question_9
{
    class Program
    {
        static void Main(string[] args)
        {
           

           
            student s = new student(322998675, 22, "moriya","computer",'A',100);
          
            Console.WriteLine(s.getSomething());
            //Convert to son
            Console.WriteLine((s as student).getSomething());
        }
    }
}
