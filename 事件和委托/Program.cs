using System;
/*
1.委托：就是持有一个或者多个方法的对象。并且该对象可以执行和传递
2.事件：事件发生时，通知订阅者，就是调用订阅者的注册函数。注册，就是告诉发布者调用哪一个注册函数
事件可以理解成是一种封装的受限制的委托
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
            static int Num;
            public delegate void Handler();//定义一个委托类型
            public static event Handler NewDog;//在委托类型的基础上定义事件

            static Dog(){
               Num = 0;
            }

            public Dog(string name){
                Name=name;
                ++Num;
                //判断有没有订阅者,事件触发代码
                if(NewDog!=null){
                    NewDog();//触发事件
                }
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
        //定义一个客户
        class Client{
            public void WantADog(){
                Console.WriteLine("great, I want to see the new dog");
            }
        }
    class Program
    {
        delegate void ActCute();//申明委托，用void，不传入参数
        static void Main(string[] args)
        {   /* 
            ActCute del = null;
            Dog dog = new Dog("A");
            Cat cat = new Cat("B");
            del = dog.WagTail;//后面不加括号。不是调用，是让委托对象持有方法
            del += cat.InnocentLook;//用+=继续添加

            //Lambda表达式
            del +=()=>{
                Console.WriteLine("do nothing");
            };

            del();//调用委托
            */
            Client c1= new Client();
            Client c2= new Client();
            Dog.NewDog += c1.WantADog;//订阅事件
            Dog.NewDog += c2.WantADog;

            Dog dog = new Dog("Q");
        }
    }
}
