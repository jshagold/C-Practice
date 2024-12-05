using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class AsyncPractice
    {

        public async Task Main()
        {
            Console.WriteLine("\n\n\nAsync Practice");


            //ManualResetEventSlim task = new ManualResetEventSlim(false);

            //Thread worker = new Thread(() =>
            //{
            //    Console.WriteLine("Sub thread start...");
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Sub thread end...");
            //    task.Set();
            //});

            //worker.Start();

            int returnValue3 = await ServerSendAsync();


            Task<int> task2 = Task.Run(() =>
            {
                Console.WriteLine("Sub thread start...");
                Thread.Sleep(100);
                Console.WriteLine("Sub thread end...");

                return 42;
            });

            Task<int> task3 = Task.Run(ServerSend);



            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Main Thread..");
                Thread.Sleep(5);
            }

            int returnValue = await task2;
            int returnValue2 = task3.Result;

            Console.WriteLine($"Main Thread... End : {returnValue}\n returnValue2 : {returnValue2}");


        }

        static int ServerSend()
        {
            Console.WriteLine("Sub thread start...");
            Thread.Sleep(10);
            Console.WriteLine("Sub thread end...");

            return 22222;
        }

        static async Task<int> ServerSendAsync()
        {

            Console.WriteLine("Sub thread start...");
            Thread.Sleep(100);
            Console.WriteLine("Sub thread end...");

            return 9999;
        }
    }
}
