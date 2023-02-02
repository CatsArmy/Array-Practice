using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_WIth_Arrays
{
    public class Class1
    {
        public static void PrintArr(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
        public static double AvgArr(int[] a)
        {
            double sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            return sum / a.Length;
        }
        public static int SumArr(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            return sum;
        }
        public static int MulArr(int[] a)
        {
            int mul = 1;
            for (int i = 0; i < a.Length; i++)
            {
                mul *= a[i];
            }
            return mul;
        }
        public static void Odd2EvenArr(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                {
                    a[i] = a[i] * 2;
                }
            }
        }
        public static void DivNumArr(int[] a, int num)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % num == 0)
                {
                    Console.WriteLine(a[i]);
                }
            }
        }
        public static int IndexMax(int[] a)
        {
            int maxIndex = 0;
            int maxValue = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > maxValue)
                {
                    maxValue = a[i];
                    maxIndex = i;
                }
            }
            return maxIndex;
        }
        public static int GetMin(int[] a)
        {
            int min = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            return min;
        }
        public static bool IsAscendingOrder(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] >= a[i + 1])
                {
                    return false;
                }
            }

            return true;
        }
        public static int ContainNumberCounter(int[] a, int value)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == value)
                {
                    count++;
                }
            }
            return count;
        }
        public static bool ContainsNumber(int[] a, int value)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == value)
                {
                    return true;
                }
            }

            return false;
        }
        public static int SumAppearanceCounter(int[] a, int value)
        {
            int count = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == value)
                {
                    count++;
                }
            }
            return count;
        }
    }
}