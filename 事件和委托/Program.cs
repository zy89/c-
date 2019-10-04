using System;
/*
委托：就是持有一个或者多个方法的对象。并且该对象可以执行和传递
 */
namespace 事件和委托
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
            //委托
            public void WagTail(){
                Console.WriteLine(Name+" wag tail");
            }
        }
        public class Cat:Pet{
            public Cat(string name){
                Name=name;
            }
            public override void Speak(){
                Console.WriteLine(Name+" is speaking "+"meow meow");
            }
            //委托
            public void InnocentLook(){
                Console.WriteLine(Name+" innocent look");
            }
        }
    class Program
    {
        delegate void ActCute();//申明委托，用void，不传入参数
        static void Main(string[] args)
        {
            ActCute del = null;
            Dog dog = new Dog("A");
            Cat cat = new Cat("B");
            del = dog.WagTail;//后面不加括号。不是调用，是让委托对象持有方法
            del += cat.InnocentLook;//用+=继续添加

            del();//调用委托
        }
    }
}
