using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualMaze.SkipList;
using SkipList.Cui;

namespace VisualMaze
{
    public partial class Form2 : Form
    {
        private global::SkipList.Cui.SkipList skipList = new global::SkipList.Cui.SkipList();
        private SkipListPainter painter;

        private const int startX = 10;
        private const int startY = 10;
        private const int height = 600;
        private const int width = 700;

        public Form2()
        {
            painter = new SkipListPainter(skipList);

            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
//            var myControl = new VisualMaze.SkipList.MyControl();
//            Viewpanel.Controls.Add(myControl);
        }
//
//        public 페인트리스너()
//        {
//            그려준다
//            //어떻게?
//            // 스킵리스트에 들어있는 레벨 수만큼
//            // 구획을 나눈다.
//            // 각 구획에 해당하는 레벨에 들어있는 노드들을 그려준다.
//        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            painter.DrawSkipList(e.Graphics, startX, startY);
        }

        private void Insertbtn_Click(object sender, EventArgs e)
        {
            skipList.Insert(int.Parse(Valuetxt.Text));
            this.Invalidate();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            skipList.Delete(int.Parse(Valuetxt.Text));
            this.Invalidate();
        }

    }
}
