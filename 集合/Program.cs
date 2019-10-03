using System;
using System.Collections.Generic;//使用集合
/*
1. ArrayList:可以不指定大小；存取比数组慢；长度用Count访问
2. Dictionary：储存是一系列的键值对，一一对应。可以通过键高效访问到值
3. 栈stack：先进后出
4. 队列queue：先进先出
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

            //字典
            Dictionary<string,Dog> dic= new Dictionary<string, Dog>();
            dic.Add("A", new Dog("AA"));//A是键,AA是值
            dic.Add("B", new Dog("BB"));
            dic.Add("C", new Dog("CC"));

            dic["A"].PrintName();//通过键高效访问A的值

            //栈stack
            Stack<Dog> s = new Stack<Dog>();
            s.Push(new Dog("A"));//Push用来入栈
            s.Push(new Dog("B"));
            s.Peek().PrintName();//Peek查看栈顶元素，不会拿出
            s.Pop();//出栈,B移除
            s.Peek().PrintName();

            //队列queue
            Queue<Dog> q= new Queue<Dog>();
            q.Enqueue(new Dog("A"));//Enqueue入队
            q.Enqueue(new Dog("B"));
            q.Enqueue(new Dog("C"));

            Dog a=null;
            a=q.Dequeue();//Dequeue出队，有返回值
            a.PrintName();//A先进先出
        }
    }
}
