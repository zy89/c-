using System;
//创建新项目：dotnet new console
//运行新项目：dotnet run
namespace 二维数组
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr=new int[2,3];//二维数组：2个数组，每个包含3个标量
            //分别是[0,0] [0,1] [0,2] [1,0] [1,1] [1.2]
            arr[1,0]=28;//直接赋值
            Console.WriteLine(arr[1,0]);

            //同学考两科目成绩例子：
            int[,] score = new int[4,2] {{89,86},{69,40},{64,92},{82,100}};
            Console.WriteLine("同学们分数是：");
            for(int i=0;i < score.GetLongLength(0);i++){
                Console.WriteLine("语文：{0}, 数学：{1}",score[i,0],score[i,1]);
            }
        }
    }
}
