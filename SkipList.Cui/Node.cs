namespace SkipList.Cui
{
    public class Node
    {
        public int Value;
        public int Level;

        public Node[] next;

        public Node(int value, int level)
        {
            Value = value;
            Level = level;
            next = new Node[level];           
        }
    }
}