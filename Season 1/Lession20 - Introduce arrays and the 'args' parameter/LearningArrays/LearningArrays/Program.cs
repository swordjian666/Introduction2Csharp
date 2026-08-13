using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningArrays
{
    internal class Program
    {
        static void Main()
        {
            //Console.WriteLine($"参数数组的长度是{args.Length}");
            //Console.WriteLine($"参数数组的第一个元素是{args[0]}");
            //Console.WriteLine($"参数数组的第二个元素是{args[1]}");

            //Console.ReadKey();

            // 试试不在一行上写会怎么样
            // 会产生语法错误
            //int[] numbers;
            //numbers = { 1,2,3,4,5 };

            // 后面的中括号，名字是：索引器
            // 作用是：通过索引访问集合变量中的元素
            //int firstNumber = numbers[0];

            // 现在来输出一下 firstNumber 变量，看看结果是多少
            //Console.WriteLine(firstNumber);
            //Console.ReadKey();

            // 输出第三个元素
            //Console.WriteLine(numbers[2]);
            //Console.ReadKey();

            // 对其中的某个值进行修改：
            //numbers[2] = 20;
            // 现在再来看看第三个元素的值是多少
            //Console.WriteLine(numbers[2]);
            //Console.ReadKey();

            // 数组越界问题
            // 例如，现在我写一个空数组
            // 里面什么都没有
            //int[] emptyNumbers = { };
            // 尝试读取并不存在的元素
            // 例如，并不存在的第一个元素
            //Console.WriteLine(emptyNumbers[0]);

            // 注意：这些东西要写在同一行上
            //int[] numbers = { 1, 2, 3, 4, 5 };

            // 通过 Length 工具，获取当前数组的长度
            // 也就是里面有几个元素
            //int lengthOfNumbers = numbers.Length;
            // 输出 numbers 数组变量的长度
            //Console.WriteLine($"当前数组的长度是：{lengthOfNumbers}");
            //Console.ReadKey();

            // 数组排序工具
            //int[] numbers = { 10, 87, 15, 200, 195, 300, 45, 23, 99, 105 };
            // 使用排序工具，对数组进行重新排序
            // 默认是按照从小到大的顺序，对所有数字进行排序
            // 也可以从大到小进行排序，但需要自己手动进行实现
            // 这个暂时没法讲
            //Array.Sort(numbers);

            // 再来看 char 和 string 两个类型
            //char[] characters = { '你', '好', '，', '我', '是', 'T', 'o', 'm' };
            // 仔细观察一下，这两个东西有没有什么关系？
            // 是不是把这个字符串挨个字符拆解之后，就能得到上面的东西？
            //string greeting = "你好，我是Tom";

            // 实际上，可以进行拆解
            // 使用系统给 string 提供的 ToCharArray 工具来完成
            //char[] greetingParts = greeting.ToCharArray();
        }
    }
}
