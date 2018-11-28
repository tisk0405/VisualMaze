using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Windows.Forms;

namespace VisualMaze
{
    public class MyMaze
    {
        public int mazeSize { get; set; }
        public int[,] maze { get; set; }
        public bool _isAnimate;

        private Random rand;
        public Thread MyThread { get; set; }
        public Position CurrentPosition { get; set; }

        public MyMaze(int size, bool isAnimate)
        {
            _isAnimate = isAnimate;
            rand = new Random();
            mazeSize = size;
            maze = new int[(2 * size) + 1, (2 * size) + 1];
            CurrentPosition = new Position(1,1);

            // cell에 값을 넣어줘야함 (2차원배열 -> 2중 반복)
            ClearMaze();
        }

        public void ClearMaze()
        {
            for (int i = 0; i < maze.GetLength(0); i++)
            {
                for (int j = 0; j < maze.GetLength(1); j++)
                {
                    maze[i, j] = 1;
                }
            }
        }

        // Recursive BackTracking 알고리즘 // int x, int y
        public void Recursive(int x, int y)
        {
            if (_isAnimate)
                Thread.Sleep(200);  // MyThread

            CurrentPosition.PositionX = x;
            CurrentPosition.PositionY = y;
            maze[x, y] = 0;

            // 이웃들을 담아주는 리스트 생성
            List<Cell> Neighbors = new List<Cell>();

            //현재셀에서 이웃들을 (동,서,남,북)
            //Up 방향 int up = maze[x-2, y];

            //이웃목록에 추가
            AddNeighbors(x, y, Neighbors);

            //if 이웃셀이 한개도 없으면 -> 즉 막다른길이다
            // 그러니까 리턴해서 지금 을 빠져나가서 이전 셀로 돌아가면된다.

            //else -> 즉 한개라도 이웃셀이있다(방문된적없는)
            //나 자신을 한번더 호출한다(매개변수는 랜덤한 방향으로 진행방향에대한 셀의 위치를 매개변수로줘서)

            if (Neighbors.Count == 0)
                return;
            else
            {
                int goNext = rand.Next(0, Neighbors.Count);
                int nextX = Neighbors[goNext].X;
                int nextY = Neighbors[goNext].Y;

                //개척하면서 벽을지워주고 List에서 해당셀 삭제 부분 만들기
                if (Neighbors[goNext].Direction == Direction.Up)
                    maze[nextX + 1, nextY] = 0;
                if (Neighbors[goNext].Direction == Direction.Left)
                    maze[nextX, nextY + 1] = 0;
                if (Neighbors[goNext].Direction == Direction.Down)
                    maze[nextX - 1, nextY] = 0;
                if (Neighbors[goNext].Direction == Direction.Right)
                    maze[nextX, nextY - 1] = 0;

                //Neighbors.Remove(Neighbors[goNext]);

                Recursive(nextX, nextY);

                if (Neighbors.Count > 0)                    
                    Recursive(nextX, nextY);
            }

        }

        // Prim 알고리즘
        public void Prim(int x, int y)
        {
            maze[x, y] = 0;
        }

        public void AddNeighbors(int x, int y, List<Cell> Neighbors)
        {
            #region AddNeighbors
            // 위쪽 이웃
            if (x - 2 > 0)
            {
                if (maze[x - 2, y] == 1)
                {
                    Cell cell = new Cell(x - 2, y, Direction.Up);
                    Neighbors.Add(cell);
                }

            }
            // 왼쪽 이웃
            if (y - 2 > 0)
            {
                if (maze[x, y - 2] == 1)
                {
                    Cell cell = new Cell(x, y - 2, Direction.Left);
                    Neighbors.Add(cell);
                }

            }

            // 아래 이웃
            if (x + 2 < maze.GetLength(0))
            {
                if (maze[x + 2, y] == 1)
                {
                    Cell cell = new Cell(x + 2, y, Direction.Down);
                    Neighbors.Add(cell);
                }
            }

            // 오른쪽 이웃
            if (y + 2 < maze.GetLength(1))
            {
                if (maze[x, y + 2] == 1)
                {
                    Cell cell = new Cell(x, y + 2, Direction.Right);
                    Neighbors.Add(cell);
                }
            }

            #endregion
        }
    }
}