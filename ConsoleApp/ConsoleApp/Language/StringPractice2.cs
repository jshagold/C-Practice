using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Language
{
    internal class StringPractice2
    {

        public void Main()
        {
            // string.format, toString(), $, +, StringBuilder

            string name = "철수";
            int point = 300;

            Console.WriteLine(name + "고객님, " + point + "포인트 있습니다.");
            Console.WriteLine(string.Format("{0}고객님, {1}포인트 있습니다.", name, point));
            Console.WriteLine($"{name}고객님, {point}포인트 있습니다.");

            double sPoint = 1234.239;
            Console.WriteLine(Math.Round(sPoint, 2));
            Console.WriteLine(string.Format("{0:0.00}", sPoint));

            Console.WriteLine(string.Format("{0:C}", sPoint));
            string point2 = string.Format("{0:C}", sPoint);
            Console.WriteLine(point2.Replace(point2.Substring(0, 1), point2.Substring(0, 1) + " "));
            Console.WriteLine(string.Format("{0:D2}", 3));
            Console.WriteLine(string.Format("{0:N0}", 123123123));
            Console.WriteLine(Math.Abs(-1234511));
            Console.WriteLine((int)-11302.112);


            Console.WriteLine(3422221.ToString("N0"));

            StringBuilder sb = new StringBuilder();
            sb.Append(name);
            sb.Append("고객님, ");
            sb.Append(point);
            sb.Append("포인트 있습니다.");
            Console.WriteLine(sb.ToString());

        }

    }
}
