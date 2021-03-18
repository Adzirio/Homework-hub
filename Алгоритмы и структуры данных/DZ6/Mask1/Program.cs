using System;
using System.Collections.Generic;

namespace Mask1
{
    public class Node
    {
        public string Name { get; set; }
        public List<Edge> Edges { get; set; }
    }
    public class Edge
    {
        public int Weight { get; set; }
        public Node Node { get; set; }
    }
    class Program
    {
        //         [B]----7----[E]          // Форма итоговой графы(связь в обе стороны).
        //        /           / | \         // Реализация Обходов DFS и BFS на стоках 150, 180 соответственно.
        //       3           4  |  9
        //      /           /   |   \
        //   [A]         [D]    2    [G]
        //      \       /   \   |
        //       2     1     3  |
        //        \   /       \ |
        //         [C]         [F]
        static void Main(string[] args)
        {
            var nodeA = new Node
            {
                Name = "A",
                Edges = new List<Edge>()
            };
            var nodeB = new Node
            {
                Name = "B",
                Edges = new List<Edge>()
            };
            var nodeC = new Node
            {
                Name = "C",
                Edges = new List<Edge>()
            };
            var nodeD = new Node
            {
                Name = "D",
                Edges = new List<Edge>()
            };
            var nodeE = new Node
            {
                Name = "E",
                Edges = new List<Edge>()
            };
            var nodeF = new Node
            {
                Name = "F",
                Edges = new List<Edge>()
            };
            var nodeG = new Node
            {
                Name = "G",
                Edges = new List<Edge>()
            };
            nodeA.Edges.Add(new Edge
            {
                Node = nodeB,
                Weight = 3
            }); //AB
            nodeA.Edges.Add(new Edge
            {
                Node = nodeC,
                Weight = 2
            }); //AC
            nodeB.Edges.Add(new Edge
            {
                Node = nodeA,
                Weight = 3
            }); //BA
            nodeB.Edges.Add(new Edge
            {
                Node = nodeE,
                Weight = 7
            }); //BE
            nodeC.Edges.Add(new Edge
            {
                Node = nodeA,
                Weight = 2
            }); //CA
            nodeC.Edges.Add(new Edge
            {
                Node = nodeD,
                Weight = 1
            }); //CD
            nodeD.Edges.Add(new Edge
            {
                Node = nodeC,
                Weight = 1
            }); //DC
            nodeD.Edges.Add(new Edge
            {
                Node = nodeE,
                Weight = 4
            }); //DE
            nodeD.Edges.Add(new Edge
            {
                Node = nodeF,
                Weight = 3
            }); //DF
            nodeE.Edges.Add(new Edge
            {
                Node = nodeB,
                Weight = 7
            }); //EB
            nodeE.Edges.Add(new Edge
            {
                Node = nodeD,
                Weight = 4
            }); //ED
            nodeE.Edges.Add(new Edge
            {
                Node = nodeF,
                Weight = 2
            }); //EF
            nodeE.Edges.Add(new Edge
            {
                Node = nodeG,
                Weight = 9
            }); //EG
            nodeF.Edges.Add(new Edge
            {
                Node = nodeD,
                Weight = 3
            }); //FD
            nodeF.Edges.Add(new Edge
            {
                Node = nodeE,
                Weight = 2
            }); //FE
            nodeG.Edges.Add(new Edge
            {
                Node = nodeE,
                Weight = 9
            }); //GE

            DFS(nodeA, "P");    // Начало нода A, Итог: A C D F E G B
            DFS(nodeD, "P");    // Начало нода D, Итог: D F E G B A C
            BFS(nodeA, "P");    // Начало нода A, Итог: A B C E D F G
            BFS(nodeD, "P");    // Начало нода D, Итог: D C E F A B G
        }
        public static void DFS(Node node, string name)
        {
            var stack = new Stack<Node>();
            var hashSet = new HashSet<Node>();
            stack.Push(node);
            hashSet.Add(node);
            while(stack != null)
            {
                var check = stack.Pop();
                Console.WriteLine(check.Name);
                if (check.Name == name)
                {
                    Console.WriteLine("Искомое значение: " + check.Name);
                    return;
                }
                foreach(Edge i in check.Edges)
                {
                    if (hashSet.Contains(i.Node) == false)
                    {
                        stack.Push(i.Node);
                        hashSet.Add(i.Node);
                    }
                }
            }
        }
        public static void BFS(Node node, string name)
        {
            var queue = new Queue<Node>();
            var hashSet = new HashSet<Node>();
            queue.Enqueue(node);
            hashSet.Add(node);
            while (queue != null)
            {
                if (queue.Count == 0)
                {
                    Console.WriteLine("Искомое значение не найденно.");
                    return;
                }
                var check = queue.Dequeue();
                Console.WriteLine(check.Name);
                if (check.Name == name)
                {
                    Console.WriteLine("Искомое значение: " + check.Name);
                    return;
                }
                foreach (Edge i in check.Edges)
                {
                    if (hashSet.Contains(i.Node) == false)
                    {
                        queue.Enqueue(i.Node);
                        hashSet.Add(i.Node);
                    }
                }
            }
        }
    }
}
