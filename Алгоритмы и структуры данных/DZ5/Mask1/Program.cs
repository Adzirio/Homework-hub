using System;
using System.Collections.Generic;

namespace Mask1
{
    public class Node
    {
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public Node Parent { get; set; }
    }
    public class Tree
    {
        public Node Head { get; set; }
        public void AddNode(int value)
        {
            var newNode = new Node { Value = value };
            if(Head == null)
            {
                Head = newNode;
                return;
            }
            if (Head.Left == null)
            {
                Head.Left = newNode;
                Head.Left.Parent = Head;
                return;
            }
            if (Head.Right == null)
            {
                Head.Right = newNode;
                Head.Right.Parent = Head;
                return;
            }
            var node = Head;
            while (true)
            {
                if (node.Left == null)
                {
                    node.Left = newNode;
                    node.Left.Parent = node;
                    return;
                }
                if (node.Right == null)
                {
                    node.Right = newNode;
                    node.Right.Parent = node;
                    return;
                }
                int leftLink = CountLink(node.Left);
                int rightLink = CountLink(node.Right);
                if(leftLink > rightLink)
                {
                    node = node.Right;
                }
                else
                {
                    node = node.Left;
                }
            }
        }
        public int CountLink(Node node)
        {
            if(node.Left == null && node.Right == null)
            {
                return 1;
            }
            else if (node.Right == null)
            {
                return 2;
            }
            return CountLink(node.Left) + CountLink(node.Right)+1;
        }
        public void DFS(int value)
        {
            var stack = new Stack<Node>();
            stack.Push(Head);
            while (stack.Count != null)
            {
                var check = stack.Pop();
                Console.WriteLine(check.Value);
                if(check.Right != null)
                {
                    stack.Push(check.Right);
                }
                if(check.Left != null)
                {
                    stack.Push(check.Left);
                }
            }
            Console.WriteLine("Искомое значение не найденно.");
        }
        public void BFS(int value)
        {
            var queue = new Queue<Node>();
            queue.Enqueue(Head);
            while (queue != null)
            {
                var check = queue.Dequeue();
                Console.WriteLine(check.Value);
                if (check.Value == value)
                {
                    Console.WriteLine("Искомое значение: " + check.Value);
                    return;
                }
                if (check.Left != null)
                {
                    queue.Enqueue(check.Left);
                }
                if (check.Right != null)
                {
                    queue.Enqueue(check.Right);
                }
            }
            Console.WriteLine("Искомое значение не найденно.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var Test = new Tree();
            int count = 32;
            for(int i = 1; i < count; i++)
            {
                int value = (i * 2);
                Test.AddNode(value);
            }
            Test.DFS(62);
            Test.BFS(62);
        }
    }
}
