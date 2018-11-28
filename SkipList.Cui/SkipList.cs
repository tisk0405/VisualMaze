using System;
using System.Security.Cryptography;

namespace SkipList.Cui
{
    public class SkipList
    {       
        const int MAXLEVEL = 32;

        // 초기 높이
        public int skiplistHeight = 1;

        // 스킵리스트 머리
        Node head = new Node(-Int32.MaxValue, MAXLEVEL);

        Random rand = new Random();

        public void Insert(int value)
        {
            int nodelevel = 1;

            // 랜덤으로 레벨 추가 head 를 가질때마다
            // 노드를 높은 레벨로 promote
            while (rand.Next(0, 2) == 1)
                nodelevel++;

            // maxlevel = 32 32보다 높으면 32로 set
            if (nodelevel > MAXLEVEL)
                nodelevel = MAXLEVEL;

            // 현재 노드의 레벨이 목록 높이보다 클 경우 skip
            if (skiplistHeight < nodelevel)
                skiplistHeight = nodelevel;

#if DEBUG
            Console.WriteLine($"값 : {value} \t 레벨 : {nodelevel}");
#endif

            Node newNode = new Node(value, nodelevel);

            // node 삽입할 노드 만듬
            Node currentNode = head;

            // 목록 맨 위에서 시작 
            // 다음 노드의 값이 필요한 값보다 클 경우 
            // 삽입한 후 한 레벨 아래로 이동하는 것과 같은 내부 루프에서 끊어짐.            
            for (int i= skiplistHeight -1; i>=0; i--)
            {
                for(; currentNode.next[i] != null; currentNode = currentNode.next[i])
                {
                    if (currentNode.next[i].Value > value)
                        break;                                           
                }

                // 현재 수준이 노드 수준보다 작으면 노드를 삽입
                if (i < nodelevel)
                {
                    // 현재레벨에 노드 추가
                    newNode.next[i] = currentNode.next[i];
                    currentNode.next[i] = newNode;
                }                
            }
        }

        public bool SearchNode(int index)
        {
            Node currentNode = this.head;

            for(int i= skiplistHeight-1; i>=0; i--)
            {
                for(; currentNode.next[i] != null; currentNode = currentNode.next[i])
                {
                    if (currentNode.next[i].Value == index)
                        return true;
                    if (currentNode.next[i].Value > index)
                        return false;
                }
            }

            return false;
        }

        public Node GetLayerHead(int level)
        {
            return head.next[level];
        }

        public void PrintSkiplist()
        {
            // 모든 레벨 통과
            for(int i= skiplistHeight-1; i>=0; i--)
            {
                Console.WriteLine($"{i + 1}레벨 노드");

                Node currentNode = head.next[i];

                // 현재수준의 모든 노드를 출력
                while(currentNode != null)
                {
                    Console.Write(currentNode.Value + "   ");
                    currentNode = currentNode.next[i];
                }
                Console.WriteLine();
            }
        }

        public void Delete(int index)
        {
            Node currentNode = head;

            for (int i = skiplistHeight - 1; i >= 0; i--)
            {
                for (; currentNode.next[i] != null; currentNode = currentNode.next[i])
                {
                    if (currentNode.next[i].Value == index)
                    {
                        currentNode.next[i] = currentNode.next[i].next[i];

                        // 최상위 헤드인 경우 높이 감소
                        if (currentNode == head && currentNode.next[i] == null)
                            skiplistHeight--;

                        break;
                    }

                    else if (currentNode.next[i].Value > index)
                        break;
                }                                                    
            }            
        }
    }
}