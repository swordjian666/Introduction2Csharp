using System;

namespace PreviousExampleWithWhileStatements
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // 回顾：三次输入错误，自动丧失资格
            Console.Write("请输入一个数字：");
            
            // 看这块
            // 能不能省略这块，直接塞进循环里？
            string userInput = Console.ReadLine();
            
            // while 循环的例子
            // 为什么没有这种问题？
            // 因为第一次转换，就是在外边写的
            // 不是等到了循环里，才声明变量的
            // 因此不会出现代码作用域问题
            bool canBeConverted = int.TryParse(userInput, out int convertedNumber);

            // while 例子这块，根本没+1

            // 记录用户输入次数
            int inputTimes = 0;

            // 这块直接报语法错误
            // 压根没找到这个变量
            while (!canBeConverted)
            {
                Console.WriteLine($"（温馨小贴士：你已经输错{inputTimes + 1}次了～）");

                // 输错三次，就跳出循环
                if (inputTimes > 1)
                {
                    break;
                }
                
                Console.Write("输入有误，请重新输入：");
                
                // 再看这块
                // 重新输入
                userInput = Console.ReadLine();
                canBeConverted = int.TryParse(userInput, out convertedNumber);
                
                // 每输入一次，次数就得+1
                // 再次强调：循环里最多只会输入两次，加上外边输入那一次，一共就是三次
                // 但数字从0变到2，都是在这个循环里完成的
                inputTimes++;
            }

            // 最后一次还弹输入错误，是为什么？
            // 上节课讲的重点知识：回归问题本身
            if (!canBeConverted && inputTimes > 1)
            {
                Console.WriteLine("三次输入错误，自动丧失转换资格");
            }
            else
            {
                Console.WriteLine($"输入正确，转换后的数字为：{convertedNumber}");
            }

            // 这个例子比较简单，我就不进行启动演示了
            // 直接观察代码
            Console.ReadKey();
        }
    }
}