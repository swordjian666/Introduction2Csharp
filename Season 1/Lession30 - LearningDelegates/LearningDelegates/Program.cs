using System;

// ReSharper disable SwapViaDeconstruction

namespace LearningDelegates
{
    internal class Program
    {
        /// <summary>
        /// 整型数组排序委托
        /// </summary>
        /// <param name="numbers">要排序的整型数组</param>
        private delegate void SortDelegate(int[] numbers);

        /// <summary>
        /// 运行委托
        /// </summary>
        private delegate void RunDelegate();

        /// <summary>
        /// 获取数字委托
        /// </summary>
        private delegate int GetNumberDelegate();

        public static void Main(string[] args)
        {
            // 升序排列
            // SortAndPrint(myNumbers, SortByASC);
            
            int[] myNumbers = { 1, 98, 2, 30, 25, 5, 30 };
            

            // 降序排列
            SortAndPrint(myNumbers, SortByDESC);

            // 如果直接调用方法的话，应该：
            // SortByASC(myNumbers);

            // 实际上，委托类型变量，可以【点】出来一个 Invoke 方法
            // 对于方法来说，invoke 这个单词的意思，就是：调用
            // 和上面这种 del1(myNumbers); 写法，是一样的
            // 上面那种简短的写法，它就是一个语法糖
            // del1.Invoke(myNumbers);

            // int[] myNumbers = { 1, 98, 2, 30, 25, 5, 30 };
            //
            // SortDelegate del1 = SortByASC;
            //
            // // 既然委托类型也能声明变量
            // // 那么，它能不能支持算术运算符呢？
            // del1 += SortByDESC;
            //
            // // 类似地，既然现在方法已经赋值给了委托类型的 del1 变量
            // // 是不是也可以：
            // del1(myNumbers);
            //
            // Console.WriteLine("排序后的数组元素：");
            //
            // foreach (int number in myNumbers)
            // {
            //     Console.Write($"{number}  ");
            // }
            //
            // Console.WriteLine();
            //
            // Console.ReadKey();

            // RunDelegate del1 = RunMethod1;
            // // += 符号的作用：订阅
            // del1 += RunMethod2;
            // del1 += RunMethod3;
            
            // 对应的，-= 符号，就是：取消订阅
            // del1 -= RunMethod3;

            // del1();
            //
            // Console.ReadKey();

            GetNumberDelegate del1 = GetNumber1;
            del1 += GetNumber2;
            del1 += GetNumber3;

            // 如何获取它的返回值？
            // 注意：要回归问题的本质
            int result = del1();
            
            Console.WriteLine(result);
            
            Console.ReadKey();
        }

        private static int GetNumber1()
        {
            int number1 = 10;
            int number2 = 0;

            // 将抛出异常
            // 看看其它方法还会不会执行
            int number3 = number1 / number2;
            
            return 10;
        }

        private static int GetNumber2()
        {
            return 20;
        }

        private static int GetNumber3()
        {
            return 30;
        }

        private static void RunMethod1()
        {
            Console.WriteLine("进入方法 1");
            Console.WriteLine("离开方法 1");
        }

        private static void RunMethod2()
        {
            Console.WriteLine("进入方法 2");
            Console.WriteLine("离开方法 2");
        }

        private static void RunMethod3()
        {
            Console.WriteLine("进入方法 3");
            Console.WriteLine("离开方法 3");
        }

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

        private static void SortByDESC(int[] numbers)
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
        }
    }
}