using System;

namespace Code
{
    public class Program
    {
        public static void Main()
        {

        }
        public static void TakeInput(int[] outInput, int length)
        {
            for (int i = 0; i < length; i++)
            {
                outInput[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}