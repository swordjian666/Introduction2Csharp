using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningEnums
{
    internal class Program
    {
        enum Season
        {
            // 春季
            // Season 里面的每一个东西，也就是每一个季节，我们称其为 Season 的一个成员（Member）
            // 可以对枚举成员的索引值进行修改
            // 这次，来乱改序号
            // 乱改序号，设置为相同值
            Spring,
            // 夏季
            Summer,
            // 秋季
            Fall,
            // 冬季
            Winter
        }

        // 另外，既然我说了 int 和 enum 是两个互相兼容的类型
        // 那么，能不能将枚举成员直接设置为整型数字？
        // 例如，定义我的幸运数字
        // 结论：不可以，语法出错
        // 如果实在需要，就需要使用合规的方法
        //enum LuckyNumber
        //{
        //    // 其实和变量的命名规则类似
        //    // 你也可以写成 Number7 / NumberSeven
        //    //Number7,
        //    //NumberSeven,
        //    // 我写的 Seven，其实就是一种很好的方式了，再通过修改它本身的值
        //    // 转换后就能真的得到数字7
        //    Seven = 7,
        //    // 一百这个同理
        //    OneHundred = 100
        //}

        // 此外，也不能把系统里已有的东西
        // 放进去作为枚举成员
        // 例如，定义我喜欢的类型
        // 语法出错
        //enum MyFavouriteType
        //{
        //    // 和变量命名类似，可以出现下划线
        //    // 枚举类型，和里面的成员，首字母都要大写
        //    Type_int,
        //    Type_string
        //}

        enum Card
        {
            // 把 第一个成员 的值直接赋值为2，后面的会依次自动递增
            Two = 2,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            // 可以看到，这里的勾为11
            Jack,
            Queen,
            King,
            Ace,
            BlackJoker,
            RedJoker
        }

        static void Main(string[] args)
        {
            //// 使用代码表示当前的季节
            //Season summer = Season.Summer;
            //// 输出 Summer
            //Console.WriteLine(summer);
            //Console.ReadKey();

            // 内容回顾：代码的作用域
            // Season 为什么可以在Main中直接进行使用？
            // 我用简单代码，对其说明

            // class 那一层
            //{
            //    // enum 放置的位置
            //    string content = "Test content goes here.";

            //    // Main 那一层
            //    {
            //        // Season 变量的定义位置
            //        Console.WriteLine(content);
            //    }
            //}

            // 类型转换
            // int 和 char 是两种兼容类型
            // int 和 enum 也是两种兼容类型，可以互相进行转换
            // 1. 将枚举类型 Season 的成员，显示转换为 int 类型
            // 枚举类型的成员，默认值从0开始，和索引类似
            //Console.WriteLine((int)Season.Spring);
            //Console.WriteLine((int)Season.Summer);
            //Console.WriteLine((int)Season.Fall);
            //Console.WriteLine((int)Season.Winter);

            // 反过来，将 int 类型的变量，显示转换为 Season 枚举类型
            //Console.WriteLine((Season)0);
            //Console.WriteLine((Season)1);
            //Console.WriteLine((Season)2);
            //Console.WriteLine((Season)3);

            // 我们再顺便看看这样修改之后
            // 其它成员的值有没有发生变化？
            // 修改之后，其它成员的值依次递增
            // 设置成员的值之后，下一个没有进行设置的成员，其自身量会进行递增
            // 也就是自动+1
            //Console.WriteLine((int)Season.Spring);
            //Console.WriteLine((int)Season.Summer);
            //Console.WriteLine((int)Season.Fall);
            //Console.WriteLine((int)Season.Winter);

            // 如果我就想让枚举的第一个成员值为1
            // 应该怎么做？
            // 例如，我期望下面的代码输出 Spring

            // 此外，1这个值在当前的 Season 枚举中已经找不到对应的成员了
            // 因此会输出数字1
            // 不会报任何错误，也不会抛出异常
            //Console.WriteLine((Season)1);

            // 下面，继续来乱改枚举成员的值
            // 将成员值设为相同数字
            // 会发生什么？
            // 设置成员值之后，下一个没有进行手动赋值的成员值，自动进行递增，+1
            // 设置相同序号，导致出现两对相同序号的成员
            //Console.WriteLine((int)Season.Spring);
            //Console.WriteLine((int)Season.Summer);
            //Console.WriteLine((int)Season.Fall);
            //Console.WriteLine((int)Season.Winter);

            // 下面的代码会输出什么？
            // 会输出两个值吗？
            //Console.WriteLine((Season)5);
            // 会输出两个值吗？
            //Console.WriteLine((Season)6);

            // 我们刚才看到，不会出现两个值
            // 而是只能输出第一个与该值匹配的枚举成员
            // 也就是说，设置重复索引之后，我们没法再通过常规手段，通过索引访问后面那些成员

            //Console.ReadKey();

            // enum 类型变量转 string类型
            //Season spring = Season.Spring;
            //string springStr = spring.ToString();
            //Console.WriteLine(springStr);
            //Console.ReadKey();

            // 但如果要从 string 类型转换为 enum 类型
            // 就需要借助系统自带的 Enum.Parse() 工具
            // 首先，需要定义一个字符串变量，用于存储枚举成员的字面量
            // 再强调一点：
            // 不要把成员的字面量拼写错了，否则将导致后面转换的时候，抛出异常
            //string winterStr = "Winter";
            // 然后，使用 Enum.Parse() 工具
            // 使用规则：Enum.Parse(targetType, stringValue);
            // 也就是说，这个工具需要我们填入两个东西
            // 1. 想要转换的目标枚举类型
            // 2. 要转换的字符串变量
            // 然后，再来尝试对工具转换后的值进行接收
            // 会发现：语法出错
            // 直接接收，相当于将一个庞然大物直接塞入一个迷你容器中
            // 我在类型转换那节课里讲过了
            // 因此，需要将范围缩小，只拿需要的那一部分
            // 也就是将接收到的值，显示转换为 Season 类型
            //Season winter = (Season)Enum.Parse(typeof(Season), winterStr);

            // 来输出一下，看看是否转换成功
            // 为了防止和字符串混淆，我再把它显示转换为 int 类型
            //Console.WriteLine((int)winter);
            //Console.ReadKey();

            // 枚举类型变量，也可以使用算术运算符进行运算
            // 我以一副扑克牌为例
            // 现在，我要表示比勾大一级的牌是什么
            // 人人都知道是圈
            //Card queen = Card.Jack + 1;
            // 但需要注意，这种操作，仅限于+和-
            //Card ten = Card.Jack - 1;
            // 无法使用 *  /  %
            // 语法出错
            //Card unknownCard = Card.Jack * 5;
            // 如果一定要进行计算，需要先手动将变量显示转换为int类型，再进行计算

            // 接下来，我还想表示一对牌（忽略每张牌上的花色）
            // 例如，一对勾
            // 我们发现，语法立刻出错
            //Card pairOfJacks = Card.Jack + Card.Jack;
            // 我们对两个及以上枚举成员进行运算，必须先显示转换为int类型后再计算
            // 来看看一对勾究竟有多大
            //int priorityOfPairOfJacks = (int)Card.Jack + (int)Card.Jack;
            //Console.WriteLine(priorityOfPairOfJacks);

            // 来看看一对圈究竟有多大
            //int priorityOfPairOfQueens = (int)Card.Queen + (int)Card.Queen;
            //Console.WriteLine(priorityOfPairOfQueens);
            //Console.ReadKey();

            // 最后介绍 Enum.GetNames() 工具
            // 它可以将枚举类型的所有成员，逐个转换为 string 类型后
            // 再填装到一个 string 类型数组中
            // 给出该数组
            // 使用方法：Enum.GetNames(targetType);
            // 依然是填入目标类型
            string[] seasonStrs = Enum.GetNames(typeof(Season));
        }
    }
}
