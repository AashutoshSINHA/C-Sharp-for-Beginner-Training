using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysecondCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            //Console.WriteLine("Hello Aashutosh");
            //Console.WriteLine("I love C# Sharp");
            ////Console.WriteLine("I am a Computer Science");
            //Console.WriteLine("Enter Your Name");
            //string name = Console.ReadLine();
            //Console.WriteLine("How many do you want " + name);
            //string can = Console.ReadLine();
            //Console.WriteLine("You will get 4 more candy" + (Convert.ToString(can)+4));


            //operators in c#
            //1.Arthmetic operators
            //2. Assignment operators
            //3. Logical opertors
            //4. Comparison opertors


            ////1.Arthmetic operators
            //int a = 5;
            //int b = 10;
            //Console.WriteLine("Your add value is: " + (a + b));
            //Console.WriteLine("Your sub value is: " + (a - b));
            //Console.WriteLine("Your multiply value is: " + (a * b));
            //Console.WriteLine("Your divide value is: " + (a / b));
            //Console.WriteLine("Your percentage value is:" + (a % b));



            ////2. Assignment operators
            //int a = 10;
            //int b = a;
            //b += 6;
            //Console.WriteLine(b);

            //3. Logical opertors
            //Console.WriteLine(true && false);
            //Console.WriteLine(true && false);
            //Console.WriteLine(true && false);
            //Console.WriteLine(true && false);

            //Console.WriteLine(true || false);
            //Console.WriteLine(false|| false);
            //Console.WriteLine(true || false);
            //Console.WriteLine(!false);


            //4. Comparison opertors

            //Console.WriteLine(10 > 5);
            //Console.WriteLine(10 > 5);
            //Console.WriteLine(10 > 10);
            //Console.WriteLine(8 > 9);
            //Console.WriteLine(1 > 5);
            //Console.WriteLine(38 > 5);



            //Math Operator

            //int a = Math.Min(37 , 108);
            //Console.WriteLine(a);
            //int b = Math.Max(37, 108);
            //String b = "Hello World";
            //Console.WriteLine(b.Length);
            //Console.WriteLine(b.ToUpper());
            //Console.WriteLine(b.ToLower());


            //String Interpollution
            //String name = Console.ReadLine();
            //String candy = Console.ReadLine();
            //Console.WriteLine($"Your name Is {name}. You will get {candy} candies.");




            //string Dame = "I am a Computer Science";
            //Console.WriteLine(Dame[0]);
            //Console.WriteLine(Dame.IndexOf("Computer"));




            //if-else statement
            //Console.WriteLine("Enter Your Age");
            //String ageraja = Console.ReadLine();
            //int age = Convert.ToInt32(ageraja);
            //bool isBanned = true;
            //if (age < 18 && isBanned )
            //{
            //    Console.WriteLine("You can drive:");
            //}
            //else if (age < 10)
            //{
            //    Console.WriteLine("Please do not drive.");
            //}
            //else if (age < 40)
            //{
            //    Console.WriteLine("You Can Drives");
            //}
            //else if (age < 10)
            //{
            //    Console.WriteLine("Please do not drive.");
            //}
            //else
            //{
            //    Console.WriteLine("You cannot drive:");
            //}




            //LOOP
            int i = 0;
            while(i < 5000)
               {
                    Console.WriteLine(i + 5 );
                    i++;
                }
            Console.ReadLine();
        }
    }
}
