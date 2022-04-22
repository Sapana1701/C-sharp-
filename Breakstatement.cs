using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace printnum
{
 class Program
 {
 static void Main(string[] args)
 {
 int i;
 for (i = 1; i<= 10; i++)
 {
 if (i % 2 == 0)
 {
 Console.WriteLine(i);
 if (i == 6)
{
 break;
 }
 }
 }
 Console.ReadLine();
 }
 }
}
