namespace ConsoleApp.Algorithm.baekjoon
{
    // https://www.acmicpc.net/problem/1012 - 유기농 배추
    internal class Num1012
    {
        //static void Main(string[] args) 
        //{
        //    int n = int.Parse(Console.ReadLine());

        //    for (int i = 0; i < n; i++) 
        //    {
        //        string[] s = Console.ReadLine().Split();

        //        int[ , ] board = new int[int.Parse(s[1]), int.Parse(s[0])];
        //        int[,] map = new int[int.Parse(s[1]), int.Parse(s[0])];
        //        int count = 0;

        //        int w = int.Parse(s[2]);
        //        for (int j = 0; j < w; j++)
        //        {
        //            string[] ws = Console.ReadLine().Split();
        //            board[int.Parse(ws[1]), int.Parse(ws[0])] = 1;
        //        }


        //        for (int j = 0; j < board.GetLength(0); j++)
        //        {
        //            for(int k = 0; k < board.GetLength(1); k++)
        //            {
        //                if (board[j, k] == 1 && map[j, k] == 0)
        //                {
        //                    count++;
        //                    Dfs((j, k), board, map, count);
        //                }
        //            }
        //        }

        //        Console.WriteLine(count);

        //    }
        //}


        static void Dfs((int, int) coordinate, int[,] board, int[,] map, int count)
        {
            map[coordinate.Item1, coordinate.Item2] = count;
            if (coordinate.Item1 > 0 && board[coordinate.Item1-1, coordinate.Item2] == 1 && map[coordinate.Item1 - 1, coordinate.Item2] == 0)
            {
                Dfs((coordinate.Item1 - 1, coordinate.Item2), board, map, count);
            }
            if (coordinate.Item2 > 0 && board[coordinate.Item1, coordinate.Item2 - 1] == 1 && map[coordinate.Item1, coordinate.Item2 - 1] == 0)
            {
                Dfs((coordinate.Item1, coordinate.Item2 - 1), board, map, count);
            }
            if (coordinate.Item1 < board.GetLength(0)-1 && board[coordinate.Item1 + 1, coordinate.Item2] == 1 && map[coordinate.Item1 + 1, coordinate.Item2] == 0)
            {
                Dfs((coordinate.Item1 + 1, coordinate.Item2), board, map, count);
            }
            if (coordinate.Item2 < board.GetLength(1)-1 && board[coordinate.Item1, coordinate.Item2 + 1] == 1 && map[coordinate.Item1, coordinate.Item2 + 1] == 0)
            {
                Dfs((coordinate.Item1, coordinate.Item2 + 1), board, map, count);
            }
        }



    }
}
