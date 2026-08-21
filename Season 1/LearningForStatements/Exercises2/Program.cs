// ReSharper disable SwapViaDeconstruction

using System;

namespace Exercises2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // int[] numbers = { 10, 8, 2, 19, 20, 56, 87, 36, 99, 101, 20, 10, 43, 209, 130, 99 };
            //
            // // 上节课学的升序排列（冒泡排序）
            // // 现在，我们要来实现降序排列了
            // // 思考一下：应该如何实现？
            // // 连幼儿园小朋友都知道：反过来不就行了吗？
            // // 问题是：应该在哪反过来？
            // // 这块有必要修改吗？
            // // 完全没必要对吧？因为这两层循环，只负责解决组合问题
            // // 也就是说，它是负责数字间两两进行比较用的
            // // 因此，完全没必要动这块
            // // 需要动的部分在哪呢？
            // for (int i = 0; i < numbers.Length - 1; i++)
            // {
            //     for (int j = 0; j < numbers.Length - 1 - i; j++)
            //     {
            //         // 应该在交换放置顺序这块
            //         // 其中这条交换条件
            //         // 这段代码，现在的含义是：遇到较大元素，就满足该条件，就要进到下面进行位置交换
            //         // 从而实现：小的放前面，大的放后面
            //         // 反过来，就变成：
            //         // 代码特别简单，就改了这么一个符号，就实现了相反的效果
            //         // 但思考过程比较复杂
            //         if (numbers[j] < numbers[j + 1])
            //         {
            //             // 变量名称也要修改一下，刚才 maxValue 代表的是较大元素，现在应该是较小元素了
            //             int minValue = numbers[j];
            //             numbers[j] = numbers[j + 1];
            //             numbers[j + 1] = minValue;
            //         }
            //     }
            // }
            //
            // // 我在输出数组元素之前，添加一条元素反转语句：
            // // 顺序又变成升序了
            // // 此操作不只针对排序后的数组，未排序的，也可以进行反转
            // Array.Sort(numbers);
            //
            // for (int i = 0; i < numbers.Length; i++)
            // {
            //     Console.WriteLine(numbers[i]);
            // }
            //
            // Console.ReadKey();
            //
            // 拓展：使用系统自带 Reverse() 工具，解决数组元素反转问题
            // 之前讲过 Array.Sort() 工具，这次讲的，与其类似，可以直接点出来
            // Array.Sort();

            // 练习：输出九阶乘法口诀表
            // 还是我们小学时候学过的
            // 看起来像这样：
            // 1x1=1
            // 2x1=2 2x2=4
            // 3x1=3 3x2=6 3x3=9

            // 怎么来实现？我要输出两数相乘，用一个循环，肯定还是完成不了的。
            // 还得是嵌套循环，对吧？
            // 现在外层循环应该能直接马上写出来了
            // 外层循环也能改，这次试试把它倒转
            // for (int i = 9; i >= 1; i--)
            // {
            //     // 我还可以通过添加几个空格（标准制表符），让整个口诀表再水平翻转
            //     // 简单讲一下这个原理
            //     // 水平方向翻转，差的是什么？是不是就差那几个空格
            //     // 9 开头那一行，没什么可说的，就那一个式子
            //     // 从 8 开始，每次都会差一个式子，因为数字每次少1
            //     // 我只要能算出来应该加几个空格，给它们“拱”到右边去，是不是就实现了这个翻转效果了？
            //     for (int k = 0; k < 9 - i; k++)
            //     {
            //         Console.Write("\t");
            //     }
            //
            //     // 这个例子，可玩性较高
            //     // 先给循环反过来
            //     for (int j = i; j >= 1; j--)
            //     {
            //         // 进行结果输出
            //         // 注意：为什么没直接用 WriteLine()
            //         // 因为需要等这一行的式子全都输出完毕之后，才到下一行
            //         Console.Write($"{i}x{j}={i * j}\t");
            //     }
            //
            //     // 输出完一行之后，要记得换行，否则会导致全都放在一块
            //     Console.WriteLine();
            // }
            //
            // Console.ReadKey();

            // 最后一个练习
            // 现在有这样一个字符串，里面放的是几个虚构的人名
            // 比如，我现在把字符串修改为这样
            // 现在，有些名字是用句号分隔的，其中还混杂着用逗号分隔的
            string names = "张三。     李四，王五，    翟嘻嘻，  韩小美。朱坚强";

            // 我现在希望：把里面的名字都提取出来，给每个名字后面加上 ｜ 将这些名字分隔开
            // 回顾：咱们已经学过了 ToCharArray() 工具
            // 但是，放在这个场景来使用的话，会非常麻烦
            // 因为是将整个字符串拆成 char 类型数组，打得太散了
            // 我们更希望：直接能把名字提取出来；也就是：把整个字符串给它切成一段一段的
            // 实际上，我们可以使用系统给 string 类型变量提供的 Split() 工具，完成这件事
            // 用法：string splitStr = myStr.Split(chars, options);
            // 也就是说，这个工具会将分割后的字符串，装入一个 string 类型数组，作为结果
            // 这个和 ToCharArray() 很像
            // 我们需要填入两个值：一个 char 字符，工具会按照这个字符，对字符串进行切割
            // 第二个是字符串切割选项
            // 比如，现在每个名字都被一个中文的逗号隔开了，我们就可以把这个字符 '，' 填入工具中
            // 但是，这个工具很特殊。准确来说，前面填写的，可以不止一个 char 字符，甚至可以是一个 char 类型数组
            // 这种情况下，我们就需要让两种符号，都作为分隔符
            // char[] separators = { '，', '。' };

            // 然后将该数组填入工具中
            // 上面不是说要填写两个值吗？现在没填写，居然没出语法错误
            // string[] splitNames = names.Split(separators);

            // 先声明数组，再填入的话，看起来比较麻烦
            // 这个工具有一个特殊之处：你可以直接往里面填入多个分隔符号
            // string[] splitNames = names.Split('，', '。', ' ');

            // 现在还有一个问题：空格被留下了
            // 为了去掉这些空格，我们还需要在分隔符号数组中，加入空格字符

            // 空格依然存在于数组中，这次我们就要用到 options 了
            // 系统提供了删除数组中空格的选项：StringSplitOptions.RemoveEmptyEntries
            // 因此，我们现在直接这样写：
            // 语法出错，不允许这么使用
            // string[] splitNames = names.Split('，', '。', ' ');

            // char[] separators = { '，', '。', ' ' };
            // string[] splitNames = names.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            //
            // // 最后，用 for 循环输出姓名，使用竖线分隔开
            // for (int i = 0; i < splitNames.Length; i++)
            // {
            //     Console.Write(splitNames[i]);
            //
            //     // 这个判断是干嘛的？
            //     // 最后一次输出，还需要加竖线吗？肯定不需要了
            //     // 这个判断条件，可以避免输出多余的竖线
            //     if (i < splitNames.Length - 1)
            //     {
            //         Console.Write(" | ");
            //     }
            // }
            //
            // Console.ReadKey();

            // 最后一个知识点：foreach 循环，这也是最后一种循环结构了
            // 基本代码结构：
            // 这个循环的作用是：把数组里的元素直接拿出来，无需先声明计数变量，然后再通过索引访问数组中的元素
            // （暂时就记成是数组吧，实际上还可以是别的东西，以后再讲）
            // foreach (ElementType element in ElementArray)
            // {
            //     Some code
            // }

            // 使用实际代码，对以上结构进行填充：
            // int[] numbers = { 1, 2, 3, 4, 5 };
            //
            // // 非得使用手动计数
            // int index = 0;
            //
            // // 结果为：1-5
            // // 其它类型的数组变量，也可以这么用，我就不一一进行演示了
            // foreach (int number in numbers)
            // {
            //     // 语法出错，禁止对该变量重新赋值
            //     // number = 100;
            //
            //     // Console.WriteLine(number);
            //     
            //     // 再来看看这样
            //     // “小蜜蜂”们注意：可以暂时保持辛勤，后续就要懒惰一点了
            //     // 学到后面的内容，就会了解到一些“翻车”场景了
            //     numbers[index] += number;
            //     
            //     // 这样写貌似没什么问题
            //     Console.WriteLine(
            //         $"当前是第{index + 1}个元素，是{numbers[index]}；确认过了，{(numbers[index] == number ? "相等" : "不相等")}");
            //
            //     index++;
            // }
            //
            // Console.ReadKey();
            
            // 流程控制语句总结（树状图）
            // |- 流程控制语句
            //     |- 异常处理语句(Exception handling statements)
            //          |- try-catch 异常捕获结构
            //     |- 分支语句 (Branching statements)
            //          |- if-elseif-else 选择结构
            //          |- switch-case 开关结构
            //     |- 跳转语句 (Jump statements)
            //          |- break 跳出关键字
            //          |- continue 继续关键字（提前结束当前循环作用域中代码的执行）
            //     |- 循环语句 (Loop statements)
            //          |- while 循环结构
            //          |- do-while 循环结构
            //          |- for 循环结构
            //          |- foreach 循环结构

        }
    }
}