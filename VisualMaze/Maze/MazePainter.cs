using System.Drawing;

namespace VisualMaze
{
    public class MazePainter
    {
        private Pen LinePen;
        private Pen RectanglePen;
        
        public MazePainter()
        {
            LinePen = new Pen(Color.Black);
            LinePen.Width = 2f;
            RectanglePen = new Pen(Color.IndianRed);
        }

        public void PaintMazeToForm(int[,] Maze, int MazeSize, Graphics target, float startX, float startY, float size)
        {
            float interval = size / MazeSize;

            //가로선을 그려줍니다.
            for (int i = 0; i < Maze.GetLength(0); i += 2)
            {
                float tempY = startY + interval * i / 2;
                for (int j = 1; j < Maze.GetLength(1) - 1; j += 2)
                {
                    float tempX = startX + ((j - 1) / 2) * interval;
                    if (Maze[i, j] == 1)
                    {
                        target.DrawLine(LinePen, tempX, tempY, tempX + interval, tempY);
                    }
                }
            }

            //세로선을 그려줍니다.
            for (int i = 1; i < Maze.GetLength(0); i += 2)
            {
                float tempY = startY + ((i - 1) / 2) * interval;
                for (int j = 0; j < Maze.GetLength(1); j += 2)
                {
                    float tempX = startX + interval * j / 2;
                    if (Maze[i, j] == 1)
                    {
                        target.DrawLine(LinePen, tempX, tempY, tempX, tempY + interval);
                    }
                }
            }
        }

        public void PaintRectToCell(Graphics g, int mazeSize, int mazeStartX, int mazeStartY, int mazeWidth, int x, int y)
        {
            float interval = mazeWidth / mazeSize;
            float margin = interval / 10;
            int cellIndexX = (x - 1) / 2;
            int cellIndexY = (y - 1) / 2;
            
//            g.DrawRectangle(RectanglePen, mazeStartX + interval*cellIndexY+ margin, mazeStartY + interval * cellIndexX+margin, interval-margin*2, interval - margin * 2);

            g.FillRectangle(new SolidBrush(Color.IndianRed), mazeStartX + interval * cellIndexY + margin, mazeStartY + interval * cellIndexX + margin, interval - margin * 2, interval - margin * 2);
        }

        public void PaintTrace(Graphics g, int mazeSize, int mazeStartX, int mazeStartY, int mazeWidth, int x, int y)
        {
            float interval = mazeWidth / mazeSize;
            float margin = interval / 10;
            int cellIndexX = (x - 1) / 2;
            int cellIndexY = (y - 1) / 2;
            
            g.FillRectangle(new SolidBrush(Color.IndianRed), mazeStartX + interval * cellIndexY + margin, mazeStartY + interval * cellIndexX + margin, interval - margin * 2, interval - margin * 2);
        }
        
    }
}