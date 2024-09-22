using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_C_
{
    internal class DArray
    {
        public void PrintArray(int[] arr)
        {
            int n=arr.Length;
            for (int i = 0; i < n; i++)
            { 
            Console.Write(arr[i]+" ");
            
            }
            Console.WriteLine();
        }
        //-------------------------Remove Even Numbers--------------------------------------------
      public  int[] RemoveEven(int[] arr) {
            int odd = 0;
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] % 2 != 0)
                {
                    odd++;
                }
            }
            int[] result=new int[odd];
            int idx = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] %2!=0)
                {
                    result[idx] = arr[i];
                    idx++;
                }
            }
            return result;
        }
        public void reverse_array(int[] arr, int start, int end) 
        {
            if (start<end )
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                end--;
                start++;
            }
        }
        public int findminmum(int[] arr)
        {
            int minmum = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < minmum)
                {
                    minmum = arr[i];
                }

            }
        return minmum;
        }
        public int thesecondmax(int[] arr)
        {
            int max=0;
            int secondmax=0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    secondmax = max;
                    max = arr[i];
                   
                }
                else if(arr[i] > secondmax && arr[i] != max)
                {
                   secondmax=arr[i];
                }
            }
                return secondmax;
       
        }
        public void movezeros(int[] arr)
        {
            int j = 0;
            for (int i = 0; i < arr.Length;i++)
            {
                if (arr[i] != 0 && arr[j] == 0) 
                {
                    int temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                }
                if (arr[j] != 0)
                {
                    j++;
                }
            }
        }
        public int[] resize_array(int[] arr,int capacity ) {
        
        int[]temp=new int[capacity];
            for (int i = 0;i < arr.Length;i++)
            {
                temp[i]=arr[i];
            }
        return temp;
        }
        //one dimension array 
        public void two_dimensiona_print(int[,] arr) { 
        for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine($"row {i+1}");
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j]+" " );
                }
                Console.WriteLine();
            }
        
        
        }
        public void three_dimensiona_print(int[,,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine($"row {i + 1}");
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for(int k = 0; k < arr.GetLength(2); k++)
                    {
                        Console.Write(arr[i, j,k] + " ");
                    }
                }
                Console.WriteLine();
            }


        }


    }
}
