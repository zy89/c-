using System;

namespace 类和对象
{
    class Child{//创建类, 静态特征用字段和属性。动态行为用方法
        public string _name;//public使得字段可以在其他类中访问
        public string _sex;
        public int _age;
        public int _height;

        public void PlayBall(){
            Console.WriteLine("Hi! I can play soccer");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Child xiaoming= new Child();//实例化Child类的对象
            xiaoming._name = "MaXiaoming";//给字段赋值
            xiaoming._sex = "male";
            xiaoming._age = 6;
            xiaoming._height = 120;
            Console.WriteLine("My name is "+xiaoming._name+", now I am "+xiaoming._age+" years old");
            xiaoming.PlayBall();//调用Child类里的方法
        }
    }
}
