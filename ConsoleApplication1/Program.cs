using System;
using System.Collections;
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
            int temp;
            //#region Selection sort 

            //int min;
            //for (int i = 0; i < arr.Length -1; i++)
            //{
            //    min = i;
            //    for (int j = i+1; j < arr.Length; j++)
            //    {
            //        if(arr[min] > arr[j])
            //        {
            //            min = j;
            //        }

            //    }
            //    temp = arr[min];
            //    arr[min] = arr[i];
            //    arr[i] = temp;

            //}
            //#endregion


            //#region bubblesort

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr.Length-i-1; j++)
            //    {
            //        if (arr[j] > arr[j + 1])
            //        {
            //            temp = arr[j];
            //            arr[j] = arr[j + 1];
            //            arr[j + 1] = temp;
            //        }
            //    }
            //}


            //#endregion

            //#region Insertionsort
            //int hole, val;
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    hole = i;
            //    val = arr[hole];
            //    while(hole>0 && arr[hole - 1] > val)
            //    {
            //        arr[hole] = arr[hole - 1];
            //        hole--;
            //    }
            //    arr[hole] = val;

            //}

            //#endregion

            #region Mergesort



            #endregion

            #region Quicksort                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     
            #endregion


            //#region right rotation
            //int[] newa = new int[arr.Length];
            //Console.WriteLine("Enter a rotation ");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (i + n < arr.Length)
            //    {
            //        newa[i + n] = arr[i];
            //    }
            //    else
            //    {
            //        newa[i + n - arr.Length] = arr[i];
            //    }
            //}

            //#endregion
            //#region right rotation 
            //int[] newa = new int[arr.Length];
            //Console.WriteLine("Enter a rotation ");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (i - n >= 0)
            //    {
            //        newa[i - n] = arr[i];
            //    }
            //    else
            //    {
            //        newa[(i - n) + arr.Length] = arr[i];
            //    }
            //}

            ////#endregion


            //string a = Console.ReadLine();
            //string b = Console.ReadLine();

            //a = a.ToLower();
            //b = b.ToLower();

            //Dictionary<char, int> alphacount = new Dictionary<char, int>();
            //Dictionary<char, int> alphacount2 = new Dictionary<char, int>();
            //for (char c = 'a'; c <= 'z'; c++)
            //{
            //    alphacount.Add(c, 0);
            //}


            //for(int i = 0; i < a.Length; i++)
            //{
            //    if (alphacount.ContainsKey(a[i]))
            //    {
            //        alphacount[a[i]] += 1;
            //    }
            //}
            //for (int i = 0; i < b.Length; i++)
            //{
            //    if (alphacount.ContainsKey(b[i]))
            //    {
            //        alphacount2[b[i]] += 1;
            //    }
            //}

            //int count = 0;

            //for(int i = 0; i < alphacount.Count; i++)
            //{
            //    if(alphacount != alphacount2)
            //    {
            //        if()
            //    }

            //}

            LinkedList L = new LinkedList();
            L.Addatstart(8);
            L.addatend(56);
            L.addatend(45);
            
            L.deletefromstart();
            L.deletefromend();
            L.displaylist();





        }
    }
}
