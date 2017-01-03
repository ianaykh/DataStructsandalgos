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
            int[] arr1 = { 2, 34, 56, 7, 8, 33 };
            int[] arr = { 8, 7, 6, 5, 4, 3, 2, 1 };
           
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


            #region bubblesort

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


            #endregion

            #region bubblesort sligtly optimized version 

            //Boolean isSorted = false;
            //int lastsorted = arr.Length - 1;
            //while (!isSorted)
            //{
            //    isSorted = true;
            //    for (int i = 0; i < lastsorted; i++)
            //    {
            //        if (arr[i] > arr[i + 1])
            //        {
            //            int tmp = arr[i];
            //            arr[i] = arr[i + 1];
            //            arr[i + 1] = tmp;
            //            isSorted = false;
            //        }

            //    }
            //    lastsorted--;

            //}



            #endregion

            #region Insertionsort
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

            #endregion

            #region Divide and conquer algos

            #region Mergesort  
            //int p = 0;
            //int q = arr.Length - 1;
            //mergesort(arr, p, q);


            #endregion

            #region Quicksort                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     
            #endregion

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
            //#region Linked list 
            //LinkedList L = new LinkedList();
            //L.Addatstart(8);
            //L.addatend(56);
            //L.addatend(45);

            //L.deletefromstart();
            //L.deletefromend();
            //L.displaylist();
            //#endregion


            #region Binary tree 
            #region depth of binary tree

            #endregion

            BinaryTree T = new BinaryTree();
            T.InsertNode(55);
            T.InsertNode(33);
            T.InsertNode(91);
            T.InsertNode(26);

            T.DisplayBTree();
            T.levelordertrav(T.root);
            Console.WriteLine(T.FindDepth(T.root));
            #endregion



            //char[] chararr = new char[26];

            //List<char> listchar = new List<char>(26);

            //string first = Console.ReadLine();
            //string second = Console.ReadLine();
            //int[] lettercounts = new int[26];
            //foreach (char c in first.ToCharArray())
            //{
            //    lettercounts[c - 'a']++;
            //}
            //foreach (char c in second.ToCharArray())
            //{
            //    lettercounts[c - 'a']--;
            //}
            //int result = 0;
            //foreach (int i in lettercounts)
            //{
            //    result += Math.Abs(i);
            //}
            #region stack brackets 
            //    List<string> result = new List<string>();
            //    int t = Convert.ToInt32(Console.ReadLine());
            //    for (int a0 = 0; a0 < t; a0++)
            //    {
            //        string s = Console.ReadLine();
            //        char[] chararr = s.ToCharArray();
            //        Stack<char> charstack = new Stack<char>();
            //        foreach (char c in chararr)
            //        {


            //            if (c == '{' || c == '(' || c == '[')
            //                {
            //                    charstack.Push(c);
            //                }

            //            else
            //            {
            //                if(charstack.Count == 0)
            //                {
            //                    break;
            //                }
            //                else
            //                if (c == '}' || c == ')' || c == ']')
            //                {
            //                    char topchar = charstack.Peek();

            //                    if(c=='}' && topchar=='{' || c==']' && topchar=='[' || c == ')' && topchar=='(')
            //                    {
            //                        charstack.Pop();
            //                    }
            //                }

            //            }


            //        }

            //        if (charstack.Count == 0) result.Add("YES"); else result.Add("NO");
            //    }

            //    foreach (var item in result)
            //    {
            //        Console.WriteLine(item);
            //    }

            //}
            #endregion
        }
        public static void mergesort(int[] arr, int p, int q)
        {
            if (p < q)
            {
                int mid = (p + q) / 2;
                mergesort(arr, p, mid);
                mergesort(arr, mid + 1, q);
               
            }
        }
       
    }
}
