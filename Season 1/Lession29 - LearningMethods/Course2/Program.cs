using System;

namespace Course2
{
    internal class Program
    {
        // 不同的炸鸡，依然需要定义不同的枚举类型来进行表示

        enum DeepFriedChicken
        {
            // 油锅炸鸡

            // 小份
            Small,

            // 中份
            Medium,

            // 大份
            Large
        }

        enum AirFriedChicken
        {
            // 空气炸锅炸鸡

            // 小份
            Small,

            // 中份
            Medium,

            // 大份
            Large
        }

        enum DeepFryer
        {
            // 油锅

            // 小锅
            Small,

            // 大锅
            Large
        }

        enum AirFryer
        {
            // 空气炸锅

            // 小锅
            Small,

            // 大锅
            Large
        }

        enum ToolBox
        {
            // 螺丝刀工具盒

            // 一字头
            Slotted,

            // 十字头
            Phillips
        }

        enum SlottedScrewdriver
        {
            // 一字头螺丝刀

            // 头宽 3mm
            // 长度忽略
            SLOT3
        }

        enum PhillipsScrewdriver
        {
            // 十字头螺丝刀

            // 型号
            // 数字越大，刀头越大
            PH1,
            PH2,
            PH3,
        }

        enum Screwdriver
        {
            // 螺丝刀

            // 一字型螺丝刀
            SlottedScrewdriver,

            // 十字型螺丝刀
            PhillipsScrewdriver
        }

        public static void Main(string[] args)
        {
            // 方法的下一个知识点：方法的重载（Method overloads）
            // 什么是方法的重载？
            // 白话解释：几个方法的名称，都是一样的。可以有不同的返回值，和不同的参数
            // 也就是说：实现某种目标的手段，可以是不同的

            // 现在要来写两个方法，分别表示油锅炸鸡和空气炸锅炸鸡
            // 油锅炸鸡方法，返回值应该是油炸鸡
            // 空气炸锅炸鸡方法，需要返回少油炸鸡

            // "".Split()
            // FryChicken()

            // 现实中点炸鸡，一般我们都去快餐店
            // 想吃什么样的炸鸡，让店员在订单上备注一下就行了
            // 不需要你自己去提供炸锅
            // 什么意思？就是说：你想吃的时候，直接点餐就可以了
            // 也就相当于：你直接调用它们其中的一个方法，而无需填入参数，就行了

            // 现在再来调用炸鸡方法，系统没法判断到底要调用哪个了，已经乱套了
            // FryChicken();

            // Array.Sort();

            // Rider 可以识别多行注释，它认可这种写法
            // 实际上，Java 里的代码注释，就这么写，它叫做：JavaDoc
            // JetBrains 的 IDE，包括 Rider 本身，它的页面大部分都是 Java 写的
            // 因此 Rider 可以识别这种方法注释，但 Visual Studio 中就不行了
            // ChangeBit()
        }

        // 去掉炸锅参数之后，语法出错
        // 为什么？
        // 返回值的类型，只能有一种
        //修改完之后的方法，相当于一个方法既能返回 DeepFriedChicken，又能返回 AirFriedChicken
        // 这一次，没有具体参数做限制了
        // 因此需要注意：多个方法，在参数保持一致的情况下，例如，现在这种都没写参数的情况
        // 或者填写的参数都是完全相同的，只有返回值是不同的
        // 这种情况下，不能构成方法重载

        // private static DeepFriedChicken FryChicken()
        // {
        //     // 炸鸡我喜欢吃大份的，就返回个 Large
        //     return DeepFriedChicken.Small;
        // }
        //
        // private static AirFriedChicken FryChicken()
        // {
        //     // 家用的空气炸锅容量都比较小，返回个 Small 吧
        //     return AirFriedChicken.Small;
        // }


        // 更换刀头：ChangeBit
        // 下面来模拟从工具盒中取刀头的两个方法，分别返回一字头螺丝刀和十字头螺丝刀
        // 这种写法是非常错误的，和刚才一样，已经一片红了
        // 按照常规思考：“你看，我给螺丝刀换头，都是在那同一个工具盒里拿出来的”
        // “装上刀头之后，就组成了不同类型的螺丝刀”

        // 如果按照上面那种思维方式来思考问题的话，就会掉入方法重载的陷阱里

        // 正确思考问题的方式
        // 1. 参考炸鸡的例子，给一个工具盒强制拆成几个小的工具盒
        // 例如：每个工具盒中的螺丝刀头是不同的
        // A 盒子只装不同规格的一字刀头；B 盒子只装不同规格的十字刀头
        // 这样的话，方法的参数就能区分开
        // 代码和炸鸡那个例子类似，我不演示了

        // 2. 一个方法能解决的问题，压根就不要再去写方法重载了
        // 手柄和刀头组装出来的东西，本质上依然是一把螺丝刀
        // 工具箱就放在那，不用变
        // 我单独写一个 Screwdriver 螺丝刀类型枚举，成员写为不同类型的螺丝刀，不就行了吗？


        // 编写方法注释


        // 我是一条方法注释
        // /**
        //  * 这个方法可以帮助我们更换螺丝刀头
        //  */

        //  Arguments，简称 Args，指的是：实参
        //  Parameter，简称 Param，指的是：形参
        //  为什么 Main 方法中写的是 args，而不是 params
        //  小剧透：params 是一个系统保留关键字，讲 Split 方法的时候，看过了
        //  而且，这也是设计的哲学

        // 方法注释中的尖括号结构：XML 文档格式，暂时先不讲
        
        /// <summary>
        /// 更换螺丝刀头方法，从工具箱中取出刀头，然后安装到手柄上，组成类型不同的螺丝刀
        /// </summary>
        /// <param name="toolBox">螺丝刀头工具箱</param>
        /// <returns>螺丝刀类型枚举变量，可以是组合后的各种螺丝刀</returns>
        private static Screwdriver ChangeBit(ToolBox toolBox)
        {
            // 需要注意（重点）：
            // 有返回值的方法，必须保证在所有情况下，方法都有值可以返回
            // 例如当前例子中
            if (toolBox == ToolBox.Slotted)
            {
                // 不能只在 if 分支里 return 一下就完事了
                // 这块代码可能压根就不会被执行（条件没满足的时候）
                return Screwdriver.SlottedScrewdriver;
            }

            // 所以在外层，也需要 return 一下
            return Screwdriver.PhillipsScrewdriver;
        }

        // bool canChangeBit 代表刀头是否可以更换

        // 调换参数的位置之后
        // 语法居然不出错了

        // 注意：不可以单纯地通过交换参数位置，规避到语法层面的问题
        // 以后写代码的时候，仍然要时刻提醒自己：是否真的需要方法重载

        // private static SlottedScrewdriver ChangeBit(ToolBox toolBox, bool canChangeBit)
        // {
        //     return SlottedScrewdriver.SLOT3;
        // }
        //
        // private static PhillipsScrewdriver ChangeBit(bool canChangeBit, ToolBox toolBox)
        // {
        //     return PhillipsScrewdriver.PH1;
        // }
    }
}