using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class ResourcesLoad : IDisposable
    {
        public ResourcesLoad()
        {
            Console.WriteLine("생성자");
        }

        public void Connect()
        {
            Console.WriteLine("리소스 연결");
        }

        public void Disconnect()
        {
            Console.WriteLine("리소스 해제");
        }

        public void Dispose()
        {
            Disconnect();
        }
    }

    public class ItemInfoEtc4
    {
        public int[] ItemIds { get; init; }


        public ItemInfoEtc4(int[] itemIds)
        {
            ItemIds = itemIds;
        }

        public int this[int index]
        {
            get 
            { 
                return ItemIds[index];
            }
            set
            {
                ItemIds[index] = value;
            }
        }
    }

    public static class IntegerExtension
    {
        public static int Power(this int myInt, int mag)
        {
            return myInt * mag;
        }
    }

    internal class EtcPractice4
    {

        public void Main()
        {
            Console.WriteLine("\n\n\nEtc Practice4");
            // using dispose, 인덱서, try catch추가, 확장 메서드


            // using dispose
            
            //ResourcesLoad resourcesLoad = new ResourcesLoad();
            //resourcesLoad.Connect();
            //Console.WriteLine("리소스 사용..");
            //Console.WriteLine("리소스 사용..");
            //Console.WriteLine("리소스 사용..");
            //Console.WriteLine("리소스 사용..");
            //resourcesLoad.Disconnect();

            using (ResourcesLoad resourcesLoad = new ResourcesLoad())
            {
                resourcesLoad.Connect();
                Console.WriteLine("리소스 사용....");
            }


            // 인덱서

            int[] ints = new int[] { 1, 2, 3, 4 };
            ItemInfoEtc4 itemInfo = new ItemInfoEtc4(ints);
            itemInfo[0] = 1000;
            Console.WriteLine(itemInfo[0]);


            // try catch
            try
            {
                PrintMessage();
            }
            catch (Exception e)
            {
                Console.WriteLine("오류처리 완료");
                Console.WriteLine($"message : {e}");
            }


            // 확장 메소드
            int a = 1;
            Console.WriteLine(a.Power(2));
            Console.WriteLine(100.Power(3));

        }

        static void PrintMessage()
        {
            try
            {
                PrintDetailMessage();
            } 
            catch (Exception e)
            {
                Console.WriteLine("PrintMessage 오류처리");
                throw;
            }
            
        }

        static void PrintDetailMessage()
        {
            throw new Exception();
        }
    }
}
