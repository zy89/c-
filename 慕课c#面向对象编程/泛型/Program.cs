using System;
/*
1.为什么需要泛型：用基类或者公共的接口，甚至是所有类的基类object，也可以实现一个cage类。
但是类型太宽泛，需要显示转换类型，并且判断真实类型是什么。
2.优势：代码量小，无论多少种笼子，只需要一个实现。且纸游需要的类型才会被实例化。易于维护，修改模板就能改所有实例
 
3.泛型方法：方法的模型，可以实例化出具体方法。普通类中也可以有泛型方法

4.约束用来控制泛型，缩小泛型参数的范围
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
            //泛型方法
            public void isHappy<T>(T target) where T:Pet
            {
                //上面施加了一个宠物类型的约束
                Console.WriteLine("Happy:"+target.ToString());
                target.PrintName();
            }
        }
        //泛型接口：SitDogCmd重写了抽象类的方法
        public abstract class DogCmd{
            public abstract string GetCmd();
        }
        public class SitDogCmd:DogCmd{
            public override string GetCmd(){
                return "sit";
            }
        }
        public class SpeakDogCmd:DogCmd{
            public override string GetCmd(){
                return "wow";
            }
        }
        //定义一个泛型接口
        public interface IDogLearn<C> where C:DogCmd{
            void Act(C cmd);
        }
        public class Labrador:Dog, IDogLearn<SitDogCmd>, IDogLearn<SpeakDogCmd>
        {
            public Labrador(string name):base(name){
            }
            public void Act(SitDogCmd cmd){
                Console.WriteLine(cmd.GetCmd());
            }
            public void Act(SpeakDogCmd cmd){
                Console.WriteLine(cmd.GetCmd());
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
    class Person{}
    class Program
    {
        static void Main(string[] args)
        {
            Labrador dog= new Labrador("A");
            dog.Act(new SitDogCmd());//sit
            dog.Act(new SpeakDogCmd());//wow,想学什么只要更改泛型实参，让拉布拉多继承就可以了
            Console.WriteLine("你好");

            /* 
            var dog = new Dog("buding");
            dog.isHappy<Cat>(new Cat("Tom"));
            
            
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
            */
        }
    }
}
