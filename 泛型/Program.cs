using System;
/*
1.为什么需要泛型：用基类或者公共的接口，甚至是所有类的基类object，也可以实现一个cage类。
但是类型台宽泛，需要显示转换类型，并且判断真实类型是什么。
2.优势：代码量小，无论多少种笼子，只需要一个实现。且纸游需要的类型才会被实例化。易于维护，修改模板就能改所有实例
 */
namespace 泛型
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
    public class Cage<T>{
        //T只是形参
        T[] array;
        readonly int Size;
        int num;
        public Cage(int n){
            Size=n;
            num=0;
            array = new T[Size];
        }
        //放宠物
        public void Putin(T pet){
            if(num < Size){
                array[num++] = pet;
            }else{
                Console.WriteLine("cage is full");
            }
        }

        //取宠物
        public T TakeOut(){
            if(num>0){
                return array[--num];
            }else{
                Console.WriteLine("cage is empty");
                return default(T);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var dogCage = new Cage<Dog>(1);//定义一个size为1的笼子
            dogCage.Putin(new Dog("A"));//放入A狗
            dogCage.Putin(new Dog("B"));//放入B狗, 会输出cage is full

            var dog = dogCage.TakeOut();
            dog.PrintName();//是A

            //再来个猫的,很方便
            var catCage = new Cage<Cat>(1);
            catCage.Putin(new Cat("C"));
            catCage.Putin(new Cat("D"));

            var cat= catCage.TakeOut();
            cat.PrintName();
        }
    }
}
