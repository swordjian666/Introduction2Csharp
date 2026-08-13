using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 声明一个 int 类型的变量
            int number1 = 10;

            // 将其转换为 double 类型
            double number2 = number1;

            // 语法出错
            //int number3 = 3.14;

            //进行强制转换
            int number3 = (int)3.14;

            // 看看是不是想象中的那样，对数字进行一些额外处理
            number3 = (int)3.9;

            // 结果为3，没有进行四舍五入变成4
            //Console.WriteLine(number3);
            //Console.ReadKey();

            // (int) 这种强制转换方式，通常不推荐使用

            // 更常用的方法：
            int number4 = Convert.ToInt32(3.14);

            decimal money = 888888.8888888888888M;

            int number5 = Convert.ToInt32(money);

            // 使用系统自带 Convert 工具，甚至帮我们自动完成了四舍五入
            //Console.WriteLine(number5);
            //Console.ReadKey();

            double doubleValue = 123.456;
            float floatValue = Convert.ToSingle(doubleValue);

            //Console.WriteLine(floatValue);
            //Console.ReadKey();

            // int.Parse() 工具
            int numberFromStr = int.Parse("3");

            //Console.WriteLine(numberFromStr);
            //Console.ReadKey();

            // 程序报错，文字转不了数字
            //int numberFromStr2 = int.Parse("我是一个数字");

            //Console.WriteLine(numberFromStr2);
            //Console.ReadKey();

            // 试试把小数字符串转换为整型，看看能不能成功
            int numberFromStr3 = int.Parse("3.14");

            Console.WriteLine(numberFromStr3);
            Console.ReadKey();

            // int.TryParse() 工具
            //int.TryParse("我是一个数字", out int convertedNumber);

            //Console.WriteLine(convertedNumber);
            //Console.ReadKey();
        }
    }
}
