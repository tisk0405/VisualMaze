using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace VisualMaze
{
    public class MazeNavigator
    {
        public int Size { get; set; }
        public int[,] _maze { get; set; }
        public Position CurrentPosition { get; set; }
        public Thread NaviThread { get; set; }

        public List<Position> PositionsList { get; set; }
        
        // 생성자
        public MazeNavigator(MyMaze maze)
        {
            Size = maze.mazeSize;
            // 2차원 배열 복사본 만들기 (완성된 미로 가져오기)
            _maze = new int[(2 * maze.mazeSize) + 1, (2 * maze.mazeSize) + 1];

            // 2 * maze.mazeSize + 1 = maze.maze.GetLength()
            for (int i = 0; i < maze.maze.GetLength(0); i++)
            {
                for (int j = 0; j < maze.maze.GetLength(1); j++)
                {
                    _maze[i, j] = maze.maze[i, j];
                }
            }

            // cell 들을 1로 초기화
            for (int i = 1; i < maze.maze.GetLength(0); i+=2)
            {
                for (int j = 1; j < maze.maze.GetLength(1); j+=2)
                {
                    _maze[i, j] = 1;
                }
            }
        }

        public void BreadthFirstSearch(Position startPosition)
        {
            Queue<Position> que = new Queue<Position>();

            CurrentPosition = new Position(startPosition.PositionX, startPosition.PositionY);
         
            // 큐에 넣기
            que.Enqueue(CurrentPosition);
            // 방문한 셀을 -> true
//            _maze[CurrentPosition.PositionX, CurrentPosition.PositionY] = 0;
            PositionsList = new List<Position>();

            while (que.Count != 0)
            {
                _maze[CurrentPosition.PositionX, CurrentPosition.PositionY] = 0;

                CurrentPosition = que.Dequeue();
                //Dequeue 한 위치를 리스트에 추가
                PositionsList.Add(CurrentPosition);

                Thread.Sleep(200);

//                MessageBox.Show($"현재 위치는 : {CurrentPosition.PositionX}, {CurrentPosition.PositionY}");
                //                current.x == width - 1 && current.y == height - 1
                // 도착 하면 빠져 나감
                if (CurrentPosition.PositionX == _maze.GetLength(0)-2 && CurrentPosition.PositionY == _maze.GetLength(1) -2)
                    break;
                
                // 4방향 확인후 적합한 방향의 셀 정보만 큐에 삽입
                // 위쪽
                if(_maze[CurrentPosition.PositionX-1, CurrentPosition.PositionY] == 0) //현재위치의 바로위쪽칸에 들어있는 값이 0이면
                {
                    if(_maze[CurrentPosition.PositionX - 2, CurrentPosition.PositionY] == 1)
                    {
                        que.Enqueue(new Position(CurrentPosition.PositionX -2 , CurrentPosition.PositionY));
                    }
                }
                // 왼쪽
                if (_maze[CurrentPosition.PositionX, CurrentPosition.PositionY - 1] == 0) 
                {
                    if (_maze[CurrentPosition.PositionX, CurrentPosition.PositionY - 2] == 1)
                    {
                        que.Enqueue(new Position(CurrentPosition.PositionX, CurrentPosition.PositionY - 2));
                    }
                }
                // 아래쪽
                if (_maze[CurrentPosition.PositionX + 1, CurrentPosition.PositionY] == 0) 
                {
                    if (_maze[CurrentPosition.PositionX + 2, CurrentPosition.PositionY] == 1)
                    {
                        que.Enqueue(new Position(CurrentPosition.PositionX + 2, CurrentPosition.PositionY));
                    }
                }
                // 오른쪽
                if (_maze[CurrentPosition.PositionX, CurrentPosition.PositionY + 1] == 0) 
                {
                    if (_maze[CurrentPosition.PositionX, CurrentPosition.PositionY + 2] == 1)
                    {
                        que.Enqueue(new Position(CurrentPosition.PositionX, CurrentPosition.PositionY + 2));
                    }
                }
            }
        }
    }

}