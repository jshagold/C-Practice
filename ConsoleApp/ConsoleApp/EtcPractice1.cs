using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Inheritance;

namespace ConsoleApp
{

    struct ItemInfo2
    {
        public int Id;
        public string Name;

        public ItemInfo2(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    internal class EtcPractice1
    {
        private static Dictionary<int, string> dic = new Dictionary<int, string>();



        private enum ITEM_TYPE
        {
            none = 0,
            nomal = 1,
            rare = 2,
            unique = 3,
        }


        public void Main()
        {
            Console.WriteLine("\n\n\nEtc Practice 1");
            // object, dictionary, enum control, struct, consolas


            // object
            int intValue = 42;
            object obj = intValue; // boxing
            int inValue2 = (int) obj; // unboxing
            // boxing, unboxing 은 성능적으로 별로 안좋음 -> Generic 사용을 추천

            MainActor actor = new MainActor("test");
            object obj2 = actor;

            SetValue<int>(intValue);
            SetValue<Actor>(actor);


            // dictionary -> key, value
            dic.Add(100, "iron sword");
            dic.Add(101, "wood sword");
            dic.Add(102, "gold sword");

            string value = string.Empty;
            if(dic.ContainsKey(100))
            {
                value = dic[100];
            }
            Console.WriteLine(value);

            foreach (KeyValuePair<int, string> pair in dic)
            {
                Console.WriteLine($"item key: {pair.Key}");
                Console.WriteLine($"item value: {pair.Value}");
            }


            // enum Control
            // ITEM_TYPE : 3
            ITEM_TYPE iTEM_TYPE = (ITEM_TYPE)3;
            ITEM_TYPE iTEM_TYPE2 = (ITEM_TYPE)10;
            int itemType = (int)ITEM_TYPE.nomal;
            Console.WriteLine($"iTEM_TYPE : {iTEM_TYPE}");
            Console.WriteLine($"iTEM_TYPE : {iTEM_TYPE2}");
            Console.WriteLine($"itemType : {itemType}");

            if(Enum.IsDefined(typeof(ITEM_TYPE), 3))
            {
                Console.WriteLine("isContains!");
            }

            foreach(var item in Enum.GetValues(typeof(ITEM_TYPE)))
            {
                Console.WriteLine(item);
            }


            // struct
            ItemInfo2 itemInfo = new ItemInfo2(100, "ironsword");
            ItemInfo2 itemInfo2 = itemInfo;

            int itemInfo = 0l
        }

        static void SetValue<T>(T obj)
        {
            Console.WriteLine(obj); 
        }
    }
}
