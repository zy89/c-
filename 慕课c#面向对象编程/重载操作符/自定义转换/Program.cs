using System;

namespace 自定义转换
{
    public class Pet{
        public string Name;
        public void PrintName(){
            Console.WriteLine("Pet's name is "+Name);
        }
        //虚方法
        virtual public void Speak(){
            Console.WriteLine(Name+" is speaking");
        }
    }
        public class Dog:Pet{
        public Dog(string name){
            Name=name;
        }
        public override void Speak(){
            Console.WriteLine(Name+" is speaking "+"wow wow");
        }
        public static implicit operator Cat(Dog dog){
            return new Cat(dog.Name);
        }
    }

    public class Cat:Pet{
        public Cat(string name){
            Name=name;
        }
        public override void Speak(){
            Console.WriteLine(Name+" is speaking "+"meow meow");
        }
        //显式转换
        public static explicit operator Dog(Cat cat){
            return new Dog(cat.Name);
        }
    }

    //静态类
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog= new Dog("Jack");
            dog.Speak();
            Cat cat=dog;//隐式转换
            cat.Speak();//Jack is speaking meow meow.狗转换成猫
            cat.PrintName();//Pet's name is Jack

            Dog dog2=(Dog)cat;//显式，强制
            dog2.Speak();

        }
    }
}
