using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Data_type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaration of variables
            string name = "Charlie";
            int age = 28;
            bool isTall = true;
            double weight = 68.1;
            char initial = 'C';
            Console.WriteLine("His name is " + name + " he is " + age + " it is " + isTall + " that he is tall");
            Console.WriteLine("His weight in Kgs is " + weight + " his initials is " + initial);


            name = "Thato";
            age = 25;
            isTall = true;
            weight = 55.8;
            initial = 'T';
            Console.WriteLine("His name is " + name + " he is " + age + " it is " + isTall + " that he is tall");
            Console.WriteLine("His weight in Kgs is " + weight + " his initials is " + initial);

            //freeze the console
            Console.ReadLine ();


        }
    }
}
