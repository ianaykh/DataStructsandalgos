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

        public BTNode root = null;


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
            #region inorder  traverse entire left sub tree
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
        }

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


        #endregion

        #region Level order traversal 
        public void levelordertrav(BTNode root)
        {
            Queue<BTNode> q = new Queue<BTNode>();
            BTNode runner = root;
            q.Enqueue(root);


            while (q.Count > 0)
            {

                BTNode newnode = q.Peek();
                q.Dequeue();
                Console.WriteLine(newnode.data);
                if (newnode.left != null)
                {
                    q.Enqueue(newnode.left);
                }
                if (newnode.right != null)
                {
                    q.Enqueue(newnode.right);
                }




            }




        }
        #endregion



        #region recvursive depth
        public int FindDepth(BTNode r)
        {
            if (r == null)
            {
                return 0;
            }
            else
            {
                BTNode runner = r;
                int leftside = FindDepth(runner.left);
                int rightside = FindDepth(runner.right);
                int height = leftside > rightside ? leftside : rightside;

                return height + 1;
            }
        }
        #endregion

        #region iterative depth 
        public int finddepthiter(BTNode r)
        {
            Queue<BTNode> q = new Queue<BTNode>();
            BTNode runner = r;

            int height = 0;
            while (true)
            {
                q.Enqueue(r);
                int nodecount = q.Count;
                if (nodecount == 0)
                {
                    return height;
                }
                height++;
                while (nodecount > 0)
                {
                    BTNode newnode = q.Peek();
                    q.Dequeue();
                    if (newnode.left != null)
                    {
                        q.Enqueue(newnode.left);
                    }
                    if (newnode.right != null)
                    {
                        q.Enqueue(newnode.right);
                    }
                    nodecount--;
                }

            }


        }



        #endregion
    }
}
