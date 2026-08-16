using System;

namespace LearningDoWhileStatements
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // do-while 循环的基本语法结构

            // 语法结构比较简单
            // 括号里需要填入一个布尔类型变量或者布尔表达式，作为维持循环的条件
            // 不过，这次 while 似乎成了配角

            // do自己拥有了一对大括号，成为了主角
            // 刚才我们看到，do 的颜色也是不一样的，它也是一个系统保留关键字
            // 作用是：一定会先执行一次位于作用域中的代码，后续是否再执行
            // 要看 while 括号中的条件是否满足
            // do-while 和 while 的区别，主要在于：它们两个受代码作用域的控制程度不同
            // 什么意思？

            // do
            // {
            //     some code
            // } while (condition);

            // do-while 循环语句
            // 可以很好解决：“无论如何，某些代码上来就得执行一次”的情况
            // 我们使用 do-while 循环语句，对右面的代码进行改写：

            // 先声明，不初始化
            bool canBeConverted;

            // 这个也是，没有先初始化
            int convertedNumber;

            // 记录用户输入次数
            // 这个变量，依然需要先进行初始化
            // 你看下右边
            // 我一上来就先判断输入次数是否>1，这样才能决定
            // 下方的输入错误提示，是否继续进行展示
            int inputTimes = 0;

            // 这句话，只会在第一次输入的时候显示
            // 后面肯定不输出了，因此把它写到外面去
            Console.Write("请输入一个数字：");

            // 写 do-while 循环
            do
            {
                // 新的问题来了：
                // 如何输出温馨小贴士和下面的“输入有误”那条文字？
                // 补充以下代码：

                // 温馨提示这块代码有问题
                // 通过刚才的程序调试，你发现没有？
                // 第一次输入的温馨小贴士，被跳过了，或者说，被浪费掉了
                // 因此，三个数字 0 1 2，0被跳过了
                // 我们能用的数字就只剩1和2了
                if (inputTimes > 0)
                {
                    // 因此，这里不能再写成{inputTimes + 1}了
                    // 要直接写{inputTimes}
                    // 这一次，少了一条温馨小贴士，怎么回事？
                    Console.WriteLine($"（温馨小贴士：你已经输错{inputTimes}次了～）");
                    Console.Write("输入有误，请重新输入：");
                }

                // 用户输入的代码，直接拿进来
                string userInput = Console.ReadLine();

                // 对 canBeConverted 变量进行初始化
                // 现在，初始化完成，红线消失了
                // 还有一个细节：我刚才为什么把 convertedNumber 放外面去？
                // 我如果在这进行声明，你看右边的代码
                // 我在下面的 else 分支里还得访问这个变量
                // 到时候就访问不到了
                // 又是代码作用域的问题
                canBeConverted = int.TryParse(userInput, out convertedNumber);

                // 循环内的其它逻辑，正常照搬
                // 输错三次，就跳出循环
                // 这里是循环第二次被break，算上do的第一次执行，一共是三次
                if (inputTimes > 1)
                {
                    // 因此，我在循环被 break 掉之前，还得多输出一条温馨小贴士
                    // 计数最高为2，我要输出3次，就得是{inputTimes + 1}
                    // 通过这种“障眼法”，解决问题
                    Console.WriteLine($"（温馨小贴士：你已经输错{inputTimes + 1}次了～）");
                    break;
                }

                // 我输入完第一次，直接就给我在这+1了
                // 本质逻辑都是把0加到2，但是+1的时机，并不相同
                // 最后这个计数变量的值，没办法被加到3了
                // 因为 inputTimes要是再+1，整体就执行四次了：
                // 0 do执行那次
                // 1 2 3 三次循环
                inputTimes++;
            } while (!canBeConverted); // 画红线是因为还没进行初始化

            // 循环外的逻辑，也正常照搬
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

            Console.ReadKey();
        }
    }
}