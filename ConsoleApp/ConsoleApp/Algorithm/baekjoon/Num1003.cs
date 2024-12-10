namespace ConsoleApp.Algorithm.baekjoon
{
    // https://www.acmicpc.net/problem/1003 - 피보나치 함수
    internal class Num1003
    {
        //static void Main(string[] args)
        //{
        //    int n = int.Parse(Console.ReadLine());
        //    for(int i = 0; i<n; i++)
        //    {
        //        int input = int.Parse(Console.ReadLine());
        //        //Solved(input);
        //        ImprovedSolved(input);
        //    }
        //}

        private static void Solved(int input)
        {
            if (input == 0)
            {
                Console.WriteLine($"1 0");
            }
            else if (input == 1)
            {
                Console.WriteLine($"0 1");
            }
            else
            {
                int[] zero = new int[input + 1];
                int[] one = new int[input + 1];

                zero[0] = 1;
                one[0] = 0;
                zero[1] = 0;
                one[1] = 1;

                for (int i = 2; i <= input; i++)
                {
                    zero[i] = zero[i - 1] + zero[i - 2];
                    one[i] = one[i - 1] + one[i - 2];
                }

                Console.WriteLine($"{zero[input]} {one[input]}");
            }
        }

        private static void ImprovedSolved(int input)
        {
            if (input == 0)
            {
                Console.WriteLine($"1 0");
            }
            else if (input == 1)
            {
                Console.WriteLine($"0 1");
            }
            else
            {
                int[] zero = new int[2];
                int[] one = new int[2];
                zero[0] = 1;
                one[0] = 0;
                zero[1] = 0;
                one[1] = 1;

                for (int i = 2; i <= input; i++)
                {
                    int nowZero = zero[0] + zero[1];
                    zero[0] = zero[1];
                    zero[1] = nowZero;

                    int nowOne = one[0] + one[1];
                    one[0] = one[1];
                    one[1] = nowOne;
                }

                Console.WriteLine($"{zero[1]} {one[1]}");
            }
        }
    }
}
