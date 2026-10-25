using System;

namespace LearningOOP5
{
    public class Person : object
    {
        public Person()
        {
            Career = "自由职业";
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
        /// 姓名属性
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 年龄字段
        /// </summary>
        private int _age;

        /// <summary>
        /// 年龄属性
        /// </summary>
        public int Age
        {
            get => _age;
            set
            {
                if (value < 0 || value > 125)
                {
                    _age = 0;
                    return;
                }

                _age = value;
            }
        }

        /// <summary>
        /// 性别字段
        /// </summary>
        protected char _sex;

        /// <summary>
        /// 性别属性
        /// </summary>
        public char Sex
        {
            get => _sex;
            private set
            {
                if (value != '男' && value != '女')
                {
                    return;
                }

                _sex = value;
            }
        }

        /// <summary>
        /// 职业属性
        /// </summary>
        public string Career { get; set; }

        /// <summary>
        /// 人类的自我介绍方法
        /// </summary>
        public void DoSelfIntroduction()
        {
            Console.WriteLine($"你好，我是{Name}，我今年{Age}岁了，是个{Sex}生。");
        }
    }
}