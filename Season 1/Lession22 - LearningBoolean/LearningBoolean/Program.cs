using System;

namespace LearningBoolean
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // 命题和命题的否定
            // P = “当前用户是老师” 为假
            // bool isTeacher = false;
            // ¬P=“当前用户不是老师” 为真
            // 离散数学中的否定符号¬，在C#中对应的是!叹号
            // bool isNotTeacher = !isTeacher;
            // 输出结果，发现结果为True，也就是真
            // Console.WriteLine(isNotTeacher);
            // Console.ReadKey();

            // 逻辑与运算
            // P = “当前用户是老师”
            // bool isTeacher;
            // Q = “当前用户是行政管理人员”
            // bool isAdministrator;

            // 1. P = “当前用户是老师” 为假，Q = “当前用户是行政管理人员” 为假
            // isTeacher = false;
            // isAdministrator = false;

            // 输出P 与 Q
            // 结果为 false
            // Console.WriteLine(isTeacher & isAdministrator);

            // 2. P = “当前用户是老师” 为假，Q = “当前用户是行政管理人员” 为真
            // isTeacher = false;
            // isAdministrator = true;

            // 输出P 与 Q 
            // 结果为 false
            // Console.WriteLine(isTeacher & isAdministrator);

            // 3. P = “当前用户是老师” 为真，Q = “当前用户是行政管理人员” 为假，P∧Q = 0为假
            // isTeacher = true;
            // isAdministrator = false;

            // 输出P 与 Q 
            // 结果为 false
            // Console.WriteLine(isTeacher & isAdministrator);

            // 4. P = “当前用户是老师” 为真，Q = “当前用户是行政管理人员” 为真，P∧Q = 1为真
            // isTeacher = true;
            // isAdministrator = true;

            // 输出P 与 Q
            // 结果为 true
            // Console.WriteLine(isTeacher & isAdministrator);
            // Console.ReadKey();

            // 编译器报语法错误
            // int number1 = (int)isTeacher;

            // 反过来也是，编译器报语法错误
            // bool isTeacher = (bool)1;

            // 如果一定要进行转换，只能通过Convert工具来完成：

            // bool isSomethingTrue = true;
            // int result1 = Convert.ToInt32(isSomethingTrue);
            // 转换结果为1
            // Console.WriteLine(result1);

            // bool result2 = Convert.ToBoolean(2);
            // 结果为 True（注意，result2 本身的值是true，它的文本形式，也就是ToString() 之后的样子是True）
            // Console.WriteLine(result2);

            // bool result3 = Convert.ToBoolean(-2);
            // 甚至是负数，结果也为 True
            // Console.WriteLine(result3);

            // bool result4 = Convert.ToBoolean(0);
            // 当且仅当是0时，结果才为 False
            // Console.WriteLine(result4);

            // Console.ReadKey();

            // 短路与
            // bool someResult = isTeacher && isAdministrator;

            // 按位与运算
            // Console.WriteLine(3 & 5);
            // Console.ReadKey();

            // 逻辑或运算
            // P = “当前用户是老师”
            // bool isTeacher;

            // Q = “当前用户是行政管理人员”
            // bool isAdministrator;

            // R = “当前账户被封禁”
            // bool isBanned;

            // 1. P(0) Q(0) R(0)
            // isTeacher = false;
            // isAdministrator = false;
            // isBanned = false;

            // 结果应该是0
            // Console.WriteLine($"P(0) 或者 Q(0) 或者 R(0): {isTeacher | isAdministrator | isBanned}");

            // 2. P(0) Q(0) R(1)
            // isTeacher = false;
            // isAdministrator = false;
            // isBanned = true;

            // 结果应该是1
            // Console.WriteLine($"P(0) 或者 Q(0) 或者 R(1): {isTeacher | isAdministrator | isBanned}");

            // 3. P(0) Q(1) R(0)
            // isTeacher = false;
            // isAdministrator = true;
            // isBanned = false;

            // 结果应该是1
            // Console.WriteLine($"P(0) 或者 Q(1) 或者 R(0): {isTeacher | isAdministrator | isBanned}");

            // 4. P(0) Q(1) R(1)
            // isTeacher = false;
            // isAdministrator = true;
            // isBanned = true;

            // 结果应该是1
            // Console.WriteLine($"P(0) 或者 Q(1) 或者 R(1): {isTeacher | isAdministrator | isBanned}");

            // 5. P(1) Q(0) R(0)
            // isTeacher = true;
            // isAdministrator = false;
            // isBanned = false;

            // 结果应该是1
            // Console.WriteLine($"P(1) 或者 Q(0) 或者 R(0): {isTeacher | isAdministrator | isBanned}");

            // 6. P(1) Q(0) R(1)
            // isTeacher = true;
            // isAdministrator = false;
            // isBanned = true;

            // 结果应该是1
            // Console.WriteLine($"P(1) 或者 Q(0) 或者 R(1): {isTeacher | isAdministrator | isBanned}");

            // 7. P(1) Q(1) R(0)
            // isTeacher = true;
            // isAdministrator = true;
            // isBanned = false;

            // 结果应该是1
            // Console.WriteLine($"P(1) 或者 Q(1) 或者 R(0): {isTeacher | isAdministrator | isBanned}");

            // 8. P(1) Q(1) R(1)
            // isTeacher = true;
            // isAdministrator = true;
            // isBanned = true;

            // 结果应该是1
            // Console.WriteLine($"P(1) 或者 Q(1) 或者 R(1): {isTeacher | isAdministrator | isBanned}");

            // 短路或：||
            // 按位或运算
            // Console.WriteLine(13 | 15);
            // Console.ReadKey();

            // 异或运算
            // P = “当前用户是老师”
            // bool isTeacher;
            // Q = “当前用户是行政管理人员”
            // bool isAdministrator;
            // R = “当前账户被封禁”
            // bool isBanned;

            // P(1)  Q(0)  R(1)
            // isTeacher = true;
            // isAdministrator = false;
            // isBanned = true;

            // P 异或 Q 异或 R
            // Console.WriteLine(isTeacher ^ isAdministrator ^ isBanned);
            // Console.ReadKey();

            // 布尔类型变量的命名规则
            // 有没有钱？
            // bool hasMoney = false;
            // 或者
            // 富不富？
            // bool isRich = false;

            // 再例如，P = “当前用户拥有老师操作权限”为真
            // bool canOperate = true;

            // 验证：通过德摩根定律展开后，前后两个逻辑算式是否等价
            // P = “当前用户是管理员”
            // bool isAdmin;
            // Q = “有操作权限”
            // bool canOperate;

            // P 且 Q
            // isAdmin = true;
            // canOperate = true;

            // 写isAdmin && canOperate
            // 或者也可以写 isAdmin & canOperate
            // 那么，无权限就应该是：!( isAdmin && canOperate)

            // P 且 Q的否定
            // 注意，这段代码表示无权限了
            // !isAdmin || !canOperate;

            // 在C#中，三横线等于符号，对应的是两个双横线等于号放一块
            // 这行代码判断上面那两个条件是否等价，注意每个式子都用括号括起来，避免运算顺序错误，得到错误结果
            // bool result = !(isAdmin && canOperate) == (!isAdmin || !canOperate);
            // Console.WriteLine(result);
            // Console.ReadKey();

            // 关系运算符
            // > < >= <= ==
            int myMathGrade = 98;
            int mathGradeOfXiaoming = 90;
            bool isMyGradeGreaterThanXiaomings = myMathGrade > mathGradeOfXiaoming;
            Console.WriteLine(isMyGradeGreaterThanXiaomings);
            Console.ReadKey();

            // 三元表达式
            string result = isMyGradeGreaterThanXiaomings ? "我分高" : "小明分高";
            // 还可以写为
            // myMathGrade > mathGradeOfXiaoming ? "我分高": "小明分高";

            Console.WriteLine(result);
            Console.ReadKey();

            // 在字符串内插中使用三元表达式
            Console.WriteLine($"{(myMathGrade > mathGradeOfXiaoming ? "我分高" : "小明分高")}");
        }
    }
}