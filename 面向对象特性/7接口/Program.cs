using System;

namespace _7接口
{
    /*
    接口就是指定一组函数成员，而不实现他们的引用类型。
    接口只能用来被实现
     */
     interface ICatchMice{
         void CatchMice();//默认public。但是不能加任何访问修饰符，加public也算错
         //再一组
         //再一组
     }
     //不仅仅是猫才会爬树和抓老鼠
     interface IClimbTree{
         void ClimbTree();
     }

     //抽象Pet
     abstract public class Pet{
        public Pet(string name){
            _name=name;
        }
        protected string _name;
        public void PrintName(){
            Console.WriteLine("Pet's name is "+_name);
        }
        abstract public void Speak();//定义成虚方法，因为没有动物叫声会是一样的
    };
    //来个猫继承。如果有基类又有多个接口同时继承，基类要写最前
    public class Cat:Pet,ICatchMice,IClimbTree{
        public Cat(string name):base(name){}//交由基类初始化
        public override void Speak(){
            Console.WriteLine(_name+" is speaking "+"meow meow");
        }
        //实现接口
        public void CatchMice(){
            Console.WriteLine("Catch mice");
        }
        public void ClimbTree(){
            Console.WriteLine("Climb tree");
        }
    }
     
    class Program
    {
        static void Main(string[] args)
        {
            Cat c = new Cat("Tom2");
            IClimbTree climb = (IClimbTree)c;
            c.ClimbTree();
            climb.ClimbTree();
            ICatchMice catchM = (ICatchMice)c;
            c.CatchMice();
            catchM.CatchMice();
        }
    }
}
