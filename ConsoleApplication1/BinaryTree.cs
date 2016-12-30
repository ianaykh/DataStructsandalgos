using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class BinaryTree
    {

        BTNode root = null;


        public void find(int d)
        {
            BTNode runner = root;
            while (runner != null)
            {
                if (d == runner.data)
                {
                    Console.WriteLine("Found");
                }
                if (d > runner.data)
                {
                    runner = runner.right;
                }
                else
                {
                    runner = runner.left;
                }
            }
        }

        public void InsertNode(int d)
        {
            BTNode newnode = new BTNode();
            BTNode runner = root;
            newnode.data = d;
            if (root == null)
            {

                root = newnode;
            }
            else
            {
                #region 
                while (true)
                {

                    if (d < runner.data)
                    {
                        
                        if (runner.left == null)
                        {
                            runner.left = newnode;
                            return;
                        }
                        else
                        {
                            runner = runner.left;
                        }
                       
                    }
                    else
                    {
                        if (runner.right == null)
                        {
                            runner.right = newnode;
                            return;
                        }
                        else
                        {
                            runner = runner.right;
                        }
                     
                    }
                }

                #endregion

            }
        }


        public void DisplayBTree()
        {
            Stack<BTNode> S = new Stack<BTNode>();
            BTNode runner = root;
            if (runner == null)
            {
                return;
            }
            #region inorder
            // traverse entire left sub tree
            //while (runner != null)
            //{
            //    S.Push(runner);
            //    runner = runner.left;
            //}
            ////Stop when left is null check if right node exists, go to it and traverse its left side. If both left and right and enpty pop and check the root
            //while (S.Count > 0)
            //{
            //     runner = S.Pop();
            //    Console.WriteLine(runner.data);
            //    if (runner.right != null)
            //    {
            //        runner = runner.right;
            //        while (runner != null)
            //        {
            //            S.Push(runner);
            //            runner = runner.left;

            //        }

            //    }
            //}
            #endregion

            #region preorder
            // push the root into the stack 
            //S.Push(runner);

            //while (S.Count > 0)
            //{   //pop the lement from the stack 
            //    runner = S.Peek();
            //    Console.WriteLine(runner.data);
            //    S.Pop();
            //    //first push right element into the stack then push the left element
            //    if (runner.right != null)
            //    {

            //        S.Push(runner.right);
            //    }
            //    if (runner.left != null)
            //    {

            //        S.Push(runner.left);
            //    }

            //}

            #endregion

            #region postorder
            while (runner != null)
            {
                S.Push(runner);
                runner = runner.left;
            }
            //Stop when left is null check if right node exists, go to it and traverse its left side. If both left and right and enpty pop and check the root
            while (S.Count > 0)
            {
                runner = S.Pop();
                Console.WriteLine(runner.data);
                if (runner.right != null)
                {
                    runner = runner.right;
                    while (runner != null)
                    {
                        S.Push(runner);
                        runner = runner.left;

                    }

                }
            }


            #endregion

        }

    }
}
