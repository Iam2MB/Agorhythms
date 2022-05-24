using System;
using System.Collections.Generic;

namespace HomeWork
{
    internal class lesson2_1
    {
        public static void DoublyLinkedList()
        {
            //DoublyLinkedList<string> linkedList = new DoublyLinkedList<string>() { "Tom", "Bob", "Sam" };
            Console.WriteLine("Проверте код пожалуйста\nсоответствии с интерфейсом вроде как проработал\nа вот как заполнять список не разобрался");
        }
    }
    public class Node
    {
        public int Value { get; set; }
        public Node NextNode { get; set; }
        public Node PrevNode { get; set; }

    }

    public interface ILinkedList
    {
        int GetCount();                             // возвращает количество элементов в списке
        void AddNode(int value);                    // добавляет новый элемент списка
        void AddNodeAfter(Node node, int value);    // добавляет новый элемент списка после определённого элемента
        void RemoveNode(int index);                 // удаляет элемент по порядковому номеру
        void RemoveNode(Node node);                 // удаляет указанный элемент
        Node FindNode(int searchValue);             // ищет элемент по его значению
    }

    public class DoublyLinkedList : ILinkedList
    {
        private readonly Node head = new Node();
        private readonly Node tail = new Node();

        public DoublyLinkedList()
        {
            head.NextNode = tail;
            tail.PrevNode = head;
        }

        public void AddNode(int value)
        {
            var node = head.NextNode;
            while (node.NextNode != null)
            {
                node = node.NextNode;
            }
            var newNode = new Node { Value = value };
            node.NextNode = newNode;
        }

        public void AddNodeAfter(Node node, int value)
        {
            var newNode = new Node { Value = value };
            var nextItem = node.NextNode;
            node.NextNode = newNode;
            newNode.NextNode = nextItem;
        }

        public Node FindNode(int searchValue)
        {
            Node current = head.NextNode;
            while (current != tail && current.Value != searchValue)
            {
                current = current.NextNode;
            }
            if (current != tail)
            {
                return current;
            }
            else
            {
                return null;
            }
        }

        public int GetCount()
        {
            int count = 0;
            Node current = head.NextNode;
            while (current != tail)
            {
                current = current.NextNode;
                count++;
            }
            return count;
        }

        public void RemoveNode(int index)
        {
            int count = 0;
            Node current = head.NextNode;
            while (current != tail && count < index)
            {
                current = current.NextNode;
                count++;
            }
            if (count == index)
            {
                RemoveNode(current);
            }
            else
            {
                throw new ArgumentException("Узла с таким индексом нет в списке.", nameof(index));
            }
        }

        public void RemoveNode(Node node)
        {
            Node next = node.NextNode;
            Node prev = node.PrevNode;

            next.PrevNode = prev;
            prev.NextNode = next;
        }

    }
}
