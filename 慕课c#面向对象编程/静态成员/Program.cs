using System;
/*
1.static静态成员将被类的所有实例共享，所有实例都访问同一内存位置;
2.单独存在堆当中；
3.静态成员直接通过类名访问，不用new一个实例 
 */
namespace 静态成员
{
    public class Pet{
        //初始化过程放在基类里
        public Pet(string name){
            _name=name;
        }
        protected string _name;
        public void PrintName(){
            Console.WriteLine("Pet's name is "+_name);
        }
        //虚方法
        virtual public void Speak(){
            Console.WriteLine(_name+" is speaking");
        }
    }

    public class Dog:Pet{
        static int Num;//静态成员
        //静态构造函数，不能有访问修饰符（public之类的）
        static Dog(){
            Num=0;//静态方法只能访问静态成员
        }

        //交由基类初始化
        public Dog(string name):base(name){
            ++Num;//每诞生一条狗，就num++
        }

        public override void Speak(){
            Console.WriteLine(_name+" is speaking "+"wow wow");
        }

        static public void ShowNum(){
            Console.WriteLine("Dog's number is "+Num);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog d1= new Dog("Jack");
            Dog d2= new Dog("Jack2");

            Dog.ShowNum();//通过类名直接调用,2条狗

        }
    }
}
