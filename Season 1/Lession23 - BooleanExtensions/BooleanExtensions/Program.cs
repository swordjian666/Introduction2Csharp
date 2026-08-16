using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanExtensions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 回顾：int.TryParse()工具的使用方法
            // int.TryParse(strNumber, out int number);
            // 也就是说，需要我们在其中填入两个东西
            // 一个是要转换的字符串，后面那一坨东西，现在有点超纲
            // 直接记住是固定用法就可以，后面学
            // 实际上，这个东西可以给出一个布尔类型的值，我们可以通过一个变量对其接收
            //bool canBeConverted = int.TryParse("我真的是一个数字", out int convertedNumber);
            //// 输出结果为：False
            //Console.WriteLine(canBeConverted);
            //Console.ReadKey();

            // 系统给 string 类型的变量，提供了两个工具
            // IsNullOrEmpty() 工具 和 IsNullOrWhiteSpace() 工具
            // 它们会对当前字符串做一些判断，然后给出一个布尔值作为结果
            // 我们单从这个两个工具的命名来看，就能看出一些端倪
            // 前者用于判断当前字符串是否为null或者空字符串
            // 复习：空字符串，相当于 string.Empty，也就是 ""
            // 后者是判断当前字符串是否为null，或者里面全是空格
            // 例如："      "

            //string str = null;
            //bool isCurrentStrNull = string.IsNullOrEmpty(str);
            //// 一看就知道结果为 True
            //Console.WriteLine(isCurrentStrNull);

            //string str2 = "";
            //bool isCurrentStrEmpty = string.IsNullOrEmpty(str);
            //// 这个也是，一看就知道是 True
            //Console.WriteLine(isCurrentStrEmpty);

            //string str3 = "    ";
            //bool isStr3Empty = string.IsNullOrEmpty(str3);
            //// 看看这个，是 True 吗？
            //// 结果为 False，这个工具，判断不了全是空格的情况
            //Console.WriteLine(isStr3Empty);

            //Console.ReadKey();

            // 试试另外一个
            //string whiteSpaceStr1 = " ";
            //bool isStr1WhiteSpace = string.IsNullOrWhiteSpace(whiteSpaceStr1);
            //// 这个很明显是 True
            //Console.WriteLine(isStr1WhiteSpace);

            //string whiteSpaceStr2 = "";
            //bool isStr2WhiteSpace = string.IsNullOrWhiteSpace(whiteSpaceStr2);
            //// 这个就有点不确定了，空字符串，里面没写空格，所以应该是 False 吧？
            //// 也是 True ，实际上这个工具它和 string.IsNullOrEmpty()
            //// 在功能上有重叠的部分，多了一个判断空格字符串的功能
            //Console.WriteLine(isStr2WhiteSpace);

            //Console.ReadKey();

            // 此外，系统还给 string 类型的变量，提供了 Contains() 工具
            // 用于判断字符串中是否包含特定的字符
            // 使用规则：myStr.Contains(strContent);
            // 也就是说，我们需要在其中填入一个 string 类型字符串
            // 例如："Test content" 中是否包含 "Test" 这个单词
            // 包含，输出 True
            //Console.WriteLine("Test content".Contains("Test"));
            //Console.ReadKey();

            // 也可以填入一个 char 类型字符进去，判断是否包含
            // 需要注意，写完这行代码之后，using System.Linq 亮了起来
            // 这个工具是由 System.Linq 提供
            // 在 Rider 中编写这行代码，如果语法出错
            // 需要自行检查是否有 using System.Linq 这行代码
            //Console.WriteLine("Test content".Contains('T'));

            // 对于数组类型的变量，Contains() 工具依然适用
            // 例如，定义一个 int 类型的数组变量
            //int[] numbers = { 1, 2, 3, 4, 5 };
            // 看看里面有没有 20 这个元素
            // 用这个工具，同样需要写上 using System.Linq 这行代码
            //Console.WriteLine(numbers.Contains(20));
            //Console.ReadKey();

            // 下一个知识点：判断变量是否不等于某个值
            // 例如：判断一个数字是否不等于10
            //int number = 11;

            // 我们如果取命题的否定，就可以写为下列形式：
            //bool isNumberNotEquivalentToTen = !(number == 10);
            // 但是，这么写看起来有点别扭，有一个简单方法，直接写 !=
            //isNumberNotEquivalentToTen = number != 10;

            // 最后一个知识点：大于等于符号和小于等于符号的组和用法
            // 在数学题中，表示一个范围，多用 1<=x<20 这种形式
            int x = 10;
            // 如果在代码中直接写，将导致语法出错
            //bool isInRange = 1 <= x < 20;
            // 正确的写法：分别判断，然后用短路与进行连接
            // 第一种看起来比较流畅
            bool isInRange = 1 <= x && x < 20;
            // 也可以写成
            // 第二种在现实中用得多
            isInRange = x >= 1 && x < 20;

            Console.WriteLine(isInRange);
            Console.ReadKey();
        }
    }
}
