using System;

namespace LearningOOP5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // var student = new Student();

            // var student = new Student
            // {
            //     Name = "张三",
            //     Age = 18,
            //     // Sex = '男',
            //     Career = "学生"
            // };

            // var student = new Student("张三", 18, '男');

            // char sex = student.Sex;

            // char sexField = student._sex;
            
            // student.DoSelfIntroduction();

            // var student2 = new Student();
            // Console.WriteLine(student2.Career);
            
            var student = new Student("张三", 18, '男');

            int hashCode = student.GetHashCode();
            Console.WriteLine(hashCode);
            
            Student studentCopy = student;
            Console.WriteLine(studentCopy.GetHashCode());

            Console.ReadKey();
        }
    }
}