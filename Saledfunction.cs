using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace inheretance
{
   class student
    {

        sealed void info(string name, string Class)
        {
            
            Console.WriteLine("student name :-" + name);
            Console.WriteLine("Class :-" + Class);
        }
         void info(int roll)
         {
              Console.WriteLine("roll number :-" + roll);
         }
           static void Main(string[] args)
        {
           student obj = new student();
            obj.info("sapana","SYBCA");
            obj.info(53);

          Console.ReadLine();
 }
  }
   }
