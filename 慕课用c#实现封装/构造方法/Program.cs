using System;
/*
1.构造方法的作用：为对象的属性赋值
2.如果没有显示定义的构造方法，则会有一个默认的无参数的构造方法
3.如果显示定义了构造方法，则没有
3.构造方法的调用时new 方法名();通常声明为public，不能有void也没有返回值类型
4.构造方法名必须与类名相同
 */
namespace 构造方法
{
    class Child{
        private string _name;
        public string Name{
            get {return _name;}
            set {_name = value;}
        }
        private string _sex;
        public string Sex{
            get{return _sex;}
            set{_sex=value;}
        }
        private int _age;
        public int Age{
            get{return _age;}
            set{
                if(value>=3 && value<=7){
                    _age=value;
                    }              
                }
        }
        private int _height;
        public int Height{
            get{return _height;}
            set{_height=value;}
        }

        public void PlayBall(){
            Console.WriteLine("Hi! I can play soccer");
        }

        public Child(){//无参构造方法
            Name = "JayChou";
        }
        public Child(string name, string sex, int age){//有参构造方法。会重写上一个Child,调用没问题
            Name=name;
            Age=age;
            Sex=sex;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Child child = new Child();//调用构造方法,无参。赋值麻烦
            Child child = new Child("JJ","male",27);//调用有参构造方法，直接传入参数。节约代码量


            Console.WriteLine("My name is {0}", child.Name);//Name是在类里完成赋值
            Console.WriteLine("My gender is {0}", child.Sex);
            Console.WriteLine("My age is {0}", child.Age);
        }
    }
}
