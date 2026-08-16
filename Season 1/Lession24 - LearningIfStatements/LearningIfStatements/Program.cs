using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningIfStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // if 语句的基本代码结构
            // 需要在它的括号中填入一个布尔类型表达式，然后输入一对花括号，将一部分代码圈起来
            // 花括号，也就是代码作用域

            //if (condition)
            //{
            // some code
            //}

            // 一个具体的例子
            // 当整型变量 number 的值大于10的时候，输出 “当前数字比10大”
            //int number = 9;

            // 一个小问题：花括号里面就一行代码，写在作用域里，太占空间了
            //if (number > 10)
            //{
            //    Console.WriteLine("当前数字比10大");
            //}

            // 像这种条件满足，只执行一行代码的情况，我们可以省略代码的作用域
            //if (number > 10)
            //    Console.WriteLine("当前数字比10大");

            //// 也可以放在一行上
            //if (number > 10) Console.WriteLine("当前数字比10大");

            // 但上面这两种写法，其实都不推荐；这条建议，你可以选择性采取，毕竟语法不出错

            // 但需要注意的是：这种写法，只能判断紧跟 if 后的一行代码
            // 如果写多了，就不会受判断条件影响

            //if (number > 10)
            //    Console.WriteLine("当前数字比10大");

            //// 即便条件为 false 了，这些代码也不受控制
            //Console.WriteLine("哈哈，我照样执行");
            //Console.WriteLine("我就执行，怎么地？");

            //Console.ReadKey();

            // 新需求：
            // 当数字不比10大，也就是小于等于10的时候，我想让代码输出：“当前数字小于等于10”
            // 修改后的代码：

            //int number = 9;

            //if (number > 10)
            //{
            //    Console.WriteLine("当前数字比10大");
            //}

            //if (number <= 10)
            //{
            //    Console.WriteLine("当前数字小于等于10");
            //}

            // 有没有发现：这种判断方式有点麻烦

            // 如果我们按照命题的否定来进行思考的话，可以将代码改为下列形式：

            //bool isNumberGreaterThanTen = number > 10;

            //if (isNumberGreaterThanTen)
            //{
            //    Console.WriteLine("当前数字比10大");
            //}

            //if (!isNumberGreaterThanTen)
            //{
            //    Console.WriteLine("当前数字小于等于10");
            //}

            // 修改后好多了，但依然很麻烦，我们还得自己写出命题，然后取命题的否定形式
            // 实际上，针对这种“不是这么的，那一定是那么的”
            // 在本例中，就是：“数字不大于10，就是小于等于10”
            // 这种二极管思维的判断情况，我们可以直接用 else 分支来完成

            // 基本语法格式
            //if (condition)
            //{
            // some code
            //}
            //else
            //{
            // some code
            //}

            // 修改上述例子：
            //number = 10;

            //if (number > 10)
            //{
            //    Console.WriteLine("当前数字比10大");
            //}
            //else
            //{
            //    // 输出的是这行代码
            //    Console.WriteLine("当前数字小于等于10");
            //}

            // 使用 else 结构，可以自动帮我们推导出命题的否定形式
            // 当条件满足，进入其代码的作用域，执行对应的代码
            // 好处：不止省事，更在于判断流程会被串成一串，形成一条完整的逻辑链路
            // 代码看起来会更加清晰
            // 看到这里，你也能明白：if 语句就像树上的树杈子，一条一条地分裂，蔓延，长出不同的枝叶
            // 这就是它被称为分支结构的原因

            //Console.ReadKey();

            // 接下来我们来做一个报数程序
            // 如果数字是5，输出：“转角遇到幸运数字5”
            // 如果是大于5的数字，输出：“与幸运擦肩而过”
            // 如果是小于5的数字，输出：“差一点点，就可以遇见幸运”

            // 对于这种需求，你会发现：if-else 结构，它只能判断两种情况
            // 大于的，和小于等于的，怎么单独判断等于的那种情况？
            // 反应较快的人，已经想到了：我直接在小于等于那个分支里面，
            // 也就是 else 作用域里，再写一层 if-else 不就行了？

            int number = 5;

            //if (number > 5)
            //{
            //    Console.WriteLine("与幸运擦肩而过");
            //}
            //else
            //{
            //    // 可以达到效果，但你有没有发现：嵌套层数变多了
            //    // 多一个判断条件，就得多两条分支
            //    // 后续判断条件又变多了
            //    // 比如我现在把6和8也设为幸运数字，那还得多写多少行代码呀？！
            //    if (number == 5)
            //    {
            //        Console.WriteLine("转角遇到幸运数字5");
            //    }
            //    else 
            //    {
            //        Console.WriteLine("差一点点，就可以遇见幸运");
            //    }
            //}

            // 为了解决这个问题，我们引入 else-if 分支，将上述代码修改为：

            // 现在，把 number 的值改成6，看看走哪条分支
            number = 6;
            // 怎么回事？6不也是幸运数字了吗？怎么还给我擦肩而过呢？
            // 实际上，if-elseif-else 分支，它只会匹配第一个满足条件的情况
            // 在这个例子中，幸运数字6，一上来就能满足大于5的条件，因此直接就输出擦肩而过了
            // 解决方法：
            // 可以把它放在前面，提升判断的优先级
            // 这一次，就可以遇到幸运数字6了

            //if (number == 6)
            //{
            //    Console.WriteLine("转角遇到幸运数字6");
            //}

            //else if (number == 5)
            //{
            //    Console.WriteLine("转角遇到幸运数字5");
            //}
            //// 注意：这块还有一个问题
            //// > 5 这一条要改掉，语法虽然没报错
            //// 但当输入5和6的时候，这条代码已经失去意义了，不会进入执行
            //// 这样一来，就得一下改好几个地方
            //else if (number > 6)
            //{
            //    Console.WriteLine("与幸运擦肩而过");
            //}
            //else
            //{
            //    Console.WriteLine("差一点点，就可以遇见幸运");
            //}

            // 给它还原成刚才的样子：
            // 我还不如直接在这给它改成 > 6
            // 正常输出遇到幸运数字6
            //if (number > 6)
            //{
            //    Console.WriteLine("与幸运擦肩而过");
            //}

            //else if (number == 5)
            //{
            //    Console.WriteLine("转角遇到幸运数字5");
            //}
            //else if (number == 6)
            //{
            //    Console.WriteLine("转角遇到幸运数字6");
            //}
            //else
            //{
            //    Console.WriteLine("差一点点，就可以遇见幸运");
            //}

            //Console.ReadKey();

            // 小练习：闰年判断
            // 这是咱们小学时候学过的内容，两个条件，满足其一，就是闰年：
            // 1. 当前年份能被400整除
            // 2. 能被4整除，但不能被100整除
            // 用布尔表达式来表示，很简单：
            // 我们这里判断2026年是不是闰年
            //int year = 2026;

            //bool isLeapYear = year % 400 == 0 || (year % 4 == 0 && year % 100 != 0);

            //if (isLeapYear)
            //{
            //    Console.WriteLine("当前年份是闰年");
            //}
            //// 分支结构有个快捷键，比如我刚才写完 else 之后，直接按下 Shitf + Enter
            //// 就可以自动写出花括号，不用再手敲了
            //// 再演示一下
            //else
            //{
            //    Console.WriteLine("当前年份不是闰年");
            //}

            // 上面这个例子，只能判断一个年份，也就是说，变量值每次都是固定的
            // 我们用前面学过的知识，让用户动态输入年份，进行判断

            //// 回顾：输出不换行
            //Console.Write("请输入一个年份：");

            //// 回顾：接收用户输入
            //string userInput = Console.ReadLine();

            //// 注意：这里我没有对变量进行初始化，但没报语法错误
            //// 观察一下代码的运行顺序，不是走 try 就是走 catch
            //// 也就是说，最后无论如何，变量都会被初始化
            //// 要么是用户输入的有效值，要么是默认值1970
            //int convertedYear;
            //try
            //{
            //    convertedYear = Convert.ToInt32(userInput);

            //    if (convertedYear < 1)
            //    {
            //        Console.WriteLine("当前输入的年份有误，已将年份设置为默认值：1970年");
            //        convertedYear = 1970;
            //    }
            //}
            //catch
            //{
            //    Console.WriteLine("当前输入的年份有误，已将年份设置为默认值：1970年");
            //    convertedYear = 1970;
            //}

            //// 而且这块已经出现了重复的代码

            //bool isLeapYear = convertedYear % 400 == 0 ||
            //    (convertedYear % 4 == 0 && convertedYear % 100 != 0);

            //if (isLeapYear)
            //{
            //    Console.WriteLine($"当前年份：{convertedYear}年\n 是闰年");
            //}
            //else
            //{
            //    Console.WriteLine($"当前年份：{convertedYear}年\n 不是闰年");
            //}

            // 上面这个写法，不够简洁，需要用 try-catch 结构进行异常捕获

            // 我们使用之前讲的 int.TryParse() 工具，和三元表达式
            // 对这些语句做简化：

            // 回顾：输出不换行
            Console.Write("请输入一个年份：");

            // 回顾：接收用户输入
            string userInput = Console.ReadLine();

            // 回顾：int.TryParse() 工具
            // 不报错，可以省略 try-catch 异常捕获结构
            // 工具给出一个布尔类型的结果
            // true 代表能转换，false 代表不能
            bool canBeConverted = int.TryParse(userInput, out int convertedYear);

            // 一旦不能转换，或者输入的值小于1时
            // 充值当前年份为默认值 1970
            // 命题的析取，一真为真
            if (!canBeConverted || convertedYear < 1)
            {
                Console.WriteLine("当前输入的年份有误，已将年份设置为默认值：1970年");
                convertedYear = 1970;
            }


            // 需要强调：系统其实自带判断闰年的工具：DateTime.IsLeapYear()
            // 只需要在括号中填入要判断的年份就可以了
            // 以后的开发工作中，能用系统自带的，就用自带的，不要总是去想从头造轮子
            bool isLeapYear = DateTime.IsLeapYear(convertedYear);
            //bool isLeapYear = convertedYear % 400 == 0 ||
            //    (convertedYear % 4 == 0 && convertedYear % 100 != 0);

            // 这块写得比较有意思
            // 我把“是”这个字直接放上去了
            // 用三元表达式判断是否为闰年
            // 是闰年，把结果设置为 string.Empty 工具的值，也就是什么都不加
            // 不是闰年，就多输出一个“不”字
            Console.WriteLine($"当前年份：{convertedYear} 年\n{(isLeapYear ? string.Empty : "不")}是闰年");

            // 现在这种方法，看起来已经很简洁了

            Console.ReadKey();
        }
    }
}
