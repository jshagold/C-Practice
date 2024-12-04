using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Inheritance;

namespace ConsoleApp
{
    internal class Practice
    {
        static void Main(string[] args)
        {

            Console.WriteLine("StringPractice2");
            StringPractice2 sp2 = new();
            sp2.Main();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("DateTimePractice");
            DateTimePractice dtp = new DateTimePractice();
            dtp.Main();


            PropertyPractice propertyPractice = new PropertyPractice("name","value");
            propertyPractice.Main();
            Console.WriteLine(propertyPractice.Name);


            new DelegatePractice().Main();


            Program inheritancePractice = new Program();
            inheritancePractice.Main();
        }

    }
}
