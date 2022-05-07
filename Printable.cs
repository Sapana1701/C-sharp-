using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace printtable_const
{
 class Program
 {
 public int a;
 Program(int num)
 {
 a = num;
 for(int i=1; i<=10; i++)
 {
 Console.WriteLine(a + "x" + i + "=" + 
(a * +i));
 }
 }
 Program()
{
 Console.WriteLine("Destructor called");
 Console.ReadLine();
 }
 static void Main(string[] args)
 {
 Console.WriteLine("Enter the Number print 
table:-");
 int a = 
Convert.ToInt32(Console.ReadLine());
 Program p1 = new Program(a);
 Console.ReadLine();
 
 }
 }
}
