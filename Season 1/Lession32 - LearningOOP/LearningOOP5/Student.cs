using System;

namespace LearningOOP5
{
    public class Student : Person
    {
        public Student()
        {
        }

        public Student(string name, int age, char sex)
            : base(name, age, sex)
        {
        }

        public Student(string name, int age, char sex,
                string school, string studentId)
            : base(name, age, sex, "学生")
        {
            School = school;
            StudentId = studentId;
        }

        public string School { get; private set; }

        public string StudentId { get; set; } = string.Empty;

        // public void PrintSex()
        // {
        //     Console.WriteLine($"我的性别是：{this.Sex}");
        //
        //     char sex = _sex;
        // }
    }
}