using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Graph
    {
        private List<Vertex> listofvertices;
        private int[,] adjmatrix;
        private int noofvertices;

        public Graph(int nov)
        {

            adjmatrix = new int[nov,nov];
            noofvertices = 0;
            listofvertices = new List<Vertex>(nov);
            // Initialise the adjecent matrix to null
            for (int i = 0; i < adjmatrix.Length; i++)
            {
                for (int j = 0; j < adjmatrix.Length; j++)
                {
                    adjmatrix[i, j] = 0;
                }
            }
        }

        public void AddVertex(int d)
        {
            noofvertices++;
            listofvertices.Add(new Vertex(d));
        }

        public void AddEdge(int startnumber,int endnumber)
        {
            adjmatrix[startnumber, endnumber] = 1;
            adjmatrix[endnumber, startnumber] = 1;
        }

        public void DisplayVertex(int v)
        {
            Vertex V = new Vertex(v);

            Console.WriteLine(listofvertices.Find(x => x.data == v)); 
            
        }

        public void getAdjUnvisitedVertex(int v)
        {
            for (int k = 0; k < ; ++)
            {

            }
        }



    }
}
