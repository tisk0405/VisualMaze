using System;
using System.Drawing;
using SkipList.Cui;

namespace VisualMaze.SkipList
{
    public class SkipListPainter
    {
        // 원 그려주는 펜
        private Pen CirclePen;
        // 이어주는 선
        private Pen Line;

        private global::SkipList.Cui.SkipList _skipList;

        public SkipListPainter(global::SkipList.Cui.SkipList skipList)
        {
            _skipList = skipList;
            Line = new Pen(Color.Black);
            Line.Width = 3f;
            CirclePen = new Pen(Color.AliceBlue);
        }

        public void PaintCircleToForm(int skiplistHeight, Graphics target, int x, int y, int sizeX, int sizeY)
        {
            for (int i = 0; i < skiplistHeight; i++)
            {
                target.DrawEllipse(CirclePen, x, y, sizeX, sizeY);
                target.Dispose();
            }


        }

        internal void DrawSkipList(Graphics graphics, int startX, int startY)
        {
            for (int i = _skipList.skiplistHeight; i >= 1; i--)
            {
                DrawOneLevel(graphics, _skipList.skiplistHeight, startX, startY);
            }
        }

        public void DrawOneLevel(Graphics g, int skiplistHeight, int startX, int startY)
        {
            Node LayerHead = _skipList.GetLayerHead(skiplistHeight);
//            LayerHead = LayerHead
//            LayerHead.Value;
//            
            //_skipList
            // 노드수 만큼 반복
            for (int i = 0; i < 1; i++)
            {
                





            }







//            using (Font font = new Font("Arial", 9, FontStyle.Bold, GraphicsUnit.Point))
//            {
//                for (int i = 0; i < skiplistHeight; i++)
//                {
//                    RectangleF rect = new RectangleF(startX * i * 7, startY, 50, 50);
//                    g.DrawRectangle(CirclePen, Rectangle.Round(rect));
////                    g.DrawString(value.ToString(), font, Brushes.Blue, rect);
//                }
//            
//            }

        }
    }
}