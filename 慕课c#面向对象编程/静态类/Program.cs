using System;
/*
1.如果类只包含静态的方法和属性，并且标识为static，那就是静态类
2.静态类不能创建实例，不能被继承
3.可以为静态类定义一个静态构造函数
4.静态类主要用于基础类库和扩展方法：比如Math类
 */
namespace 静态类
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

    //静态类
    static class PetGuide{
        static public void HowToFeedDog(this Dog dog){
            Console.WriteLine("Play a video about how to feed a dog");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog d1= new Dog("Jack");
            Dog d2= new Dog("Jack2");

            Dog.ShowNum();//通过类名直接调用,2条狗

            Dog dog = new Dog("Tommy");
            dog.HowToFeedDog();//Dog里本身并没有这个方法，是通过静态类来引导，加this来扩展

        }
    }
}
