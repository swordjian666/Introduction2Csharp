using System;

namespace LearningAccessModifiers.AreaA
{
    public class XiaoMingsHouse
    {
        public static int _number1 = 20;
        public static int _number2 = 10;

        public static void PrintNumbers()
        {
            Console.WriteLine($"Number1: {_number1}");
            Console.WriteLine($"Number2: {_number2}");
            
            Console.WriteLine($"Main Number: {Program._mainNumber}");
        }
    }
}