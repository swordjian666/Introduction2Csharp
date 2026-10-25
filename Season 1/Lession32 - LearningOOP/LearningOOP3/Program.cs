using System;

namespace LearningOOP3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            #region 空引用异常

            // 问题1：对象及其字段的初始化问题
            // Person person1;
            // person1.Age = 10;

            // Person person1 = null;
            // person1.Age = 10;

            // string myStr1;
            // string myStr2 = null;

            // Console.WriteLine(myStr1);
            // Console.WriteLine(myStr2);
            // Console.WriteLine(myStr2.Substring(2));

            // Person person2 = new Person();
            // person2.Age = 18;

            // Console.WriteLine(person2.Age);
            // Console.WriteLine(person2.Name.Substring(2));

            #endregion 空引用异常

            #region 自动属性初始化器

            // Person person3 = new Person("张三", 18, '男', "学生");

            #endregion 自动属性初始化器

            #region 对象初始化器

            // Person person3 = new Person("张三", 18, '男')
            // {
            //     // Name = "张三",
            //     // Age = 18,
            //     Career = "学生"
            // };

            // person3.Career = "学生";
            //
            // person3.DoSelfIntroduction();

            #endregion 对象初始化器

            #region var 关键字的使用

            // var person3 = new Person("张三", 18, '男');

            // var str1 = "处处好风光";
            //
            // var number1 = 10;
            // var number2 = 3.14;
            //
            // var number3 = (float)3.14;

            // var str1;
            // str1 = "Test";

            #endregion var 关键字的使用

            // Test();
            //
            // Test(20, "Test");
            // Test(param1: 20, param2: "Test");

            Test(param0: 3.1415926, param1: 20, param2: "Test");

            Test(param0: 3.1415926, param2: "Test");

            Console.ReadKey();
        }

        private static void Test(double param0, int param1 = 10, string param2 = "Test Content")
        {
        }
    }

    internal class Person
    {
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
    }
}