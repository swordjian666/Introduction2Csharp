using System;

using LearningAccessModifiers.AreaA;
using LearningAccessModifiers.AreaC;

namespace LearningAccessModifiers
{
    enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    
    // 视作是你家
    internal class Program
    {
        public static int _mainNumber = 100;
        
        public static void Main(string[] args)
        {
            Console.WriteLine($"我朋友小明家的便宜玩具车的价格 1：{XiaoMingsHouse._number1}");
            Console.WriteLine($"我朋友小明家的便宜玩具车的价格 2：{XiaoMingsHouse._number2}");
            
            XiaoMingsHouse.PrintNumbers();
            
            Console.WriteLine($"我朋友小红家的便宜洋娃娃的价格 1：{XiaoHongsHouse._number1}");
            Console.WriteLine($"我朋友小红家的便宜洋娃娃的价格 2：{XiaoHongsHouse._number2}");
            
            XiaoHongsHouse.PrintNumbers();
        }
    }
}