using System;

namespace LearningOOP4
{
    internal static class PersonExtensions
    {
        // 语法出错
        // public int Number { get; set; }

        // public PersonExtensions()
        // {
        //     
        // }
        
        static PersonExtensions()
        {
            
        }

        public static void SendMessage(this Person current, Person target, string message)
        {
            Console.WriteLine($"{target.Name}，晚上好，我是{current.Name}");
            Console.WriteLine(message);
        }
    }
}