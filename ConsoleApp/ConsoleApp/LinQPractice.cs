using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Info
    {
        public int Money { get; private set; }
        public string Name { get; private set; }
        public Info(int money, string name)
        {
            this.Money = money;
            this.Name = name;
        }
    }

    class ItemInfo
    {
        public string Name { get; private set; }

        public ItemInfo(string name)
        {
            this.Name = name;
        }

    }

    internal class LinQPractice
    {
        public void Main() 
        {
            Console.WriteLine("\n\n\nLinQ Practice");
            
            // LinQ - where, OrderBy, First, Max, Select
            List<int> ints = new List<int>();
            ints.Add(1);
            ints.Add(2);
            ints.Add(3);
            ints.Add(4);
            ints.Add(5);
            ints.Add(6);
            ints.Add(7);
            ints.Add(8);
            ints.Add(9);
            ints.Add(10);

            List<int> intOver = new List<int>();
            foreach (int i in ints)
            {
                if(i > 5)
                    intOver.Add(i);
            }

            Func<int, bool> func = (int value) => value >= 5;

            // Where

            ints.Where((int value) => value >= 5);
            ints.Where(value => value >= 5);
            ints.Where(func);
            ints.Where(CheckOverValue);
            IEnumerable<int> enumerable = ints.Where(v => v>=5);
            foreach (int i in enumerable)
            {
                Console.WriteLine(i);
            }
            int value = ints.Where(v => v>=5).FirstOrDefault();
            Console.WriteLine($"value:{value}");


            List<Info> infos = new List<Info>();
            infos.Add(new Info(money: 1, name: "take"));
            infos.Add(new Info(money: 2, name: "take"));
            infos.Add(new Info(money: 3, name: "take"));
            infos.Add(new Info(money: 4, name: "take"));
            infos.Add(new Info(money: 5, name: "take"));
            infos.Add(new Info(money: 6, name: "take"));
            infos.Add(new Info(money: 7, name: "take"));
            infos.Add(new Info(money: 8, name: "take"));
            infos.Add(new Info(money: 9, name: "take"));
            infos.Add(new Info(money: 10, name: "take"));

            IEnumerable<Info> enumerable2 =  infos.Where(v => v.Money >= 5);
            foreach (Info i in enumerable2)
            {
                Console.WriteLine($"money:{i.Money} name:{i.Name}");
            }

            // OrderBy
            Info[] infos1 = infos.OrderByDescending(v => v.Money).ToArray();
            int v = infos.Max(v => v.Money);

           
            // Select
            var enumerable3 = infos.Select(v => new { N = v.Name, M = v.Money }).ToList();

            var enumerable4 = infos.Select(v => new ItemInfo(name: v.Name)).FirstOrDefault();

        }

        private static bool CheckOverValue(int value)
        {
            return value >= 5;
        }


    }
}
