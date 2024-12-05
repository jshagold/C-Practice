using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using ConsoleApp.Inheritance;

namespace ConsoleApp
{

    class ItemTable
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string Desc { get; set; }
    }

    internal class ReflectionPractice
    {
        public void Main()
        {
            Console.WriteLine("\n\n\nReflection Practice");

            MainActor mainActor = new MainActor("Jin");
            Type type = mainActor.GetType();
            type.GetProperties();
            PropertyInfo[] propertyInfos = type.GetProperties();
            foreach (var item in propertyInfos)
            {
                Console.WriteLine($"{item.PropertyType}, {item.Name}");
            }
            MethodInfo[] methodInfos = type.GetMethods();
            foreach (var method in methodInfos)
            {
                Console.WriteLine($"{method.ReturnType}, {method.Name}");
            }

            Console.WriteLine("\n");

            string[] strings = { "itemId", "itemName", "desc" };
            string[] values = { "3", "Gun", "Super Super Powerful Gun" };

            ItemTable itemtable = new ItemTable();
            PropertyInfo[] propertyInfos2 = itemtable.GetType().GetProperties();
            foreach (var propertyInfo in propertyInfos2)
            {
                Console.WriteLine($"{propertyInfo.PropertyType}, {propertyInfo.Name}");

                for (int i = 0; i < strings.Length; i++)
                {
                    if(strings[i].ToLower() == propertyInfo.Name.ToLower())
                    {
                        if(propertyInfo.PropertyType == typeof(int))
                        {
                            propertyInfo.SetValue(itemtable, int.Parse(values[i]));
                        }
                        else
                        {
                            propertyInfo.SetValue(itemtable, values[i]);
                        }
                    }

                }
            }

            Console.WriteLine($"ItemId : {itemtable.ItemId}, ItemName : {itemtable.ItemName}, Desc : {itemtable.Desc}");


        }
    }
}
