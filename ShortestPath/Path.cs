using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPath
{
    public class Path
    {
         
    }

    class Graph
    {
        public List<Vertex> Vertices;
        public List<Edge> Edges;
    }

    class Vertex
    {
        public int Id;
    }

    class Edge
    {
        public Vertex v1;
        public Vertex v2;
        public int Weight;
    }
}
