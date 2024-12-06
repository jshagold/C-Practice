using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class OperatorPractice
    {
        public class Charactor
        {
            public readonly int Hp;
            public readonly int Power;

            public Charactor(int hp, int power)
            {
                Hp = hp;
                Power = power;
            }

            public static Charactor operator + (Charactor a, Charactor b)
            {
                return new Charactor(hp: a.Hp + b.Hp, power: a.Power + b.Power);
            }

            //public static explicit operator int (Charactor a)
            //{
            //    return a.Hp + a.Power;
            //}

            public static implicit operator int (Charactor a)
            {
                return a.Hp + a.Power;
            }
        }


        public void Main()
        {
            Console.WriteLine("\n\n\nOperator Practice");

            Charactor charactorA = new Charactor(hp: 100, power: 10);
            Charactor charactorB = new Charactor(hp: 80, power: 20);

            Charactor charactorTotal = charactorA + charactorB;
            Console.WriteLine($"total Hp: {charactorTotal.Hp} total power: {charactorTotal.Power}");

            //int totalStatus = (int)charactorA;
            int totalStatus = charactorA;
            Console.WriteLine($"total status:{totalStatus}");

        }
    }
}
