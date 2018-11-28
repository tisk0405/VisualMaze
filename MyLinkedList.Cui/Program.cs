using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyLinkedList.Cui
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList list = new MyLinkedList();
            int command = 0;

            while (true)
            {
                Console.WriteLine("1. 리스트에 항목 추가");
                Console.WriteLine("2. 리스트에 항목 삭제");
                Console.WriteLine("3. 리스트 출력");
                Console.WriteLine("4. 종료");
                Console.WriteLine("---------------------");

                command = Int32.Parse(Console.ReadLine());

                if (command == 1)
                {
                    Console.WriteLine("리스트에 추가할거니까 원하는 값을 입력하세요");
                    int a = Int32.Parse(Console.ReadLine());
                    list.Add(a);
                    Console.WriteLine("앙 추가됨");

                }

                // 리스트에서 항목 삭제
                if (command == 2)
                {
                    Console.WriteLine("몇 번째 항목을 삭제 할까요?");
                    int del = Int32.Parse(Console.ReadLine());

                    list.Remove(del);
                }
                Console.WriteLine(list.Count());
                    // 리스트 출력
                if (command == 3)
                {
                    for (int i = 0; i < list.Count(); i++)
                    {
                        Console.WriteLine("-----------");
                        Console.WriteLine(list.Get(i));
                    }
                }

                // 종료
                if (command == 4)
                    break;
            }
        }
    }
}
