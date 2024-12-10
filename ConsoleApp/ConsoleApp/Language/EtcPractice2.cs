using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Language
{
    class ItemInfoComparer : IComparer<ItemInfo3>
    {
        public int Compare(ItemInfo3 x, ItemInfo3 y)
        {
            return x.Id.CompareTo(y.Id);
        }
    }

    class ItemInfo3
    {
        public readonly int Id;
        public readonly string Name;

        public ItemInfo3(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    internal class EtcPractice2
    {
        public void Main()
        {
            Console.WriteLine("\n\n\nEtc Practice2");

            // 상속(new, sealed, override), goto, 정렬, 다차원배열

            // goto
            Console.WriteLine("start");
            goto start;

            Console.WriteLine("starting..");

        start:

            Console.WriteLine("end");


            // 정렬
            //List<int> ints = new List<int>();
            //ints.Add(188);
            //ints.Add(201);    
            //ints.Add(132);    
            //ints.Add(44);
            //ints.Sort();
            //foreach (int i in ints)
            //{
            //    Console.WriteLine(i);
            //}
            List<ItemInfo3> itemInfos = new List<ItemInfo3>()
            {
                new ItemInfo3(100, "iron sword"),
                new ItemInfo3(102, "gold sword"),
                new ItemInfo3(90, "wood sword"),
            };
            //itemInfos.Add(new ItemInfo3(100, "iron sword"));
            //itemInfos.Add(new ItemInfo3(102, "gold sword"));
            //itemInfos.Add(new ItemInfo3(190, "wood sword"));

            itemInfos.Sort(new ItemInfoComparer());
            foreach (ItemInfo3 itemInfo in itemInfos)
            {
                Console.WriteLine($"{itemInfo.Id},  {itemInfo.Name}");
            }


            // 다차원 배열
            //int[,] arrDemension = new int[3, 4]; // 3행 4열
            int[,] arrDemension =
            {
                { 0, 1, 2, },
                { 3, 4, 5, },
                { 5, 6, 7, },
            };
            Console.WriteLine(arrDemension[1, 2]);
            Console.WriteLine(arrDemension.Length); // 길이 9
            Console.WriteLine(arrDemension.GetLength(0)); // 행 3
            Console.WriteLine(arrDemension.GetLength(1)); // 열 3

            int[][] arrD = new int[3][];
            arrD[0] = new int[] { 1, 2, 3 };
            arrD[1] = new int[] { 1, 2, 3, 4, 5, 6 };
            arrD[2] = new int[2] { 1, 2 };
        }
    }
}
