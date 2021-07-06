using System;
using System.Collections;
using System.Collections.Generic;

namespace Task01
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
        int GetCount(); // возвращает количество элементов в списке
        void AddNode(int value);  // добавляет новый элемент списка
        void AddNodeAfter(Node node, int value); // добавляет новый элемент списка после определённого элемента
        void RemoveNode(int index); // удаляет элемент по порядковому номеру
        void RemoveNode(Node node); // удаляет указанный элемент
        Node FindNode(int searchValue); // ищет элемент по его значению
    }

    class TestNode : ILinkedList
    {
        Node First;
        Node Last;
        int count;

        public void AddNode(int value)
        {
            Node node = new Node();
            node.Value = value;
            if (First == null)
            {
                First = node;
            }
            else
            {
                Last.NextNode = node;
                node.PrevNode = Last;
            }

            Last = node;
            count++;
            GetCount();


        }

        public void AddNodeAfter(Node node, int value)

        {

            Node afternode = new Node();
            Node tempnode = new Node();

            afternode.Value = value;
            if (First == null)
            {
                First = afternode;
            }
            else
            {

                node.NextNode = afternode;
                afternode.PrevNode = node;
                afternode.NextNode = tempnode;
                tempnode.PrevNode = afternode;


                count++;

            }
            GetCount();

        }



        public Node FindNode(int searchValue)
        {

            Node srcnode = new Node();
            srcnode.Value = First.Value;
            while (srcnode.Value != searchValue)
            {
                srcnode = srcnode.NextNode;
            }
            return srcnode;

        }

        public int GetCount()
        {
            return count;
        }

        public void RemoveNode(int index)
        {
            Node temp = new Node();
            if (index == 1)
            {
                if (First == null)
                {
                    throw new InvalidOperationException();
                }
                else
                {

                    if (First.NextNode != null)
                    {
                        First.NextNode.PrevNode = null;
                    }
                    First = First.NextNode;
                    count--;
                    GetCount();
                }
            }
            else
            {
                if (Last == null)
                {
                    throw new InvalidOperationException();
                }
                else
                {
                    int i = 0;
                    temp = First;
                    while (i < index)
                    {
                        temp = temp.NextNode;
                        i++;
                    }

                    if (temp.PrevNode != null)
                    {
                        temp.PrevNode.NextNode = temp.NextNode;
                        temp.NextNode.PrevNode = temp.PrevNode;

                    }

                    count--;
                    GetCount();
                }
            }

        }

        public void RemoveNode(Node node)
        {
            Node remnode = new Node();
            remnode = First;
            while (remnode != node)
            {
                remnode = remnode.NextNode;
            }
            remnode.PrevNode.NextNode = remnode.NextNode;
            remnode.NextNode.PrevNode = remnode.PrevNode;
            count--;
            GetCount();

        }
    }


class Program
    {
        static void Main(string[] args)
        {
            
            
        }
    }
}
