// ReSharper disable SwapViaDeconstruction

using System;

namespace Course4
{
    internal class Program
    {
        // 回顾：枚举放置的位置
        // 不止可以放在 class 下方的代码作用域中

        // 这两个实参的值，真的没办法改掉吗？
        // 实际上也不是
        // 类似地，如果要对变量进行共享，那么，变量就不能只属于某个特定的方法
        // 需要把它们也拿到 class 下方的代码作用域中
        // 语法出错
        // 如果要在 static 方法中，访问 class 代码作用域中的变量
        // 需要保证：访问的变量，也被 static 关键字标记
        // 注意：把变量放到这块，它就有了一个新的名称：字段（Field）
        // 命名也有区别
        // 需要加上一条下划线，和普通变量做区分
        // 目前这种情况，暂时就将命名规则记为：_camelCase
        // 现在，我们应该称它们为：静态字段
        // static int _number1 = 10;
        // static int _number2 = 20;
        //
        // public static void Main(string[] args)
        // {
        //     SwapValues();
        //     
        //     Console.WriteLine($"交换后，(Main) number1 的值：{_number1}");
        //     Console.WriteLine($"交换后，(Main) number2 的值：{_number2}");
        //     
        //     Console.ReadKey();
        // }
        //
        // /// <summary>
        // /// 交换两个整型变量的值
        // /// </summary>
        // private static void SwapValues()
        // {
        //     // 现在，变量是共享的了，不需要传参数了
        //     
        //     int temp = _number1;
        //     _number1 = _number2;
        //     _number2 = temp;
        //     
        //     Console.WriteLine($"交换后，(SwapValues) number1 的值：{_number1}");
        //     Console.WriteLine($"交换后，(SwapValues) number2 的值：{_number2}");
        // }

        // public static void Main(string[] args)
        // {
        //     // int number1 = 10;
        //     // int number2 = 20;
        //     //
        //     // SwapValues(ref number1, ref number2);
        //     //
        //     // Console.WriteLine($"交换后，实参 number1 的值: {number1}");
        //     // Console.WriteLine($"交换后，实参 number2 的值: {number2}");
        //     
        //     // 继续来看一个例子
        //     int[] numbers = { 1, 78, 32, 2, 45, 22, 10, 108, 99, 85 };
        //     Array.Sort(numbers);
        // }
        //
        // /// <summary>
        // /// 交换两个整型变量的值
        // /// </summary>
        // /// <param name="value1">第一个整数</param>
        // /// <param name="value2">第二个整数</param>
        // private static void SwapValues(ref int value1, ref int value2)
        // {
        //     int temp = value1;
        //     value1 = value2;
        //     value2 = temp;
        //
        //     Console.WriteLine($"交换后的形参 value1: {value1}");
        //     Console.WriteLine($"交换后的形参 value2: {value2}");
        // }

        // private static void PrintNumber(in int number)
        // {
        //     // 之前讲过：
        //     // 参数的主要作用在于，提供需要引用的数据，或者要处理的数据
        //     // 这是两个完全不同的需求
        //     // 如果是引用数据，通常情况下，就意味着：传入的数据（参数），应该是只读的（read-only），不能被修改
        //     // 如果对数据进行修改，对应的则是处理数据的需求
        //     // 为了解决数据（参数）无法被保护的情况，引入 in 关键字
        //     
        //     Console.WriteLine($"当前数字为：{number}");
        //
        //     // 尝试修改 number 的值
        //     // 语法出错
        //     // number = 20;
        // }
        
        // public static void Main(string[] args)
        // {
        //     // out 关键字
        //     int waist = 5;
        //     Console.WriteLine($"修改前的腰宽：{waist}");
        //     AlterClothes(out waist, 10);
        //     Console.WriteLine($"修改后的腰宽：{waist}");
        //     
        //     // 和这个例子一样，都是顺手对变量进行了重新赋值
        //     bool canBeConverted = int.TryParse("我真的是一个数字", out int convertedNumber);
        // }
        //
        // /// <summary>
        // /// 修改衣服尺寸
        // /// </summary>
        // /// <param name="waist">腰宽</param>
        // /// <param name="cuffs">袖口大小</param>
        // private static void AlterClothes(out int waist, int cuffs)
        // {
        //     // 现在，语法出错
        //     // 因为被 out 关键字标记的形参，一定要在当前方法中进行初始化
        //     // 或者说：它的值一定要被改变
        //     
        //     // 改腰宽
        //     waist = 4;
        //     
        //     Console.WriteLine($"原袖口大小：{cuffs}");
        //     // 改袖口
        //     cuffs = 3;
        //     Console.WriteLine($"预计修改后的袖口大小：{cuffs}");
        // }

        public static void Main(string[] args)
        {
            // params 关键字
            // 注意两点：
            // 1. 你依然可以向方法中，传递一个数组实参
            // 2. 被 params 修饰的形参，必须放在方法参数列表的最后面，不允许放到前面去
            // 因此，一个方法，就只能在参数列表的结尾，有一个可变参数
            
            PrintNumbers(1,2,3,4,5);
            Console.ReadKey();
        }

        private static void PrintNumbers(params int[] numbers)
        {
            Console.WriteLine("当前数组中的元素是：");

            foreach (int number in numbers)
            {
                Console.Write($"{number}  ");
            }
            
            Console.WriteLine();
        }
    }
}