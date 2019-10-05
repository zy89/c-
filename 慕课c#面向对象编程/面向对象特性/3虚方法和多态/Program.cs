using System;
/*
1.虚方法：声明为virtual的方法就是虚方法。基类的虚方法可以在派生类中使用override进行重写。
2.多态：通过指向子类的父类引用，调用虚函数，会根据引用所指向的子类的实际类型，调用子类中的
同名重写函数。
3.基类方法不能是private
4.不能重写static方法或者非虚方法
5.方法，属性，索引器，事件都可以为virtual或者override

 */
namespace 虚方法和多态
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
    }
    public class Cat:Pet{
        public Cat(string name){
            Name=name;
        }
        public override void Speak(){
            Console.WriteLine(Name+" is speaking "+"meow meow");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {   
            //通过数组储存,几千宠物的时候方便很多
            Pet[] pets = new Pet[] {new Dog("Jack"),new Cat("Tom")};

            for(int i =0;i<pets.Length;++i){
                pets[i].Speak();
            }
        }
    }
}
