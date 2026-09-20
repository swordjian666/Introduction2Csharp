using System;

// ReSharper disable SwapViaDeconstruction

namespace LearningLambdaExpressions
{
    internal class Program
    {
        /// <summary>
        /// 整型数组排序委托
        /// </summary>
        /// <param name="numbers">要排序的整型数组</param>
        private delegate void SortDelegate(int[] numbers);

        public static void Main(string[] args)
        {
            // Lambda 表达式
            // 主要用途：编写一个匿名函数

            int[] myNumbers = { 1, 98, 20, 50, 35, 7, 35 };

            // 完整写法
            SortDelegate del = (numbers) =>
            {
                // 输出数组形参的长度
                Console.WriteLine($"当前数组的长度：{numbers.Length}");
            };

            // 上面的写法只有一行代码，说明代码作用域是可以被省略的
            SortDelegate del2 = numbers => Console.WriteLine($"当前数组的长度：{numbers.Length}");

            // 降序排列
            SortAndPrint(myNumbers, numbers =>
            {
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    for (int j = 0; j < numbers.Length - 1 - i; j++)
                    {
                        if (numbers[j] < numbers[j + 1])
                        {
                            int swapValue = numbers[j];
                            numbers[j] = numbers[j + 1];
                            numbers[j + 1] = swapValue;
                        }
                    }
                }
            });
        }

        private static int GetTen() => 10;

        // private static void DoWork() =>
        // {
        // }

        private static void DoWork() => Console.WriteLine();

        /// <summary>
        /// 讲整型数组中的元素排序，并输出其元素
        /// </summary>
        /// <param name="numbers">要排序的整型数组</param>
        /// <param name="sort">排序委托</param>
        private static void SortAndPrint(int[] numbers, SortDelegate sort)
        {
            // 这里我们并没有自己手动实现数组的排序算法
            sort(numbers);

            Console.WriteLine("排序后的数组元素：");

            foreach (int number in numbers)
            {
                Console.Write($"{number}  ");
            }

            Console.WriteLine();
        }

        private static void SortByASC(int[] numbers)
        {
            Array.Sort(numbers);
        }
    }
}