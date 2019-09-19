using System;

namespace 继承
{
         /*1.继承用法
        class ChildClass:ParentClass{
            //do sth.
        }
        2.Object类是所有类的根
        3.继承规则：单继承，只能继承于一个父类。父类又可以继承于祖父类
         */
        
         //定义一个宠物类
         public class Pet{
             public string Name;
             public void PrintName(){
                 Console.WriteLine("Pet's name is "+Name);
             }
         }
         //狗狗继承于Pet
         public class Dog:Pet{
             //屏蔽方法用new关键字
             new public void PrintName(){
                 Console.WriteLine("new method of dog name is "+Name);
             }
         }
         public class Cat:Pet{}

    class Program
    {
        static void Main(string[] args)
        {
            Dog dog=new Dog();//实例化一只狗
            dog.Name="Jack";
            dog.PrintName();
            Cat cat=new Cat();//实例化一只猫
            cat.Name="Tom";
            cat.PrintName();//调用print方法
        }
    }
}
