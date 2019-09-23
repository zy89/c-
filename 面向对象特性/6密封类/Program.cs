using System;

namespace 密封类
{
    /*
    密封类：有些类不希望其他人听过继承来修改
    密封方法：不希望其他人重写该方法
     */

    abstract public class Pet{
        abstract public void Speak();
    }

    //dog继承pet
    public class Dog:Pet{
        //给狗的Speak加上sealed
         sealed override public void Speak(){
            Console.WriteLine("dog is speaking "+"wow wow");
        }
    }
    //拉布拉多继承dog
    public class Labrador:Dog{
        //这个重写就会报错了
        override public void Speak(){
            Console.WriteLine("labrador is speaking hihihi");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pet1 = new Labrador("lala1");
            Pet1.speak();
        }
    }
}
