using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSwitchCaseStatements
{
    internal class Program
    {
        enum Season
        {
            Spring,
            Summer,
            Fall,
            Winter
        }

        static void Main(string[] args)
        {
            // 开关结构基本语法
            // 括号里需要填入一个变量
            // 可以是整数类型变量，例如 int, long
            // 字符型变量 char
            // 字符串类型变量 string
            // 枚举类型
            // 如果是 bool 类型，可以是一个变量，也可以直接填入一个布尔表达式
            // 但在 switch-case 结构中，通常没啥意义
            //switch ()
            //{
            // case 是一个系统保留关键字
            // 作用：匹配对应的值
            // case value1:
            // some code
            // break 也是一个系统保留关键字
            // 作用：跳出当前代码结构
            // 它是一个代码跳转语句，也属于流程控制语句的一种
            // 跳转语句（Jump statements）
            // break;

            // 这块，我可以连续进行 case
            // case value2:
            // case value3:
            // case value4:
            // some code
            // break;

            // default 也是一个系统保留关键字
            // 放在 switch-case 结构中，作用是
            // 当没有匹配到上面的任何值时，才会执行
            // default:
            // some code
            // break;
            //}

            // 我们目前已经学了几种流程控制语句了，别搞混了
            // 我总结了一张树状图
            /*
             流程控制语句
                |- 异常处理语句(Exception handling statements)
                    |- try-catch 异常捕获结构
                |- 分支语句 (Branching statements)
                    |- if-elseif-else 选择结构
                    |- switch-case 开关结构
                |- 跳转语句 (Jump statements)
                    |- break 跳出关键字
             */

            // switch-case 结构用法示例：
            // 季节匹配，对匹配到的季节进行播报（在控制台中输出）

            // 声明一个季节类型枚举变量，赋值为 Winter
            //Season currentSeason = Season.Winter;

            //// 这次，我们把季节改为夏季
            //currentSeason = Season.Summer;

            //// 使用开关结构匹配季节
            //switch (currentSeason)
            //{
            //    // 移动位置到上面，会导致我们本来就有的那些 case 条件报语法错误

            //    case Season.Spring:
            //        Console.WriteLine("当前的季节是春季");
            //        break;

            //    case Season.Summer:
            //        Console.WriteLine("当前的季节是夏季");
            //        break;

            //    case Season.Fall:
            //        Console.WriteLine("当前的季节是秋季");
            //        break;

            //    // 我们继续修改代码
            //    // 当季节是春夏秋的时候，输出：某某季节是气候较为温和的季节
            //    // 当季节是冬季的时候，输出：冬季是气候较为寒冷的季节
            //    // 我还想输出这段内容，怎么办？

            //    // 于是乎，我们直接在这里添加以下代码：
            //    // 语法出错
            //    // 再来看一下 switch-case 语句的基本结构
            //    // 我写的 value1 到 value4，是分别出现在两个不同的 case 关键字下的
            //    // 我在下面写的东西里，压根就没再出现 value1
            //    // 这坨东西，无论是放在开头，中间，还是结尾，都会导致出错
            //    // 这是因为：
            //    // 这些值已经匹配过了，重复写，相当于逻辑上有了冲突
            //    // 系统不知道该执行哪种情况
            //    // 它和 if-elseif 那种情况是有明显区别的，如果是 if-elseif 语句
            //    // 放置的位置不合适，顶多也就是只执行上面的，不往下继续执行了而已
            //    // 而 switch 里写重复的 case 匹配，就直接导致语法出错
            //    //case Season.Spring:
            //    //case Season.Summer:
            //    //case Season.Fall:
            //    //    break;

            //    default:
            //        Console.WriteLine("当前的季节是冬季");
            //        break;

            //    // 移动到最后，也避免不了报错
            //}

            // 解决方法：再写一个 switch-case 结构

            //switch (currentSeason)
            //{
            //    case Season.Spring:
            //    case Season.Summer:
            //    case Season.Fall:
            //        Console.WriteLine($"{currentSeason}季节是气候较为温和的季节");
            //        break;

            //    default:
            //        Console.WriteLine($"{currentSeason}季节是气候较为寒冷的季节");
            //        break;
            //}

            //Console.ReadKey();

            // 启动程序，输出：当前的季节是冬季
            // 这玩意和 if 那套东西的作用大差不差呀？！有什么显著的优势吗？
            // 别着急，回头看下开关结构的基础语法


            // 还有一个细节：我刚才说的是把变量扔到 switch 后面的括号里
            // 如果直接把变量的值，扔到括号里，看看会怎么样
            // 因此，不要这么写，根本没有意义
            //switch (Season.Spring)
            //{
            //    // 只有这一条亮
            //    // 编译器会进行预判，只会匹配到这一条
            //    // 而如果是放变量到括号里，编译器不会提前做预判
            //    // 会认为：四条通路都有机会进入
            //    case Season.Spring:
            //        break;

            //    // 后面的代码灰掉了
            //    case Season.Summer:
            //        break;

            //    case Season.Fall:
            //        break;

            //    default:
            //        break;
            //}

            // 练习：对月份进行判断，输出它所在的季度

            // 首先声明当前的月份
            int currentMonth = 18;

            // 对月份进行判断，输出所在季度
            //switch (currentMonth)
            //{
            //    default:
            //        Console.WriteLine("当前输入的值有误");
            //        break;

            //    case 7:
            //    case 8:
            //    case 9:
            //        Console.WriteLine($"{currentMonth}月属于第三季度");
            //        break;

            //    case 1:
            //    case 2:
            //    case 3:
            //        Console.WriteLine($"{currentMonth}月属于第一季度");
            //        break;

            //    case 10:
            //    case 11:
            //    case 12:
            //        Console.WriteLine($"{currentMonth}月属于第四季度");
            //        break;

            //    case 4:
            //    case 5:
            //    case 6:
            //        Console.WriteLine($"{currentMonth}月属于第二季度");
            //        break;
            //}

            // 这次就可以看出来了：
            // 开关结构对比 if 选择结构，在某些情况下是很有优势的
            // 如果把上面那些代码改用 if-elseif-else 那套结构来实现
            // 要多写不少条用于判断条件的代码

            // 此外，我们也可以把 switch 中的 case 代码进行随意放置
            // 放置的位置不影响效果，但我们通常不这么做
            // 这么做会导致代码变乱，可读性变差

            //Console.ReadKey();

            // 然后，我上面提到过可以放 bool 类型变量或直接放一个布尔表达式进去
            // 例如下面这样

            //int x = 10;

            // 这么写有什么意义？根本看不出来有意义
            // 实际上，这就是一个二极管问题
            // 不是这么的，就是那么的
            // 因此，不要使用开关结构，匹配布尔值或布尔类型表达式的结果
            // 此类操作要用 if 判断语句来完成
            //switch (x > 5)
            //{
            //    case true:
            //        break;

            //    default:
            //        break;
            //}

            // 最后再来做一个练习
            // 使用三元表达式，通过开关结构，匹配 string 字符串
            // 这个可玩性很高
            // 例如，我们现在根据学生的分数，进行成绩等级的划分
            // 1. 90分及以上，优秀
            // 2. 80分及以上，良好
            // 3. 70分及以上，中等
            // 4. 60分及以上，及格
            // 5. 60分及以下，不及格

            Console.Write("请输入你本次考试的成绩：");
            string userInput = Console.ReadLine();
            bool canBeConverted = int.TryParse(userInput, out int convertedGrade);

            if (!canBeConverted || convertedGrade < 0 || convertedGrade > 100)
            {
                convertedGrade = 0;
                Console.WriteLine("输入的内容无效，自动设置为0分");
            }

            // 这个三元表达式是嵌套的，乍一看，可能会看不懂
            // 分析一下：
            // 首先会判断成绩是不是大于等于90分这一档的，如果是，也就是满足条件
            // 会直接将 "优秀" 这个字符串，作为整个三元表达式的结果
            // 这么看的话，它在执行上，其实也是短路的
            // 只要有满足的，直接返回结果
            // 如果没满足，就继续往下判断，直到有条件满足，得到最终的结果为止
            // 用 switch 配合嵌套三元表达式的好处：
            // 可以省略一堆 短路或 判断条件
            switch (convertedGrade >= 90 ? "优秀" :
                convertedGrade >= 80 ? "良好" :
                convertedGrade >= 70 ? "中等" :
                convertedGrade >= 60 ? "及格" : "不及格")
            {
                case "优秀":
                    Console.WriteLine($"{convertedGrade}分，优秀！");
                    break;

                case "良好":
                    Console.WriteLine($"{convertedGrade}分，良好~");
                    break;

                case "中等":
                    Console.WriteLine($"{convertedGrade}分，中等。");
                    break;

                case "及格":
                    Console.WriteLine($"{convertedGrade}分，差一点就不及格啦！");
                    break;

                default:
                    Console.WriteLine($"{convertedGrade}分，没及格，赶紧努努力吧！");
                    break;
            }

            Console.ReadKey();
        }
    }
}
