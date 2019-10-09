using System;

namespace 排序
{
    class Program
    {
        //1.冒泡 n^2
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

        //2.插入 n^2
        public static int[] InsertSort(int[] array){
            for(int i=1;i<array.Length;i++){
                for(int j=i;j>0;j--){
                    if(array[j] <array[j-1]) {
                        int temp = array[j-1];
                        array[j-1] = array[j]; 
                        array[j] = temp;  
                    }
                }
            }
            return array;
        }
        static void Main(string[] args)
        {   
            int[] array = new int[]{2,5,1,4,3};
            /* 
            BubbleSort(array);
            InsertSort(array);
            */
            
            //输出数组
            for(int i =0;i<array.Length;i++){
                Console.Write(array[i]+" ");
            }
        }
    }
}
