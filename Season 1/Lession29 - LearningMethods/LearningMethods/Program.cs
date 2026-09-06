using System;

// ReSharper disable SwapViaDeconstruction

namespace LearningMethods
{
    internal class Program
    {
        // 解决访问权限问题的方法：
        // 1. 加 public
        // 2. 同时保持 private
        // 我现在反过来，在枚举类型前面加上 public
        public enum SortMethod
        {
            ASC,
            DESC
        }

        public static void Main(string[] args)
        {
            int[] numbers1 = { 10, 678, 12, 5, 12, 67, 9, 88, 100 };
            
            BubbleSort(numbers1, SortMethod.ASC);
            BubbleSort(numbers1, SortMethod.DESC);
            
            int[] numbers2 = { 18, 19, 1, 2, 6, 8, 6, 10, 234, 11, 89, 76, 99, 28 };
            
            BubbleSort(numbers2, SortMethod.ASC);
            BubbleSort(numbers2, SortMethod.DESC);

            Console.ReadKey();
        }

        // 目前这个方法，对数组的排序方式，还是写死的
        // 语法出错
        // 加上 public 之后，语法不出错
        // 同时保持 private，也不出错
        private static void BubbleSort(int[] numbers, SortMethod sortMethod)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - 1 - i; j++)
                {
                    // 目前只能实现降序排列
                    // 现在，来进行排序方式的区分
        
                    // 应该在方法里面，考虑如何优化代码
                    // 再来看一下，这块还有必要初始化为 false 吗？
                    // 没有了
                    // 下面的分支，不是 if 就是 else，这个变量一定会被初始化
                    // 三元表达式改写判断条件
                    // 变量 canSwap 和 if-else 分支，直接给省略了，特别方便

                    if (sortMethod == SortMethod.ASC ? numbers[j] > numbers[j + 1] : numbers[j] < numbers[j + 1])
                    {
                        int swapValue = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = swapValue;
                    }
                    
                    // bool canSwap;
                    //
                    // // 如果是升序排列
                    // if (sortMethod == SortMethod.ASC)
                    // {
                    //     // 外层 if 已经确认是升序排列了，才会走到这
                    //     // 然后，我再来看当前变量是不是较大元素
                    //     // 毕竟，升序排列，只看是否为较大元素
                    //     canSwap = numbers[j] > numbers[j + 1];
                    // }
                    //
                    // // 如果是降序排列
                    // else
                    // {
                    //     // 外层 if 已经确认是升序排列了，才会走到这
                    //     // 然后，我再来看当前变量是不是较小元素
                    //     // 毕竟，降序排列，只看是否为较小元素
                    //     canSwap = numbers[j] < numbers[j + 1];
                    // }
                    //
                    // // 而且还要注意一下变量的命名问题
                    // if (canSwap)
                    // {
                    //     // 现在，我只知道当前是要交换的值
                    //     // 不会再通过变量的命名来区分是较大值还是较小值了
                    //     int swapValue = numbers[j];
                    //     numbers[j] = numbers[j + 1];
                    //     numbers[j + 1] = swapValue;
                    // }
                }
            }
        
            // 提示用户，当前如何进行排序
            Console.WriteLine($"按照{(sortMethod == SortMethod.ASC ? "升序" : "降序")}");
        
            // 进行元素输出
            for (int i = 0; i < numbers.Length; i++)
            {
                // 这块还要修改一下，不然待会儿输出的效果不好看
                // Console.WriteLine(numbers[i]);
                Console.Write($"{numbers[i]}\t");
            }
        
            // 输出后换行
            Console.WriteLine();
        }

        // 对于重复的代码，我们有两种解决思路：
        // 1. 再写一个方法
        // 只用一次，以后用不到了，不要这么做；避免过度封装方法
        // private static void SwapValues(int[] numbers)
        // {
        //     
        // }

        // 有返回值的方法
        // private static int Add(int number1, int number2)
        // {
        //     int sum = number1 + number2;
        //
        //     // 语法出错
        //     // 系统无法判断，我们到底要把什么东西作为返回值
        //     // 需要手写一行
        //     // return 是一个系统保留关键字，它也属于流程控制语句中的代码跳转语句
        //     // 和 break, continue 那俩东西，属于同一类
        //     return sum;
        //
        //     // 代码变灰色
        //     // 因为 return 那行代码执行完之后，方法整个就结束了
        //     // return 后面的代码，永远都不会被执行
        //     Console.WriteLine(sum);
        // }

        // 无返回值的方法呢？
        // private static void SayHello()
        // {
        //     Console.WriteLine("Hello World!");
        //
        //     // return 在哪呢？
        //     // 其实就在最下面
        //
        //     // 但是写上它没有意义
        //     // 执行完上面的代码之后，没有其它代码了，自然会结束运行
        //     // 会给你自动 return
        //     // 这样还写它干嘛？
        //     return;
        //
        //     // 已经打印出去了，撤回不了了
        //     Console.WriteLine("紧急撤回一个 HelloWorld");
        // }
    }
}