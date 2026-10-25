using System;

namespace LearningOOP
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            #region 面向对象基础（引入构造函数前）

            // Person._name = "张三";
            // Person._age = 18;
            // Person._sex = '男';

            // ChangePersonInfo("张三",18,'男');
            // Person.DoSelfIntroduction();
            //
            // ChangePersonInfo("小红",20,'女');
            // Person.DoSelfIntroduction();
            //
            // Console.ReadKey();

            // 创建一个 Person 对象
            // 或者，叫做：实例化一个 Person 对象
            // Person zhangSan = new Person();

            // zhangSan._name = "张三";
            // zhangSan._age = 18;
            // zhangSan._sex = '男';

            // ChangePersonInfo(zhangSan, "张三", 18, '男');
            //
            // Person zhangSanCopy = zhangSan;
            // zhangSanCopy._age = 22;

            // 输出什么结果？
            // zhangSan.DoSelfIntroduction();
            //
            // Person xiaoHong = new Person();

            // xiaoHong._name = "小红";
            // xiaoHong._age = 20;
            // xiaoHong._sex = '女';

            // ChangePersonInfo(xiaoHong, "小红", 20, '女');
            //
            // xiaoHong.DoSelfIntroduction();
            //
            // Console.WriteLine($"张三的年龄：{zhangSan._age}");
            //
            // Console.ReadKey();

            // string result = "今天天气好晴朗".Substring(2);

            #endregion 面向对象基础（引入构造函数前）

            // new Person("张三", 18, '男')
            // 这个行为，我们称之为：通过构造函数，将对象初始化
            Person zhangSan = new Person("张三", 18, '男');
            zhangSan.DoSelfIntroduction();

            // 再次尝试无参构造函数，创建一个新的 Person 对象
            Person alice = new Person();

            Person xiaoHong = new Person("小红", 20, '女');
            xiaoHong.DoSelfIntroduction();

            Console.ReadKey();
        }

        // private static void ChangePersonInfo(Person target, string name, int age, char sex)
        // {
        //     target._name = name;
        //     target._age = age;
        //     target._sex = sex;
        // }
    }

    internal class Person
    {
        public Person()
        {
        }

        public Person(string name, int age, char sex)
        {
            _name = name;
            _age = age;
            _sex = sex;
        }

        public string _name;
        public int _age;
        public char _sex;

        public void DoSelfIntroduction()
        {
            Console.WriteLine($"你好，我是{this._name}，我今年{_age}岁，是一个{_sex}生。");

            // 语法出错
            // this.Test();

            Test();
        }

        private static void Test()
        {
            
        }
    }
}