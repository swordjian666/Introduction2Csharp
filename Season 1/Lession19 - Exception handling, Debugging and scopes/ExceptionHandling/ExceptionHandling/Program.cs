using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //{
            //    int number1 = 10;
            //    int number3 = 5;
            //}


            //{
            //    int number1 = 10;
            //}

            //int number1 = 100;

            //int number2 = 20;

            try
            {
                //int invalidNumber = int.Parse("3");
                Console.Write("请输入一个数字：");
                string input = Console.ReadLine();
                int parsedNumber = int.Parse(input);
                Console.WriteLine($"转换成功，输出转换值{parsedNumber}");
            }
            catch
            {
                Console.WriteLine("转换失败，输出默认值 -1");
            }
            Console.WriteLine("看谁笑到最后");
            Console.ReadKey();
        }
    }
}
