using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class LambdaPractice
    {
        public void Main()
        {
            Console.WriteLine("\n\n\nLambda Practice");

            Action<int> action = PrintActorCount;
            Action<int> action2 = (int actorCount) => Console.WriteLine(actorCount);
            Action<int> action3 = (actorCount) => Console.WriteLine(actorCount);
            Action<int> action4 = (actorCount) =>
            {
                Console.WriteLine(actorCount);
            };

            Func<int, bool> func = IsActorCountCheck;
            Func<int, bool> func2 = (int actorCount) => actorCount > Inheritance.Config.VAILD_ACTOR_COUNT;
            Func<int, bool> func3 = (int actorCount) => 
            {
                return actorCount > Inheritance.Config.VAILD_ACTOR_COUNT;
            };

            SendServer((actorCount) => Console.WriteLine(actorCount));
        }

        private static void PrintActorCount(int actorCount) => Console.WriteLine(actorCount);

        private static bool IsActorCountCheck(int actorCount) => actorCount > Inheritance.Config.VAILD_ACTOR_COUNT;

        private static void SendServer(Action<int> action)
        {
            Console.WriteLine("server request");
            action(3000);
        }
    }
}
