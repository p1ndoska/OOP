using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03_OOP
{

    public class Node<T>
    {

        public Node(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public Node<T> Next { get; set; }
    }
    class List<T>
    {

       static Node<T> head; // головной/первый элемент
       static Node<T> tail; // последний/хвостовой элемент
       static int count;  // количество элементов в списке

        public int Count { get { return count; } }

        public List()
        {

        }

        public static List<T> operator >>(List<T> list, int i)
         public void AddIndex(string info, int i) //добавление в i позицию
        {
            var bend = new MyListNode { Info = info };

            if (i == 0)
            {
                bend.tail = list1;
                list1 = bend;
            }
            else
            {
                var prev = NodeI(i - 1);
                bend.tail = prev.tail;
                prev.tail = bend;
            }
        }


        public static List<T> operator +(List<T> list, int i)
        {
            Node<T> current = head;
            Node<T> previous = null;

            while (current != null)
            {

            }


            public static void RemoveI(int i) //удаление по индексу
            {
                if (i == 0)
                {
                    list1 = list1.tail;
                }
                else
                {
                    var prev = NodeI(i - 1);
                    prev.tail = prev.tail.tail;
                }
            }
