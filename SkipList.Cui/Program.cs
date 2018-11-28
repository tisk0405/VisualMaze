using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkipList.Cui
{
    class Program
    {
        static void Main(string[] args)
        {
            SkipList skipList = new SkipList();

            int command = 0;

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1. 스킵 리스트에 항목 추가");
                Console.WriteLine("2. 스킵 리스트에 항목 삭제");
                Console.WriteLine("3. 스킵 리스트 출력");
                Console.WriteLine("4. 종료");
                Console.WriteLine("---------------------");

                command = Int32.Parse(Console.ReadLine());

                if (command == 1)
                {
                    Console.WriteLine("리스트에 추가할거니까 원하는 값을 입력하세요");
                    int a = Int32.Parse(Console.ReadLine());
                    skipList.Insert(a);
                }
                else if (command == 2)
                {
                    // 리스트에서 항목 삭제
                    Console.WriteLine("삭제 하려고 하는 값을 입력하세요?");
                    int del = Int32.Parse(Console.ReadLine());

                    skipList.Delete(del);
                }
                else if (command == 3)
                {
                    // 스킵 리스트 출력
                    skipList.PrintSkiplist();
                }
                else if (command == 4)
                    break;// 종료
            }
        }
    }
}
