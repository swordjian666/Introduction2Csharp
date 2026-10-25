using System;
using LearningAccessModifiers.AreaA;

namespace LearningAccessModifiers2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"XiaoMing's Number1: {XiaoMingsHouse._number1}");
            Console.WriteLine($"XiaoMing's Number2: {XiaoMingsHouse._number2}");
            
            XiaoMingsHouse.PrintNumbers();
        }
    }
}