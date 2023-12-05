using System;

namespace Solution
{
    public class Solve
    {
        public static void TakeInput(int[] readInput, int[] outInput)
        {
            for (int i = 0; i < readInput.Length; i++)
            {
                outInput[i] = readInput[i];
                Console.Write($"{outInput[i]}, ");
            }
            Console.WriteLine("");
        }

        public static void TakeInput2D(int row, int colum, int[,] outInput, int length)
        {
            int rowProgress = 0;
            int columProgress = 0;
            for (int i = 0; i < row * colum; i++)
            {
                if (i == row - 1)
                {
                    columProgress++;
                    rowProgress = 0;
                }

            }
        }

        public static void Lesson8(int[] arrInput) // Dãy đơn điệu
        {
            int lenInput = arrInput.Length;
            int[] arr = new int[lenInput];
            TakeInput(arrInput, arr);

            for (int i = 0; i < arr.Length - 1; i++)
            {
                bool realCase = arr[1] > arr[0] ? true : false;
                if (realCase != (arr[i + 1] > arr[i]))
                {
                    Console.Write("NO");
                    return;
                }
            }
            Console.Write("YES");
        }

        public static void Lesson9(int[] arrInput1, int[] arrInput2)
        {
            int tracking = 0;
            int lenInput1 = arrInput1.Length;
            int lenInput2 = arrInput2.Length;
            int[] arr1 = new int[lenInput1];
            int[] arr2 = new int[lenInput2];
            int[] resultArr = new int[lenInput1 + lenInput2];
            TakeInput(arrInput1, arr1);
            TakeInput(arrInput2, arr2);
            for (int i = 0; i < lenInput1; i++)
            {
                resultArr[tracking] = arr1[i];
                tracking++;
            }
            for (int i = 0; i < lenInput2; i++)
            {
                resultArr[tracking] = arr2[i];
                tracking++;
            }
            Array.Sort(resultArr);
            for (int i = 0; i < resultArr.Length; i++)
            {
                Console.Write($"{resultArr[i]} ");
            }
        }
        public static void Lesson10()



    }
}