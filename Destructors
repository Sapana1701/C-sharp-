using System;
using System.Collections.Generic;
using System.Linq;
using System.Text

namespace destructor
{
 class Program
 {
 
 Program(int n)
 {
 Console.WriteLine("The table of" +n+ "is");
 for(int i=1; i<=10; i++)
 {
 Console.WriteLine(i *n);
 
 }
 }
 ~Program()
 {
 Console.WriteLine("Destructor 
called......");
 Console.ReadLine();
 }
 static void Main(string[] args)
 {
 int n;
 Console.WriteLine("Enter the Number print 
table:-");
 n= Convert.ToInt32(Console.ReadLine());
 Program p1 = new Program(n);
 Console.ReadLine();
 
 }
 }
}
