using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 + 1;

            //// 简单加法
            //int number1 = 10 + 20;
            //// 结果一看就知道是30
            //Console.WriteLine(number1);
            //Console.ReadKey();

            //// 简单减法
            //int number2 = 10 - 30;
            //// 结果一看就知道是-20
            //Console.WriteLine(number2);
            //Console.ReadKey();

            //// 简单乘法
            //int number3 = 5 * 8;
            //// 结果一看就知道是40
            //Console.WriteLine(number3);
            //Console.ReadKey();

            //// 简单除法
            //int number4 = 10 / 2;
            //// 结果一看就知道是5
            //Console.WriteLine(number4);
            //Console.ReadKey();

            //double result = 0.1 + 0.2;
            //// 这不就是0.3么？
            //// 运行之后发现，并不是
            //Console.WriteLine(result.ToString("R"));
            //Console.ReadKey();

            // 编程中的一种新的运算符号：% 取余符号
            // 写下这行代码，会得到整数1，因为 10 / 3 = 3...1
            //int number5 = 10 % 3;
            //Console.WriteLine(number5);
            //Console.ReadKey();

            // 猜猜结果是多少？是0吗？
            // 毕竟 10 / 2 = 2.5，也没有余数啊
            //double number6 = 10 % 4;
            //// 很遗憾，结果为2.因为 10 / 4 = 2...2
            //Console.WriteLine(number6);
            //Console.ReadKey();

            // 注意遵守运算规则
            // 例如：除数不能为0
            // 直接写会导致语法错误
            //int invalidNumber = 10 / 0;

            //int zeroNumber = 0;
            //int tenNumber = 10;
            // 使用这种“迂回”的方式，语法层面首先不会报错
            // 但运行之后，程序出错，而且是它这行代码直接出错了
            // 并不是通过 Console.WriteLine(result); 对其访问才报错的
            //int result = tenNumber / zeroNumber;

            //int number7 = 300;
            //int number8 = 10;
            //// 变量间可以互相运算
            //Console.WriteLine(number7 / number8);
            //Console.ReadKey();

            // 其它例子，例如
            // 10 - 300 = -290
            //int number9 = number8 - number7;
            // -290 + 1 = -289
            //int number10 = number9 + 1;

            //Console.WriteLine(number9);
            //Console.WriteLine(number10);
            //Console.ReadKey();

            // 数字本身可以变化，例如
            // -289 - 2 = -291
            //number10 = number10 - 2;

            // 上述写法还有简便写法：
            //number10 -= 2;

            //Console.WriteLine(number10);
            //Console.ReadKey();

            // 1 + 12 + 20 - 5 + 1 - 1 = 28
            //int number11 = 1 + 8 / 2 * 3 + 10 * 2 - 5 + 2 / 2 - 1;
            //Console.WriteLine(number11);
            //Console.ReadKey();

            // 可以通过括号将某一部分算式框起来，提高运算的优先级
            // 口算一下：1 + 8/6 + 10*(-3) + 1 - 1 = 
            // 1 + 1（注意这是 int，所以只有整数部分了，进制转换那节课讲过了）- 30 = -28
            //int number12 = 1 + 8 / (2 * 3) + 10 * (2 - 5) + 2 / 2 - 1;
            //Console.WriteLine(number12);
            //Console.ReadKey();

            // 再来看 char 类型的
            //char character1 = 'A';
            //char character2 = 'B';

            // 字母也能进行运算操作？
            // 不仅能，而且还输出了一个数字结果
            // 因为，在 Unicode 编码中
            // 字母 A 的编号为65
            // 字母 B 的编号为66
            // 因此，结果为 65 + 66 = 131
            //Console.WriteLine(character1 + character2);

            //int indexOfCharacterA = (int)'A';
            //int indexOfCharacterB = (int)'B';
            //Console.WriteLine($"字符 A 的序号：{indexOfCharacterA}");
            //Console.WriteLine($"字符 B 的序号：{indexOfCharacterB}");

            //Console.ReadKey();

            // 反过来，从 int 转换回 char 类型，要确保这个值是有对应字符的
            // 例如下面这行代码
            //int invalidIndex = int.MaxValue;
            // 输出乱码或空白（一个看不见的字符）
            //Console.WriteLine((char)invalidIndex);
            //Console.ReadKey();

            // 再来看 string 类型
            //string strNumber1 = "3";
            //string strNumber2 = "5";

            // 不要以为直接是 "3" + "5" = "8"
            // 结果是3和5放在一块，是35
            //Console.WriteLine(strNumber1 + strNumber2);
            //Console.ReadKey();

            // 拼接 char 类型文字
            // 语法出错，不同类型间，大部分情况下无法直接进行自动类型转换
            //string aAndB = 'A' + 'B';
            // 因此，需要先转换
            //string aAndB = 'A'.ToString() + 'B'.ToString();
            // 小技巧：字符串具有传染性，和任何东西拼在一起都是字符串
            // 因此，我们还可以：
            //string aAndB = "" + 'A' + 'B';
            //Console.WriteLine(aAndB);

            // 如果使用字符串内插，会有一些问题
            //string aAndB = $"{'A' + 'B'}";
            // 会依然按照它本身的编号进行计算，结果是 "131"，注意是 string 类型了
            //解决的方法，是加一个空字符串，和上面一样
            //string aAndB = $"{"" + 'A' + 'B'}";
            //Console.WriteLine(aAndB);
            //Console.ReadKey();

            // 最后一个知识点
            // ++ 和 -- 运算符
            // 首先，++ 的作用是让变量值本身+1
            // 例如
            int number15 = 10;
            //number15++;
            // 乍一看，好像和 number15 += 1; 的作用是等价的
            //Console.WriteLine(number15);
            //Console.ReadKey();

            // 实则不然，++还可以放在前面
            //++number15;
            // 这不还是11吗？有什么区别？

            // 来看这个例子
            // 这个简单，就是 11 + 12 = 23
            //int number16 = (number15++) + (++number15);
            // 来验证一下
            // 结果居然是22，难道是11+11=22吗？
            // 不要瞎猜了，讲一下原理
            // 1. number15++ --> 给出它之前的10值之后，再将自身+1，也就是变成11
            // 2. ++number15 --> 先把自身+1之后，再给出自身的值，也就是 11 + 1 = 12
            // 因此，最终的结果为 10 + 12 = 22
            //Console.WriteLine(number16);
            //Console.ReadKey();









            // 趁热打铁，直接来做练习
            // 经典题目：两个变量值，如何交换它们？
            int number1 = 10;
            int number2 = 20;

            //// 有人说：这不是很简单嘛？
            //// 我先这样
            //int number3 = 20;
            //int number4 = 10;
            //// 然后再这样
            //number1 = number3;
            //number2 = number4;

            //// 找一个空杯子过来，没有东西，因此值设为0
            //int temp = 0;

            //// 首先把雪碧倒进杯子中
            //temp = number1;

            //// 然后就可以把可乐倒进原来装雪碧的杯子里面了
            //number1 = number2;

            //// 可乐杯子现在也是空的了，因此可以把新杯子中装的雪碧倒进来
            //number2 = temp;

            // 下面来上上难度，不通过引入第三个变量，如何做到交换？
            // 先看这两个数，10和20，如何才能互相变成对方的样子？
            // 1. 10 - 20 = -10
            // 2. 20 + (-10) = 20 - 10 = 10
            // 3. 10 - (-10) = 10 + 10 = 20

            // 用代码进行操作一下
            // 先得到-10
            number1 -= number2;
            // 现在，number1 是 -10 了
            // 再把 number2 变成10
            number2 += number1;
            // 最后，再通过 number2 把 number1 还原回来
            number1 = number2 - number1;

            // 看看是不是
            // 确实是交换成功了
            Console.WriteLine($"{number1} {number2}");
            Console.ReadKey();
        }
    }
}
