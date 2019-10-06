using System;
/*
1.有参和无参方法
2.方法重载，同一个类里有多个名字相同的方法。但是参数不同
 */
namespace 方法
{
    class Child{
        public string _name;
        public string _sex;
        public int _age;
        public int _height;

        public void PlayBall(){//无参方法
            Console.WriteLine("Hi! I can play soccer");
        }
        public void EatSugar(string sugar){//有参
            if(sugar=="durian"){
                Console.WriteLine("I dont like durian flavor");
            }else{
                Console.WriteLine("Yes, I love it");
            }
        }
        public void EatSugar(int count){//方法的重载
            if(count>3){
                Console.WriteLine("u eat too much");
            }else{
                Console.WriteLine("u can keep eating");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child();//要先实例化才能调用类里的方法
            child.PlayBall();
            child.EatSugar("durian");
        }
    }
}
