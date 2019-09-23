using System;

namespace _7接口
{
    /*
    接口就是指定一组函数成员，而不实现他们的引用类型。
    接口只能用来被实现
     */
     interface ICatchMice{
         void CatchMice();//默认public。但是不能加任何访问修饰符，加public也算错
         //再一组
         //再一组
     }

     //
     Cat:ICatchMice{
         public void CatchMice(){
             
         }
     }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
