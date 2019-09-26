using System;
/*
装箱：根据值类型的值，在堆上创建一个完整的引用类型对象，并返回对象的引用，是一种隐式转换
(值类型在栈当中)
装箱本质：就是在堆上创建了引用类型的副本，新创建的引用类型和原来的值类型相互独立
 */
namespace 装箱和拆箱
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=3;
            object oi=i;//装箱
            Console.WriteLine("i="+i+" oi="+oi.ToString());//都是3
            //现在变化一下值
            i=7;//栈
            oi=10;//存储在堆
            Console.WriteLine("i="+i+" oi="+oi.ToString());//分别是7和10，两个数相互独立
            //拆箱
            int j=(int)oi;
            Console.WriteLine("j="+j);//j=10
        }
    }
}
