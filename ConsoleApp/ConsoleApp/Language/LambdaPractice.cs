using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Language.Inheritance;

namespace ConsoleApp.Language
{
    internal class LambdaPractice
    {
        public void Main()
        {
            Console.WriteLine("\n\n\nLambda Practice");

            Action<int> action = PrintActorCount;
            Action<int> action2 = (actorCount) => Console.WriteLine(actorCount);
            Action<int> action3 = (actorCount) => Console.WriteLine(actorCount);
            Action<int> action4 = (actorCount) =>
            {
                Console.WriteLine(actorCount);
            };

            Func<int, bool> func = IsActorCountCheck;
            Func<int, bool> func2 = (actorCount) => actorCount > Config.VAILD_ACTOR_COUNT;
            Func<int, bool> func3 = (actorCount) =>
            {
                return actorCount > Config.VAILD_ACTOR_COUNT;
            };

            SendServer((actorCount) => Console.WriteLine(actorCount));
        }

        private static void PrintActorCount(int actorCount) => Console.WriteLine(actorCount);

        private static bool IsActorCountCheck(int actorCount) => actorCount > Config.VAILD_ACTOR_COUNT;

        private static void SendServer(Action<int> action)
        {
            Console.WriteLine("server request");
            action(3000);
        }
    }
}
