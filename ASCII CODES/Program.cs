using System;
using static System.Console;

namespace ASCII_CODES
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int X = 48; X <= 57; X++)
            { WriteLine(" ASCII ke {0} ={1} ", X, (char)X); }
            WriteLine();

            for (int X = 65; X <= 70; X++)
            { WriteLine(" ASCII ke {0} ={1} ", X, (char)X); }
            WriteLine();

            for (int X = 97; X <= 102; X++)
            { WriteLine(" ASCII ke {0} ={1} ", X, (char)X); }
            WriteLine();
            ReadKey();
        }
    }
}
