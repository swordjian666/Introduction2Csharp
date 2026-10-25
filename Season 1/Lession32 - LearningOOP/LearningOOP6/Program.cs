using System;

namespace LearningOOP6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Student();
            person.DoSelfIntroduction();

            // Student student = new Person();
            
            // object personObj = new Person();
            // Person personObj2 = (Person)personObj;
            // Person personObj2 = personObj;
            // personObj2.DoSelfIntroduction();

            // object studentObj = new Person();
            // var student = (Student)studentObj;
            // student.DoSelfIntroduction();

            // var purePerson = new Person();
            // bool isPurePerson = purePerson is Person;
            // bool isPureStudent = purePerson is Student;
            //
            // Console.WriteLine(isPurePerson);
            // Console.WriteLine(isPureStudent);
            // Console.WriteLine();
            //
            // var student = new Student();
            // bool isPerson = student is Person;
            // bool isStudent = student is Student;
            //
            // Console.WriteLine(isPerson);
            // Console.WriteLine(isStudent);
            // Console.WriteLine();
            //
            // Person realPerson = new Student();
            // bool isRealPerson = realPerson is Person;
            // bool isRealStudent = realPerson is Student;
            //  
            // Console.WriteLine(isRealPerson);
            // Console.WriteLine(isRealStudent);
            // Console.WriteLine();

            // object studentObject = new Student();

            // if (studentObject is Person)
            // {
            //     var studentPerson = (Person)studentObject;
            // }

            // if (studentObject is Person studentPerson)
            // {
            //     
            // }
            
            // object studentObject = new Student();
            // var studentPerson = studentObject as Student;

            // Student nullStudent = null;

            // if (studentPerson != null)
            // {
            //     
            // }

            // object numberObj = 10;
            // var number = numberObj as int;
            
            Console.ReadKey();
        }
    }
}