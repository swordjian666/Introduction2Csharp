using System;

using static System.Console;

namespace LearningOOP4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // var extension = new PersonExtensions();

            var zhangSan = new Person("张三", 18, '男');
            var wangWu = new Person("王五", 19, '男');
            
            zhangSan.SendMessage(wangWu,"王哥，明天下午来打篮球吗？");
            wangWu.SendMessage(zhangSan,"不去了，天气预报说明天下雨");

            ReadKey();
        }

        #region 静态方法演示

        // private static int _number1;
        // private static int _number2;
        //
        // private static void ChangeNumber(int number1, int number2)
        // {
        //     _number1 = number1;
        //     _number2 = number2;
        // }

        #endregion 静态方法演示
    }

    internal class Person
    {
        static Person()
        {
            
        }
        
        public Person()
        {
        }

        public Person(string name, int age, char sex)
        {
            Name = name;
            Age = age;
            Sex = sex;
        }

        public Person(string name, int age, char sex, string career)
            : this(name, age, sex)
        {
            Career = career;
        }

        // private static string _description;
        //
        // public static string Description
        // {
        //     get => _description;
        //     set => _description = value;
        // }

        public static string Description { get; set; } = "这是人类";

        /// <summary>
        /// Name 属性（自动属性）
        /// </summary>
        public string Name { get; set; }

        private int _age;

        /// <summary>
        /// Age 属性（Property）
        /// </summary>
        public int Age
        {
            // get accessor：get 访问器
            get => _age;
            // set accessor：set 访问器
            set
            {
                if (value > 125 || value < 0)
                {
                    // 通常不会在这里输出文字，仅供演示用途
                    Console.WriteLine($"提供的年龄值：{value} 是无效的，年龄自动重置为0");
                    _age = 0;

                    return;
                }

                _age = value;
            }
        }

        private char _sex;

        public char Sex
        {
            get => _sex;
            private set
            {
                if (value != '男' && value != '女')
                {
                    Console.WriteLine($"提供的性别信息：{value} 是无效的");

                    return;
                }

                _sex = value;
            }
        }

        public string Career { get; set; } = "自由职业";

        public double Salary
        {
            get
            {
                if (Career == "程序员")
                {
                    return 10000.66;
                }

                return 0;
            }
        }

        public void DoSelfIntroduction()
        {
            Console.WriteLine($"你好，我是{Name}，我今年{_age}岁，是一个{_sex}生。");

            if (string.IsNullOrEmpty(Career))
            {
                Career = "未知";
            }

            Console.WriteLine($"我的职业：{Career}");
        }

        public static void SayHello(string name)
        {
            Console.WriteLine($"你好，{name}！");
        }
    }
}