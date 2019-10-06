using System;
/*
1.有参和无参方法
2.方法重载，同一个类里有多个名字相同的方法。但是参数不同
3.return可以结束方法的调用，并带返回值
 */
namespace 方法
{
    class Child{
        public string _name;
        public string _sex;
        public int _age;
        public int _height;

        public void PlayBall(){//无参方法
            if(_age>4){
                Console.WriteLine("Hi! I can play soccer");
                return;//结束方法的调用
            }
            Console.WriteLine("u r too young");
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

        public void EatSugar(string sugar, int count){//多形参
            if(sugar=="milk" && count >2){
                Console.WriteLine("u cannot eat milk more than two");
            }else if(count >3){
                Console.WriteLine("u eat too much");
            }else{
                Console.WriteLine("u can eat it");
            }
        }

        public int Add(int n1, int n2){//void是没有返回值，有返回值的话需要根据返回值类型给上int
            int sum=n1+n2;
            return sum;//返回方法的结果
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child();//要先实例化才能调用类里的方法
            int sum;
            sum=child.Add(3,7);
            Console.WriteLine(sum);
            /* 
            hild._agce=4;
            child.PlayBall();//会输出 u r too young
            child.EatSugar("durian");
            child.EatSugar(4);//会自动匹配参数相同的方法
            child.EatSugar("milk",5);
            */
        }
    }
}
