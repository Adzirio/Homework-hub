 using System;

namespace Mask1
{
    public class Node
    {
        public int Value { get; set; }
        public Node NextNode { get; set; }
        public Node PrevNode { get; set; }
    }
    //Начальную и конечную ноду нужно хранить в самой реализации интерфейса
    public interface ILinkedList
    {
        Node Head { get; set; }
        Node Tail { get; set; }
        int GetCount(); // возвращает количество элементов в списке
        void AddNode(int value);   // добавляет новый элемент списка
        void AddNodeAfter(Node node, int value); // добавляет новый элемент списка после определённого элемента
        void RemoveNode(int index); // удаляет элемент по порядковому номеру
        void RemoveNode(Node node);  // удаляет указанный элемент
        Node FindNode(int searchValue); // ищет элемент по его значению
    }
    public class myList : ILinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public int GetCount() 
        {
            int count = 0;
            if (Head == null)
            {
                return count;
            }
            if (Tail == null)
            {
                return count++;
            }
            var curentNote = Head;
            while (curentNote != null)
            {
                count++;
                curentNote = curentNote.NextNode;
            }
            return count;
        }
        public void AddNode(int value)
        {
            var newNode = new Node { Value = value };
            if (Head == null)
            {
                Head = newNode;

                return;
            }
            else if (Tail == null)
            {
                Tail = newNode;
                Head.NextNode = Tail;
                Tail.PrevNode = Head;
                return;
            }
            var lastNode = Tail;
            Tail = newNode;
            Tail.PrevNode = lastNode;
            lastNode.NextNode = Tail;
        }
        public void AddNodeAfter(Node node, int value)
        {
            var newNode = new Node { Value = value };
            var nextNode = node.NextNode;
            node.NextNode = newNode;
            newNode.PrevNode = node;
            newNode.NextNode = nextNode;
            if (nextNode == null)
            {
                return;
            }
            nextNode.PrevNode = newNode;
        }
        public void RemoveNode(int index)
        {
            var curentNote = Head;
            int lenght = GetCount();
            if (lenght >= index)
            {
                if (lenght == index)
                {
                    if (Head.NextNode == null)
                    {
                        Head = null;
                        return;
                    }
                    if (index == 2)
                    {
                        Tail = null;
                        return;
                    }
                    RemoveNode(Tail);
                    Tail = Tail.PrevNode;
                    return;
                }
                if (index == 1)
                {
                    RemoveNode(Head);
                    Head = Head.NextNode;
                    return;
                }
                for (int i = 1; i < index; i++)
                {
                    curentNote = curentNote.NextNode;
                }
                RemoveNode(curentNote);
            }
        } 
        public void RemoveNode(Node node)
        {
            var nextNode = node.NextNode;
            var prevNode = node.PrevNode;
            if (nextNode == null)
            {
                prevNode.NextNode = nextNode;
                return;
            }
            else if (prevNode == null)
            {
                nextNode.PrevNode = prevNode;
                return;
            }
            prevNode.NextNode = nextNode;
            nextNode.PrevNode = prevNode;
        }
        public Node FindNode(int searchValue) 
        {
            var currentNode = Head;
            while (currentNode != null)
            {
                if (currentNode.Value == searchValue)
                {
                    return currentNode;
                }
                currentNode = currentNode.NextNode;
            }
            return null;
        }
        public int[] MasiveList() // перевод списка в массив.
        {
            int lenght = GetCount();
            if (lenght == 0)
            {
                return null;
            }
            int[] masive = new int[lenght];
            if (lenght <= 2)
            {
                masive[0] = Head.Value;
                if (lenght == 1) { return masive; }
                masive[1] = Tail.Value;
                return masive;
            }
            var nodeList = Head;
            for (int i = 0; i < lenght; i++)
            {
                masive[i] = nodeList.Value;
                nodeList = nodeList.NextNode;
            }
            return masive;
        }
        public int BinarySearch(int value) //бинарный поиск.
        {
            int[] List = MasiveList();
            int min = 0;
            int max = (List.Length - 1);
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (value == List[mid])
                {
                    return ++mid;
                }
                else if (value < List[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            var List = new myList();
            int[] array = new int[] {2, 4, 8, 12, 14, 20, 30, 44, 66, 90 };
            for (int i = 0; i < array.Length; i++) 
            {
                List.AddNode(array[i]);
            }

            List.RemoveNode(10); // удаляется 10 элемент который является замыкающим и равняется 90. 
            List.RemoveNode(1); // удаляем начальный элемент который равняется 2.
            List.RemoveNode(5); // удаляем 5 элемент которым на данный момент является 20.
            List.AddNodeAfter(List.FindNode(30), 37);

            Console.WriteLine($"{List.GetCount()}, {List.Head.Value}, {List.Tail.Value}."); // проверяем общее кол-во, первый и последний ноды (8, 4, 66)

            int[] Test = List.MasiveList(); // в классе MyList создан метод преобразования списка в массив "MasiveList()" для удобства(в моем понимании.).
            for (int i = 0; i < Test.Length; i++)
            {
                if (i == (Test.Length-1))
                {
                    Console.WriteLine(Test[i] + ".");
                }
                else
                {
                    Console.Write(Test[i] + ", ");
                }
            }  // выводим список для проверки (4, 8, 12, 14, 30, 37, 44, 66)

            // проверка бинарного поиска.
            int Test1 = List.BinarySearch(14); // 4.
            int Test2 = List.BinarySearch(90); // -1.
            Console.WriteLine($"{Test1}, {Test2}.");
        }
    }
}
