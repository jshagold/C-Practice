using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class StringPractice
    {

        static void Main(string[] args)
        {
            // Contains, Replace, Trim, ToLower, SubString, IndexOf, Split
            string letter = "  친구야 잘 지내니  ";

            bool isContains = letter.Contains("지내");
            Console.WriteLine($"Contains {isContains}");

            string replace = letter.Replace("친구", "야야");
            Console.WriteLine($"Replace: {replace}");

            string trim = letter.Trim();
            Console.WriteLine($"Trim: {trim}");

            string letterEN = "   Hi my friend  ";
            string toLower = letterEN.ToLower();
            string toUpper = letterEN.ToUpper();
            Console.WriteLine($"toLower: {toLower}");
            Console.WriteLine($"toUpper: {toUpper}");

            int indexOfNum = letter.IndexOf("잘");
            Console.WriteLine($"indexOf: {indexOfNum}");

            string subString = letter.Substring(indexOfNum, 3);
            Console.WriteLine($"subString: {subString}");

            string friends = "ㅁ,ㄴ,ㅇ,ㄹ/ㅂ,ㅈ,ㄷ";
            string[] friendGroup = friends.Split('/');
            foreach (string friendGroupItem in friendGroup)
            {
                Console.WriteLine($"item: {friendGroupItem}");
                string[] eachFriend = friendGroupItem.Split(",");
                Console.WriteLine("Split:");
                foreach (string eachFriendItem in eachFriend)
                {
                    Console.WriteLine($"eachFriend: {eachFriendItem}");
                }
            }


        }


    }
}
