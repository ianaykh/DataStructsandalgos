using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class BinaryTree
    {

        BTNode root = null;


        public void InsertNode(int d)
        {
            BTNode newnode = new BTNode();
            BTNode runner = root;
            if(root == null)
            {
                newnode.data = d;
                root = newnode;
            }
            else
            {
                #region recursive approach
                if (runner.left == null)
                {
                   inse
                }
                #endregion

            }
        }

    }
}
