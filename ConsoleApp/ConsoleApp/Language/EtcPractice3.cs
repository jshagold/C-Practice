using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public partial class ItemInfoEtc3
    {
        public int ItemId { get; set; }

        public ItemInfoEtc3()
        {
            Console.WriteLine("기본 생성자.");
        }

        public ItemInfoEtc3(int itemId) : this()
        {
            ItemId = itemId;
            Console.WriteLine("itemId를 받는 생성자.");
        }

        ~ItemInfoEtc3()
        {
            Console.WriteLine("종료자");
        }
    }

    public partial class ItemInfoEtc3
    {
        public void PrintItemId()
        {

        }
    }

    public class CharacterInfo
    {
        //public required int CharId { get; init; }
        //public readonly int CharId = 1;


        //private readonly int charId; // 1
        //public readonly int CharId; // 2
        public required int CharId { get; init; } // 2 
        //public int CharId { get; private set; } // 3
        //public int CharId { get; set;} // 4

        //public void SetCharacterId(int charId)
        //{
        //    this.CharId = charId;
        //}


    }

    internal class EtcPractice3
    {
        public void Main()
        {
            Console.WriteLine("\n\n\nEtc Practice3");
            // class (종료자(Finalizer), this() 생성자, 분할 클래스), 프로퍼티 (init, required), 튜플

            //ItemInfoEtc3 itemInfo = new ItemInfoEtc3(1);
            //itemInfo.PrintItemId();


            // 프로퍼티
            CharacterInfo characterInfo = new CharacterInfo() { CharId = 32 };
            Console.WriteLine(characterInfo.CharId);


            // 튜플
            //(int,int) peopleInfo = (a: 1, b: 2);
            var peopleInfo = PrintPeopleInfo();
            Console.WriteLine(peopleInfo.a);
            Console.WriteLine(peopleInfo.b);

        }

        static (int a, int b) PrintPeopleInfo()
        {
            return (1, 2);
        }
    }
}
