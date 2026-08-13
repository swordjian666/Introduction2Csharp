using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 我们最开始接触到的这段话，实际上就是一个字符串
            string text = "Hello, World!";

            // 再次输出这段文本，通过输出 text 变量完成
            //Console.WriteLine(text);
            //Console.ReadKey();

            // 声明一个 double 类型的变量
            double dNumber = 3.1415926;
            // 转换为 string 类型
            string strNumber = dNumber.ToString();

            // 字符串的基本操作
            // 转义序列
            // 1. 文本换行
            //Console.WriteLine("我是第一行\n我是第二行\n我是第三行");
            //Console.ReadKey();

            // 2. 加入标准制表符
            //Console.WriteLine("我是第一\t我是第二\t我是第三");
            //Console.ReadKey();

            // 3. 显示字符本来的意思（显示本义字符）
            // macOS 文件路径
            // 可以正常显示
            //Console.WriteLine("/Users/xiaoming/Desktop/MyDocument.txt");
            //Console.ReadKey();

            // Windows 文件路径
            // 直接写报语法错误
            //Console.WriteLine("C:\Windows\System32");
            // 需要对斜杠进行转义
            //Console.WriteLine("C:\\Windows\\System32");
            //Console.ReadKey();

            // 上述方法需要手敲斜杠，有没有其它方法？

            // 4. 整体转义
            //Console.WriteLine(@"C:\Windows\System32");
            //Console.ReadKey();

            // 但是会有一个问题，例如
            //Console.WriteLine(@"C:\Wi\nndows\Sy\tstem32");

            // 将会导致原本的转义序列失效，无法换行或者添加标准制表符

            //Console.ReadKey();

            // 可以通过直接手敲回车解决
            //            Console.WriteLine(@"C:\
            //Windows\Sys
            //tem32");
            //            Console.ReadKey();

            //            Console.WriteLine(@"我是第一行啊啊
            //啊啊
            //啊啊啊我是   第三行啊啊啊
            //啊啊啊啊    啊啊啊
            //我是第五行   啊啊啊啊");

            //            Console.ReadKey();


            // 文本的格式化
            // 基本的代码格式：
            // string myString = string.Format(format, variable);
            // format: 实际上是一个字符串，需要在其中填写想要的格式
            // variable: 需要填写某个类型的变量进去

            // 几个常见的例子

            // 1. “挖坑和填坑”占位法
            // 假设现在有一名张三同学
            // 定义他的姓名
            string name = "张三";

            // 定义他的年龄
            int age = 18;

            // 定义他的性别
            // 这里用 sex 这个单词，因为它只表示传统的二元性别，也就是 男性 或 女性
            // 还有一个单词 gender，它表示心理上的自我认同
            // 例如：生理男性，同时心理女性
            char sex = '男';

            // 现在，我想让张三同学进行自我介绍，打印一行自我介绍的文本到控制台，应该怎么做？

            // 用我们学过的 Console.WriteLine() ？
            //Console.WriteLine("大家好，我是");
            //Console.WriteLine(name);
            // ...

            // 由于上面的方法看起来很别扭，我们使用Console下的另一个工具 Write() 来实现一下
            //Console.Write("大家好，我是");
            //Console.Write(name);
            //Console.Write("\n我是个");
            //Console.Write(sex);
            //Console.Write("生\n");
            //Console.Write("我今年");
            //Console.Write(age);
            //Console.Write("岁了\n");
            //Console.WriteLine("以上就是张三同学的自我介绍，请大家以热烈的掌声欢迎他！");
            //Console.ReadKey();

            // 上面用了很多行代码，是不是太麻烦？
            // 接下来使用 string.Format() 工具进行代替
            //string selfIntro = string.Format("大家好，我是{0}，我今年{1}岁了，是个{2}生", name, age, sex);

            // 少挖坑，但多填坑
            //string selfIntro = string.Format("大家好，我是，我今年{1}岁了，是个{2}生", name, age, sex);

            // 乱改序号
            //string selfIntro = string.Format("大家好，我是，我今年{0}岁了，是个{2}生", name, age, sex);

            // 多挖坑，但少填坑
            // 程序报错
            //string selfIntro = string.Format("大家好，我是{0}，我今年{1}岁了，是个{2}生", name, sex);

            //Console.WriteLine(selfIntro);
            //Console.ReadKey();

            // Console.Write() 和 Console.WriteLine() 这两个工具，支持 string.Format()
            //Console.WriteLine("大家好，我是{0}，我今年{1}岁了，是个{2}生", name, age, sex);

            // 也可以不用声明变量，直接填入对应的值
            //Console.WriteLine("大家好，我是{0}，我今年{1}岁了，是个{2}生", "张三", 18, '男');

            //Console.ReadKey();

            // 除了萝卜坑方法，还可以使用字符串内插
            //string userName = "John Doe";
            //string folderName = "MyVideos";
            // $"{variable1}text{variable2}..."
            //string fullPath = $@"C:\Users\{userName}\{folderName}";
            //Console.WriteLine(fullPath);
            //Console.ReadKey();


            // 2. 自定义数字格式
            //double pi = 3.1415926;

            // 只要小数点后的前三位
            // 结果是3.142，自动进行了四舍五入（保留到小数点后第某位），而不是单纯地进行截取
            //Console.WriteLine("PI的小数点后面前三位是：{0:0.000}", pi);
            //Console.ReadKey();

            // 3. 0占位符
            // 现在有一个数字302.123，要求整数部分用四位数字表示
            // 整数部分：0302
            // 小数部分用两位数字表示，保留之后就是0.12
            // 用代码进行输出
            // 依然可以进行四舍五入（保留到小数点后两位）
            //Console.WriteLine("{0:0000.00}", 302.125);
            //Console.ReadKey();


            // string 类型的其它常用工具
            // 1. 获取当前字符串的长度
            //int length = "我是一二三。".Length;
            //Console.WriteLine(length);
            //Console.ReadKey();

            // 2. 字符串裁剪
            string banner = "一二三四五六七，今天天气好晴朗，处处都是好风光";
            // 例如，现在要去掉前面那几个大写数字
            // 首先要查前面有几个字符；算上逗号，一共是八个
            //string bannerCut = banner.Substring(8);
            //Console.WriteLine(bannerCut);

            // 还可以从指定的位置进行截取，比如我现在想要 “天气” 两个字
            // 首先要查它是从哪开始的；它前面有10个字，那么天气这两个字里面，‘天’字就是第11个
            // “天气” 这个词，它的长度为2
            //string bannerCut2 = banner.Substring(10, 2);
            //Console.WriteLine(bannerCut2);

            // 3. 获取字符的索引（下标）位置

            // 我们现在只查某一个字符的位置，因此填写的是 char 类型字符
            // 注意：有两个相同文字的时候，会优先给出第一个字符的位置
            int indexOfTian = banner.IndexOf('天');
            //Console.WriteLine(indexOfTian);

            // 上面已经得到了第一个天的位置，下面的天只跟它差了1
            // 我们可以设置字符的起始查找位置，手动跳过第一个天的位置
            // 我们暂时还没学运算符，先了解一下，我简单演示一下
            //int indexOfTian2 = banner.IndexOf('天', indexOfTian + 1);
            //Console.WriteLine(indexOfTian2);

            // 4. 替换字符串
            // 比如，我现在想把大写的一二三四五六七替换为1234567，可以通过
            //string banner2 = banner.Replace("一二三四五六七", "1234567");
            //Console.WriteLine(banner2);

            // 5. 将字符串中的英文字符全部改为大写或小写
            string englishBanner = "It's pretty nice today, good scene is here and there.";
            string bannerOfUpperCase = englishBanner.ToUpper();
            Console.WriteLine(bannerOfUpperCase);

            string bannerOfLowerCase = englishBanner.ToLower();
            Console.WriteLine(bannerOfLowerCase);

            Console.ReadKey();
        }
    }
}
