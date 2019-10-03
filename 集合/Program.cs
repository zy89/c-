using System;
using System.Collections.Generic;//使用集合
/*
1. ArrayList:可以不指定大小；存取比数组慢；长度用Count访问
 */
namespace 集合
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
    class Program
    {
        static void Main(string[] args)
        {
            List<Dog> list= new List<Dog>();//定义一个ArrayList
            list.Add(new Dog("A"));//用Add去添加元素
            list.Add(new Dog("B"));
            list.Add(new Dog("C"));
            list.RemoveAt(1);//用Remove删除第二个元素
            for(int i =0;i<list.Count;++i){
                list[i].PrintName();
            }
        }
    }
}
