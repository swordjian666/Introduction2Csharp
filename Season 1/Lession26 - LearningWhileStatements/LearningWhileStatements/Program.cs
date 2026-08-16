using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningWhileStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // while 循环结构
            // 基本代码结构
            // 看起来很简单，对吧？
            // 括号中的东西，实际上就是维持循环的条件
            // 也就是说，循环只会在特定条件下，才会执行
            //while (condition)
            //{

            //}

            // while 循环结构的使用
            // 模拟生活场景：找妈妈要手机玩

            // 需要注意的是：
            // 不希望每次都更新的代码，不要放到循环结构中去
            // 例如，天数，我们希望它进行持续记录
            // 而不是每次循环之后，都重新声明
            // 那样的话，天数会反复被重置为1
            // 再例如，像考试周期这个变量，它的值一直都是固定的
            // 因此也不需要放到 while 循环中

            // 记录天数
            int dayCount = 1;

            // 考试的周期、间隔
            int examDayInterval = 7;

            // 要从提出请求这块，增加一层循环
            // 最外层这个循环条件，暂时找不到合适的条件进行
            // 我想让它一直循环起来，怎么办？
            // 聪明的小伙伴已经想到了：
            // 我直接把 true 放里面
            // 这不就相当于是计算机世界中的永动机了吗？
            // 想法不错，来实际操作一下
            while (true)
            {
                // 增加一个条件，三次试错之后，自动丧失玩手机的资格
                // 通过这个 int 类型的变量，来记录问询次数
                // 也就能够代表：妈妈的耐心度阈值

                // 而且，这个变量，要写在循环的里边
                // 因为，最外层的循环，每循环一次
                // 就相当于是下次考试了
                // 因此，应该将询问次数清零，重新记录
                int timeOfAskingForPhone = 0;

                // 输出日期提示信息
                // 又是三元表达式，配合字符串内插，暂停好好看一下
                Console.WriteLine($"今天是第{dayCount}天{(dayCount == 1 ? string.Empty : $"，距离上次已经过去{examDayInterval}天了")}");

                // 模拟提出请求
                Console.WriteLine("我：麻麻，能不能让我玩玩手机？");

                // 模拟妈妈的回应
                Console.WriteLine("妈妈：乖儿子，让我看看你这次考了多少分呀？");
                Console.Write("妈妈：来吧，报上分来：");
                string myInput = Console.ReadLine();

                // 注意，这里我们在输入之后，没有对次数直接+1

                bool canBeConverted = int.TryParse(myInput, out int convertedGrade);

                // 当转换失败，就一直进行
                // 现在，这个程序只能在输入成绩这块做循环
                // 我们可以对程序进行修改，让整个询问过程都循环起来
                // 这个循环，目前还是过于理想化了
                // 如果输入错误，会一直要求我们重新输入
                // 但通常情况下，妈妈的忍耐度有限
                // 我们如果不正面回答妈妈
                // 那么，短暂地经历三次，甚至是两次问询之后
                // 妈妈就会不耐烦了
                // 会直接来一句：一边去，这次你别想玩手机了！！！
                while (!canBeConverted)
                {
                    // 加一个温馨小贴士
                    // 这个没什么好说的了，从0开始计数
                    // 要把它转换为人类理解的从1开始，表示次数
                    // 那就用 +1 来进行表示
                    // 又用到了三元表达式
                    // 没到3次，妈妈还没生气
                    // 到三次，才生气，我们要对输出的内容做一个判断
                    // 开头和结尾，分别再用 \n 加一个换行，提升美观度（让文字不太密集）
                    Console.WriteLine($"\n（温馨小贴士：你已经回避{timeOfAskingForPhone + 1}次了，妈妈{(timeOfAskingForPhone > 1 ? "已经" : "要")}生气咯~）\n");

                    // 那么，现在还有一个问题
                    // 如何在三次答错之后，就结束掉当前的问询循环？
                    // 还记得我们在上节课，讲开关结构的时候，用到的 break 关键字吗？
                    // 没错，它的作用，就是跳出代码结构
                    // 我们配合 if 判断语句，编写一个满足条件，就跳出循环的逻辑
                    // 这个条件，你可能有点疑惑，稍后解释
                    // 在循环里面，最多也就只能再输入两次了，外面已经输入了一次
                    // 一共只有3次机会
                    // 在外面输错一次：0
                    // 循环里面输入一次：1
                    // 循环里面输入第二次：2
                    // 这是不是就为3次了
                    // 因此，需要判断它 > 1，而不是 > 2

                    // 另外，if 中这个 break 语句，作用是：
                    // 跳出离它最近的一个循环结构，或者开关结构
                    // 而不是将 if 自己 break 出去
                    // 单独写 if 条件，在其作用域中，写 break 关键字，会导致语法出错
                    if (timeOfAskingForPhone > 1)
                    {
                        break;
                    }

                    Console.WriteLine("妈妈：臭小子，不正面回答是吧？你还想不想玩手机了？");
                    Console.Write("妈妈：给你个机会，重新给老娘报分：");

                    // 这里重新进行输入
                    // 先在这输入，例如这是循环中的第一次输入
                    // 循环中第一次输入错误的话，这就是第二次输入了
                    myInput = Console.ReadLine();

                    // 这里就需要重新进行转换
                    // 注意：上面已经写过了 int convertedGrade
                    // 不能再重复声明同一个变量了
                    // 因此在这里，直接把它给 out 出去就行了
                    canBeConverted = int.TryParse(myInput, out convertedGrade);

                    // 问完一次，询问次数就得自动+1，因此需要编写以下代码
                    // 因为，进入循环之后，这里又会给它+1
                    // 完事之后，这就+1，timeOfAskingForPhone 的值，就变成1了
                    // 这里又来+1，这次它的值，是不是就变成 2 了
                    timeOfAskingForPhone++;
                }

                // 下面要来修改判断条件
                // 多了一句妈妈不耐烦的话，所以要增加一条判断条件
                // 能不能直接判断是否为0呢？
                // 肯定不行，要是自己输入了0，也就是真考了0分，妈妈也会讲出那句不耐烦的话
                // 按照正常的逻辑，自己输入的0分，是要报：就考这么几分，还想玩手机？ 这句话的
                // 不要忘记，刚才我们已经引入了一个变量
                // 记录我们的试错次数，也就代表着妈妈的耐心程度
                // 因此可以和它进行组合判断
                // convertedGrade == 0 && timeOfAskingForPhone > 1
                // 和上边写的都一样，都是 > 1，为什么？
                // 正常来说，大于2才是3次，大于1不应该是两次吗？
                // 通过代码调试，搞清楚为什么是 > 1之后，修改分支结构
                // 还是要注意，这条放在前面，否则永远是下面那一条先匹配到
                // 不要耍小聪明，该怎么写，就写成本来的样子
                if (!canBeConverted && timeOfAskingForPhone > 1)
                {
                    Console.WriteLine("一边去，这次你别想玩手机了！！！");
                }
                else if (convertedGrade < 95)
                {
                    Console.WriteLine("妈妈：就考这么几分，还想玩手机？");
                    Console.WriteLine($"妈妈：先做几套题去吧！{examDayInterval}天后再玩，看你小子的表现哦~");
                }
                else
                {
                    Console.WriteLine("妈妈：给你玩一会儿去吧~");
                    Console.WriteLine("妈妈：臭小子，要是因为玩手机，导致你下一次没考好，看我怎么收拾你？！");
                }

                // 更新下一次玩手机的天数
                // 无论玩没玩到，这次都已经过去了，天数需要自动累加
                dayCount += examDayInterval;

                Console.WriteLine($"下次玩手机的日子是：{examDayInterval}天之后，已经是{dayCount}天了");

                // 问问自己还想不想玩了
                Console.WriteLine("在心里问问自己：我还想玩手机吗？（输入：想 | 不想）");
                string myChoice = Console.ReadLine();

                // 如果没输入“想”，就跳出整个循环
                if (myChoice != "想")
                {
                    break;
                }

                // 如果想，就继续进行问询流程
                // 增加一行提示信息
                Console.WriteLine("按下任意键，继续求妈妈要手机。。。\n");

                Console.ReadKey();
            }

            Console.WriteLine("问询结束，按任意键退出程序。。。");
            Console.ReadKey();
        }
    }
}
