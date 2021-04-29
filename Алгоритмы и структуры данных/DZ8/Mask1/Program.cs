using System;
using System.Collections.Generic;

namespace Mask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] test = new int[100];
            for (int i = 0; i < test.Length; i++)
            {
                test[i] = rnd.Next(1000, 10000);
                Console.WriteLine(test[i]);
            }
            test = CountBlockSort(test);
            for(int i = 0; i < test.Length; i++)
            {
                Console.WriteLine(test[i]);
            }
        }
        static public int[] CountBlockSort(int[] array)
        {
            //////////////////////////////////
            ///поиск максимального и минимального числа
            int min = array[0];
            int max = array[array.Length - 1];
            for(int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > max)
                    max = array[i];
                else if (array[i] < min)
                    min = array[i];
            }
            ///////////////////////////////////
            /// создаю блоки в виде стеков (в моем случае 5 штук)
            int variable = (max - min) / 5; // средний диапазон блока

            var one = new Stack<int>();     // название блока
            int one1 = min;                 // значение от:
            int one2 = min + variable - 1;  // значение до:

            var two = new Stack<int>();
            int two1 = one1 + variable;
            int two2 = one2 + variable;

            var three = new Stack<int>();
            int three1 = two1 + variable;
            int three2 = two2 + variable;

            var four = new Stack<int>();
            int four1 = three1 + variable;
            int four2 = three2 + variable;

            var five = new Stack<int>();
            int five1 = four1 + variable;
            int five2 = max;
            /////////////////////////////////
            /// заполняю блоки.
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= one1 && array[i] <= one2)
                {
                    one.Push(array[i]);
                }
                else if (array[i] >= two1 && array[i] <= two2)
                {
                    two.Push(array[i]);
                }
                else if (array[i] >= three1 && array[i] <= three2) 
                {
                    three.Push(array[i]);
                }
                else if (array[i] >= four1 && array[i] <= four2)
                {
                    four.Push(array[i]);
                }
                else
                {
                    five.Push(array[i]);
                }
            }
            ///////////////////////////////////
            /// конвертирую стеки в массивы и сортирую подсчетом
            var array1 = SimpleCountingSort(Convert(one), one1, one2);
            var array2 = SimpleCountingSort(Convert(two), two1, two2);
            var array3 = SimpleCountingSort(Convert(three), three1, three2);
            var array4 = SimpleCountingSort(Convert(four), four1, four2);
            var array5 = SimpleCountingSort(Convert(five), five1, five2);
            ///////////////////////////////////
            /// заполняю массив.
            int b = 0;
            for (int i = 0; i < array1.Length; i++)
                array[b++] = array1[i];

            for (int i = 0; i < array2.Length; i++)
                array[b++] = array2[i];

            for (int i = 0; i < array3.Length; i++)
                array[b++] = array3[i];

            for (int i = 0; i < array4.Length; i++)
                array[b++] = array4[i];

            for (int i = 0; i < array5.Length; i++)
                array[b++] = array5[i];
            return array;
        }
        static public int[] SimpleCountingSort(int[] array, int min, int max)
        {
            int[] countArray = new int[max - min+1];
            for (int i = 0; i < array.Length; i++)
                countArray[array[i]-min]++;
            var b = 0;
            for (int j = 0; j < countArray.Length; j++)
            {
                for (int i = 0; i < countArray[j]; i++)
                    array[b++] = j + min;
            }
            return array;
        }
        static public int[] Convert(Stack<int> stack)
        {
            var array = new int[stack.Count];
            for(int i =0; i < array.Length; i++)
            {
                array[i] = stack.Pop();
            }
            return array;
        }
    }
}
