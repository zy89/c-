using System;

namespace 接收输入
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            string name;
            Console.Write("plz type ur name: ");
            name=Console.ReadLine();
            Console.WriteLine("Hi "+name);
            */

            string[] arr_name=new string[2];
            int[] score=new int[2];
            for(int i=0;i<arr_name.Length;i++){
                Console.Write("plz type No"+(i+1)+"of Student's name ");
                arr_name[i]=Console.ReadLine();
                Console.Write("plz type No"+(i+1)+"of Student's score ");
                score[i]=int.Parse(Console.ReadLine());
            }
            int sum=0;
            int avg;
            for(int i=0;i<score.Length;i++){
                sum+=score[i];
            }
            avg=sum/score.Length;
            Console.WriteLine("total scores are: "+sum+" and avg is: "+avg);
        }
    }
}
