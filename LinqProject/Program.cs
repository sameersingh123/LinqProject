using System;
using System.Net.WebSockets;
using System.Linq;
namespace LinqProject
{
    class Program
    {
        static void Main()
        {
            int[] arr = {1,2,3,42,15,56,27,18,89,10};

            var brr= from i in arr where i>40 orderby i descending select i;
           
            foreach (int i in brr)
            {
                Console.Write(i + " ");
            }

            //int c = 0;
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > 40)
            //    {
            //        c++;
            //    }
            //}
            //int index = 0;
            //int[] brr = new int[c];
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > 40)
            //    {
            //        brr[index] = arr[i];
            //        index++;
            //    }

            //}
            //for (int i = 0; i < brr.Length; i++)
            //{
            //    Console.Write(brr[i] + " ");
            //}
        }
    }
}