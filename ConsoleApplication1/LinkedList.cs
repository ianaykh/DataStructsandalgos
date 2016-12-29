using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class LinkedList
    {
        public Node head;
        public int count;
        public Node current;


        public LinkedList()
        {
            head = null;
           
         
        }

        public void Addatstart(int d)
        {
            Node newnode = new Node();
            newnode.data = d;
            if (head == null)
            {
                head = newnode;
                current = newnode;
                current.next = null;
            }
            else
            {
                newnode.next = head;
                head = current = newnode;
            }
        }


        public void addatend(int d)
        {
            Node runner = head;
            Node newnode = new Node();
            newnode.data = d;
            if (head == null)
            {
                head = newnode;
                current = newnode;
                current.next = null;
            }
            else
            {
                
                    while (runner.next != null)
                    {
                        
                        runner = runner.next;
                    }

                runner.next = newnode;

               
            }
        }

        public void displaylist()
        {
            Node runner = head;
            if (runner != null)
            {
                while (runner != null)
                {
                    Console.WriteLine(runner.data);
                    runner = runner.next;
                }
            }
            else
            {
                Console.WriteLine("List is empty");
            }
          
        }

        public void deletefromstart()
        {
            Node runner = head;
            if(runner == null)
            {
                Console.WriteLine("Nothing to delete");
            }
            else
            {
                if (head.next != null)
                {
                    head = head.next;
                }
                else
                {
                    head = null;
                }
            }
        }
        public void deletefromend()
        {
            Node runner, prev = null;
            runner = head;
            while (runner.next != null)
            {
                prev = runner;
                runner = runner.next;
            }
            prev.next = null; 
        }

    }
}
