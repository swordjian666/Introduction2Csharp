using System;

namespace LearningOOP2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            #region 构造函数用法演示

            // Person zhangSan = new Person();
            // Initialize(zhangSan, "张三", 18, '男');

            // Person xiaoHong = new Person();
            // Initialize(xiaoHong, "小红", 20, '女', "学生");

            // Person zhangSan = new Person("张三", 18, '男');
            // zhangSan.DoSelfIntroduction();
            //
            // Person xiaoHong = new Person("小红", 20, '女', "学生");
            // xiaoHong.DoSelfIntroduction();

            #endregion 构造函数用法演示

            Person grandpaaaaaaaa = new Person("老爷爷爷爷爷爷爷爷爷爷", 10000, '男');
            // int age = grandpaaaaaaaa._age;

            grandpaaaaaaaa.DoSelfIntroduction();

            // grandpaaaaaaaa.SetAge(60);
            grandpaaaaaaaa.Age = 60;

            // 无权限修改
            // grandpaaaaaaaa.Sex = '男';
            // 正常访问
            Console.WriteLine(grandpaaaaaaaa.Sex);

            grandpaaaaaaaa.DoSelfIntroduction();

            Console.ReadKey();
        }

        #region 方法调用重载演示

        // private static void Initialize(Person target, string name, int age, char sex)
        // {
        //     target._name = name;
        //     target._age = age;
        //     target._sex = sex;
        //
        //     // 递归调用
        //     // Initialize(target, name, age, sex);
        // }
        //
        // private static void Initialize(Person target, string name, int age, char sex, string career)
        // {
        //     // target._name = name;
        //     // target._age = age;
        //     // target._sex = sex;
        //
        //     // 这不是方法递归
        //     Initialize(target, name, age, sex);
        //     target._career = career;
        // }

        #endregion
    }

    internal class Person
    {
        public Person()
        {
        }

        public Person(string name, int age, char sex)
        {
            // _name = name;
            Name = name;

            // _age = age;
            // SetAge(age);
            Age = age;

            // _sex = sex;
            Sex = sex;
        }

        public Person(string name, int age, char sex, string career)
            : this(name, age, sex)
        {
            // _career = career;
            Career = career;
        }

        // private string _name;
        // public string Name
        // {
        //     get => _name;
        //     set => _name = value;
        // }

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

        private string _career;

        public string Career
        {
            get => _career;
            set => _career = value;
        }

        public double Salary
        {
            get
            {
                if (_career == "程序员")
                {
                    return 10000.66;
                }

                return 0;
            }
        }

        public void DoSelfIntroduction()
        {
            Console.WriteLine($"你好，我是{Name}，我今年{_age}岁，是一个{_sex}生。");

            if (string.IsNullOrEmpty(_career))
            {
                _career = "未知";
            }

            Console.WriteLine($"我的职业：{_career}");
        }
    }
}