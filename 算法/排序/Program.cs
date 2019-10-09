using System;

namespace 排序
{
    class Program
    {
        //1.冒泡
        public static int[] BubbleSort(int[] array){
            int temp;
            for(int i=0; i<array.Length-1;i++){
                for(int j=i+1;j<array.Length;j++){
                    if(array[i] > array[j]){
                        temp=array[i];
                        array[i]=array[j];
                        array[j]=temp;;
                    }
                }
            }
            return array;
        }
        static void Main(string[] args)
        {   
            int[] array = new int[]{2,5,1,4,3};
            BubbleSort(array);
            //输出数组
            for(int i =0;i<array.Length;i++){
                Console.Write(array[i]+" ");
            }
        }
    }
}
