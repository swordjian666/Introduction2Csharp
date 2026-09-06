using System;

namespace Course3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // 我们之前都是在 Main 方法中，调用另一个方法
            // 你有没有好奇过：在方法中，调用它本身
            // 也就是说：方法自己调用自己的话，会发生什么？
            
            // 在 Main 方法中，对其进行调用
            // PrintMessage("来了老弟");
            
            // 死循环导致的问题
            // 现在，能不能明白过来：为什么要尽量避免使用死循环？
            // 或者说，即便要用，也要有明确的循环结束条件，否则就会导致内存暴涨
            
            // 死循环本身并不一定导致内存暴涨
            // for (;;)
            // {
            //     // 关键在于：循环中具体做了什么
            //     // Console.WriteLine("哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈");
            // }

            // RunMethod1();
        }
        
        // 几个方法之间互相调用，也会出现入栈、出栈的这种情况
        // 举个例子：

        // private static void RunMethod1()
        // {
        //     Console.WriteLine("进入 Method1");
        //     RunMethod2();
        //     Console.WriteLine("离开 Method1");
        // }
        //
        // private static void RunMethod2()
        // {
        //     Console.WriteLine("进入 Method2");
        //     RunMethod3();
        //     Console.WriteLine("离开 Method2");
        // }
        //
        // private static void RunMethod3()
        // {
        //     Console.WriteLine("进入 Method3");
        //     Console.WriteLine("离开 Method3");
        // }
        
        // 我们马上来玩一下
        // 首先，定义一个 PrintMessage 方法，定义一个 string 类型的形参 message，用于输出一段话

        // private static void PrintMessage(string message)
        // {
        //     Console.WriteLine($"割割，你忍心让人家一直讲：{message} 吗？");
        //     
        //     // 自己调用自己
        //     PrintMessage(message);
        // }
        
        // 实际开发中，方法递归常用于部分算法，以及处理树状结构的场景，例如：文件系统
        // 但在很多场景下，其实用递归并不好
        // 首当其冲的一点是：对于大量重复计算的场景，它的运行效率很低，很慢。因此还需要额外进行优化
        
        // 用递归实现的简单算法：斐波那契数列
        // 还有其它的几个名称：黄金分割数列、兔子数列
        // 函数表达式：F(n) = F(n-1) + F(n-2)  { n | 2 <= n < +∞, n ∈ N }
        // 含义：从 n = 2 开始，当前项等于前两项之和。其中，规定 F(0) = 0, F(1) = 1

        // /// <summary>
        // /// 斐波那契数列函数（这种实现有问题）
        // /// </summary>
        // /// <param name="number">当前函数的参数</param>
        // /// <returns>当前函数的值</returns>
        // private static int Fib(int number)
        // {
        //     // 函数的参数，至少要从0开始，才有效
        //     // 如果遇到无效参数，直接返回 F(0) 的值
        //     if (number < 0)
        //     {
        //         return 0;
        //     }
        //
        //     // 处理 F(0) 和 F(1) 这两种情况
        //     if (number <= 1)
        //     {
        //         return number;
        //     }
        //     
        //     return Fib(number - 1) + Fib(number - 2);
        // }
        
        // 更常用的写法
        private static int Fib(int number)
        {
            // 函数的参数，至少要从0开始，才有效
            // 如果遇到无效参数，直接返回 F(0) 的值
            if (number < 0)
            {
                return 0;
            }
            
            // 处理 F(0) 和 F(1) 这两种情况
            if (number <= 1)
            {
                return number;
            }

            // 前一项的值
            // 先假定它是 F(0) 那一项
            int previous = 0;
            // 假定它是 F(1) 那一项
            // 当前项的值
            int current = 1;

            for (int i = 2; i <= number; i++)
            {
                // 下一项的值
                int next = previous + current;
                // 前一项的值，设置为当前一项的值
                previous = current;
                // 当前一项的值，设置为下一项的
                current = next;
            }
            
            return current;
        }
    }
}