using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 2,34,56,7,8,33 };
            int[] arr = {8,7, 6, 5, 4, 3, 2, 1 };
            #region Selection sort 

            int min, temp;
            for (int i = 0; i < arr.Length -1; i++)
            {
                min = i;
                for (int j = i+1; j < arr.Length; j++)
                {
                    if(arr[min] > arr[j])
                    {
                        min = j;
                    }

                }
                temp = arr[min];
                arr[min] = arr[i];
                arr[i] = temp;

            }
            #endregion


            #region bubblesort




            #endregion




        }
    }
}
