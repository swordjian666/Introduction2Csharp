using System;

namespace Course
{
    internal class Program
    {
        // 方法都要放在 class 下方的代码作用域中
        // 回顾：还有哪个东西可以放在这？
        // 是 枚举 enum 对吧？
        // 但是，枚举还可以放到别的地方，不止可以放在 class 下，后续我再进行补充

        // 实际上已经是现成的了，看这里
        // 我们一直编写代码的这个地方
        // 实际上就是一个方法
        // 现在，我们应该叫它：Main() 方法；或者 Main() 函数
        // Main() 方法放在哪？
        // 注意：返回值这个位置，只能有一种类型的变量
        // 要么只有一种，要么干脆没有
        // 没有的话，要写上 void 关键字；不可省略，否则报语法错误
        // 后面的括号里，可以填入参数（Arguments，简称 Args）
        // 参数的命名，依旧按照 camelCase 的规则
        public static void Main(string[] args)
        {
            // 方法的基本语法结构
            // AccessModifier (static) ReturnType MethodName(ArgumentType arg1, ArgumentType arg2)
            // {
            //     Some code
            // }

            // 这个东西看起来就比较复杂了，我们需要一个填充后的代码结构，来对其进行解析

            // 重新认识 Substring() 方法
            // 它的返回值是 string 类型
            // 了解了这部分新知识之后，我们应该把这段代码的行为，描述成：
            // Substring() 方法将字符串截取之后，返回一个 string 类型的返回值，将这个值，赋值给同为 string 类型的
            // result 变量
            // string result = "今天天气好晴朗".Substring(2);

            // int[] numbers1 = { 2, 4, 6, 8, 10 };
            // int[] numbers2 = { 1, 3, 5, 7, 9 };
            //
            // // 打印第一个数组中的元素
            // PrintNumbersOfArray(numbers1);
            //
            // // 我自己再输出一下，看看 numbers1 中的元素有没有变化
            // foreach (int number in numbers1)
            // {
            //     Console.Write($"{number}\t");
            // }
            //
            // Console.WriteLine();
            // Console.WriteLine();
            //
            // // 打印第二个数组中的元素
            // PrintNumbersOfArray(numbers2);
            //
            // // 我自己再输出一下，看看 numbers2 中的元素有没有变化
            // foreach (int number in numbers2)
            // {
            //     Console.Write($"{number}\t");
            // }
            //
            // Console.WriteLine();
            // Console.WriteLine();
            //
            // // 填入的 numbers1 和 numbers2 这两个参数，本身没发生变化
            //
            // Console.ReadKey();
        }

        // 都这样了，咱们还往里面传什么参数
        public static void PrintNumbersOfArray()
        {
            // 现在，来修改方法
            // 在方法中，对参数进行重新赋值

            // int[] newArray = { 10, 20, 30, 50, 90 };
            // 方法中的参数，发生了变化
            // 这种写法，已经没必要定义参数了
            // targetArray = newArray;
            
            // 和下面这种写法没区别：
            int[] targetArray = { 10, 20, 30, 50, 90 };
            
            // 无论我在外面调用这个方法的时候，填入了什么实参，都不影响最终结果被修改掉了

            Console.Write("数组中的全部元素：");

            foreach (int number in targetArray)
            {
                Console.Write($"{number}\t");
            }

            Console.WriteLine();

            Console.WriteLine($"当前数组的长度为：{targetArray.Length}");
        }
    }
}