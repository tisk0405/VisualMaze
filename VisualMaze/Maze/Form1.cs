using System;
using System.Threading;
using System.Windows.Forms;

namespace VisualMaze
{
    public partial class Form1 : Form
    {
        MazePainter painter = new MazePainter();
        //MyLinkedList list = new MyLinkedList();
        TextBox txt = new TextBox();

        private MazeNavigator mazeNavigator;
        private MyMaze maze = new MyMaze(16, false);

        public Form1()
        {
            maze.MyThread = new Thread(() => maze.Recursive(1, 1));

            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {           
            painter.PaintMazeToForm(maze.maze, maze.mazeSize, e.Graphics, 10, 10, 560);

            //if 길찾기 모드일때만 한다.
            if (Navibtn.Enabled == false)
            {
                for (int i = 0; i < mazeNavigator.PositionsList.Count; i++)
                {
                    painter.PaintTrace(e.Graphics, maze.mazeSize, 10, 10, 560, mazeNavigator.PositionsList[i].PositionX,
                        mazeNavigator.PositionsList[i].PositionY);
                }
            }

            if (Animatebtn.Enabled == false)
            {
                painter.PaintRectToCell(e.Graphics,maze.mazeSize, 10,10,560, maze.CurrentPosition.PositionX, maze.CurrentPosition.PositionY);


                if (maze.MyThread.ThreadState == ThreadState.Stopped)
                {
                    Animatebtn.Enabled = true;
                    MessageBox.Show("미로 완성");
                }
            }
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            if (RecursiveRB.Checked == true)
            {
                maze._isAnimate = false;
                maze.ClearMaze();
                timer1.Start();

                maze.Recursive(1, 1);
                //                maze.MyThread.Start();
                this.Invalidate();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            FormClosed += (o, a) => new Form1().ShowDialog();

            Hide();
            Close();
        }

        private void Animatebtn_Click(object sender, EventArgs e)
        {
            if (RecursiveRB.Checked == true)
            {
                maze.MyThread = new Thread(() => maze.Recursive(1, 1));

                maze._isAnimate = true;
                maze.ClearMaze();

                maze.MyThread.Start();
                timer1.Start();

                Animatebtn.Enabled = false;
            }
        }

        private void Navibtn_Click(object sender, EventArgs e)
        {
            //            MazeNavigator mazeNavigator = new MazeNavigator(maze);
            //mazeNavigator.BreadthFirstSearch(new Position(1,1));
            mazeNavigator = new MazeNavigator(maze);
            mazeNavigator.NaviThread = new Thread(() => mazeNavigator.BreadthFirstSearch(new Position(1, 1)));
            timer1.Start();
            mazeNavigator.NaviThread.Start();
            Navibtn.Enabled = false;
        }

        private void Makebtn_Click(object sender, EventArgs e)
        {
            if (Sizetxt.Text != "")
            {
                maze = new MyMaze(int.Parse(Sizetxt.Text), false);
                maze.MyThread = new Thread(() => maze.Recursive(1, 1));
                this.Invalidate();
                //Makebtn.Enabled = false;
            }
            else
            {
                MessageBox.Show("값을 입력해주세요");
            }
        }
    }
}
