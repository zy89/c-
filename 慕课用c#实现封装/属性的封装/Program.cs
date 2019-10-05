using System;
/*
1.封装用来隐藏对象的信息，同时留出访问的接口
2.把字段封装成属性
 */
namespace 属性的封装
{
    class Child{
        private string _name;
        public string Name{//通过Name属性来封装
            get {return _name;}//读访问器
            set {_name = value;}//写访问器，value是关键字，代表给字段赋的值
        }
        private string _sex;
        public string Sex{
            get{return _sex;}
            set{_sex=value;}//不要set的话，字段只能读不能赋值
        }
        private int _age;
        public int Age{
            get{return _age;}
            set{
                if(value>=3 && value<=7){//给age的value增加条件
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
    }

    class Program
    {
        static void Main(string[] args)
        {
            Child xiaoming = new Child();
            xiaoming.Name = "MaXiaoming";//访问方法一样
            xiaoming.Sex = "male";
            xiaoming.Age = 6;
            xiaoming.Age=70;//不符合条件的赋值
            Console.WriteLine("I am "+xiaoming.Age+" years old");//仍然是6
            xiaoming.Height = 120;
            
        }
    }
}
