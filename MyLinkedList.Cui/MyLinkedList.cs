using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;

namespace MyLinkedList.Cui
{
    public class MyLinkedList
    {
        private Node Head;
        private Node Tail;
        private int Size;

        public MyLinkedList()
        {
            Head = null;
            Tail = null;
            Size = 0;
        }

        // Method 접근제한자, 반환타입 , 이름(매개변수)
        public void Add(int value)
        {
            if (Head == null)
            {
                Node newNode = new Node();
                // 멤버변수
                newNode.Value = value;
                newNode.Next = null;   // 새로 추가해서 다음놈이 없음

                Head = newNode;
                Tail = newNode;
                Size++;
            }
            else
            {
                Node prevTail = Tail;

                Node newNode = new Node();
                //Node nextNode = new Node();
                newNode.Value = value;
                newNode.Next = null;
                prevTail.Next = newNode;

                Tail = newNode;
                Size++;
            }

        }

        public void Remove(int index) // index 값 넘겨줌
        {
            Console.WriteLine($"매개변수 : {index}");
            if (Size == 0)
            {
                Console.WriteLine("없엉");
                return;
            }

            if (Size <= index)
                throw new Exception("리스트의 갯수보다 인덱스가 큽니다");
            if (index < 0)
                throw new Exception("음수는 앙대여");

            if (index == 0)
            {
                Head = Head.Next;
                Size--;
            }
            else
            {
                Node tempNode = Head;
                Node prevNode = Head;

                for (int i = 0; i < index; i++)
                {
                    tempNode = tempNode.Next;
                }

                for (int i = 0; i < index -1; i++)
                {
                    prevNode = prevNode.Next;
                }

                prevNode.Next = tempNode.Next;

                Size--;
            }

            return;

        }

        public int Count()
        {
            return Size;
        }

        public int Get(int index) // index 값 넘겨줌
        {
            // 리스트의 i번째를 가져옴 ex int[i] = 2
            //Node newNode = new Node();
            Node tempNode = Head;

            if (tempNode == null)
                throw new Exception("리스트에 없엉");

            for (int i = 0; i < index; i++)
            {
                tempNode = tempNode.Next;
            }

            return tempNode.Value;

        }

    }


}