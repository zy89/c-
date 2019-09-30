using System;
/*
1.重载运算符：利用现有的某种运算符，针对自定义类或者结构，定义某种运算操作
2.为什么需要：简化自定义类型的操作
 */
namespace 重载运算符
{
    public class Pet{
        public Pet(string name){
            Name=name;
            age=0;
        }
        public string Name;
        protected int age;

        public void ShowAge(){
            Console.WriteLine(Name+" Age= "+age);
        }
        //重载运算符
        public static Pet operator ++(Pet pet){
            ++pet.age;
            return pet;
        }
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
           Pet dog = new Dog("Jack");
           Pet cat = new Cat("Tom");
           Pet dog2 = new Dog("Jacky");

           dog.ShowAge();
           cat.ShowAge();
           dog2.ShowAge();
           
        }
    }
}
