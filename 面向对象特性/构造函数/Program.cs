using System;
/*
派生类及构造函数调用顺序：1.子类实例化 2.父类构造函数 3.子类构造函数
 */
namespace 构造函数
{public class Pet{
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
            //通过数组储存,几千宠物的时候方便很多
            Pet[] pets = new Pet[] {new Dog("Jack"),new Cat("Tom")};

            for(int i =0;i<pets.Length;++i){
                pets[i].Speak();
            }
        }
    }
}
