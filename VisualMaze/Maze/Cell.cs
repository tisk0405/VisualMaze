namespace VisualMaze
{
    public class Cell
    {
        public int X { get; set; }
        public int Y { get; set; }
//        public bool isVisited { get; set; }
        public Direction Direction { get; set; }

        public Cell(int x, int y, Direction direction)
        {
            X = x;
            Y = y;
            Direction = direction;            
        }
    }
}