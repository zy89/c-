using System;

namespace 抽象方法和抽象类
{
    //abstract方法里不可以有函数体。只可以在子类中用override进行重写
    //virtual方法可以有函数体
    abstract class A{};//抽象一个，{}里不能有内容
    //A x=new A();会报错，抽象类没有函数体，不能实例化

    //现在来抽象一个宠物
    abstract public class Pet{
        public Pet(string name){
            _name=name;
        }
        protected string _name;
        public void PrintName(){
            Console.WriteLine("Pet's name is "+_name);
        }
        abstract public void Speak();//定义成虚方法，因为没有动物叫声会是一样的
    };

    //猫狗继承
    public class Dog:Pet{
        public Dog(string name):base(name){}//交由基类初始化
        public override void Speak(){
            Console.WriteLine(_name+" is speaking "+"wow wow");
        }
    }
    public class Cat:Pet{
        public Cat(string name):base(name){}//交由基类初始化
        public override void Speak(){
            Console.WriteLine(_name+" is speaking "+"meow meow");
        }
    }


    class Program
    {
        
        static void Main(string[] args)
        {
            Pet[] pets = new Pet[] {new Dog("Jack"),new Cat("Tom")};

            for(int i =0;i<pets.Length;++i){
                pets[i].Speak();
            }
        }
    }
}
