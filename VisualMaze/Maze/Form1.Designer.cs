namespace VisualMaze
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RecursiveRB = new System.Windows.Forms.RadioButton();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.Animatebtn = new System.Windows.Forms.Button();
            this.Navibtn = new System.Windows.Forms.Button();
            this.Makebtn = new System.Windows.Forms.Button();
            this.Sizetxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("monofur", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(692, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "A Mazing";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("monofur", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(802, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 60);
            this.label2.TabIndex = 1;
            this.label2.Text = "Maze";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("monofur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(697, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "알고리즘";
            // 
            // RecursiveRB
            // 
            this.RecursiveRB.AutoSize = true;
            this.RecursiveRB.Checked = true;
            this.RecursiveRB.Font = new System.Drawing.Font("monofur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RecursiveRB.Location = new System.Drawing.Point(702, 306);
            this.RecursiveRB.Name = "RecursiveRB";
            this.RecursiveRB.Size = new System.Drawing.Size(250, 24);
            this.RecursiveRB.TabIndex = 3;
            this.RecursiveRB.TabStop = true;
            this.RecursiveRB.Text = "RecursiveBacktracker";
            this.RecursiveRB.UseVisualStyleBackColor = true;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.GenerateButton.Font = new System.Drawing.Font("monofur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.GenerateButton.Location = new System.Drawing.Point(689, 474);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(262, 47);
            this.GenerateButton.TabIndex = 5;
            this.GenerateButton.Text = "&Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // Clearbtn
            // 
            this.Clearbtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Clearbtn.Font = new System.Drawing.Font("monofur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Clearbtn.Location = new System.Drawing.Point(690, 633);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(262, 47);
            this.Clearbtn.TabIndex = 6;
            this.Clearbtn.Text = "&Clear";
            this.Clearbtn.UseVisualStyleBackColor = true;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // Animatebtn
            // 
            this.Animatebtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Animatebtn.Font = new System.Drawing.Font("monofur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Animatebtn.Location = new System.Drawing.Point(689, 527);
            this.Animatebtn.Name = "Animatebtn";
            this.Animatebtn.Size = new System.Drawing.Size(262, 47);
            this.Animatebtn.TabIndex = 7;
            this.Animatebtn.Text = "&Animate";
            this.Animatebtn.UseVisualStyleBackColor = true;
            this.Animatebtn.Click += new System.EventHandler(this.Animatebtn_Click);
            // 
            // Navibtn
            // 
            this.Navibtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Navibtn.Font = new System.Drawing.Font("monofur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Navibtn.Location = new System.Drawing.Point(689, 580);
            this.Navibtn.Name = "Navibtn";
            this.Navibtn.Size = new System.Drawing.Size(262, 47);
            this.Navibtn.TabIndex = 8;
            this.Navibtn.Text = "&Navigator";
            this.Navibtn.UseVisualStyleBackColor = true;
            this.Navibtn.Click += new System.EventHandler(this.Navibtn_Click);
            // 
            // Makebtn
            // 
            this.Makebtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Makebtn.Font = new System.Drawing.Font("monofur", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Makebtn.Location = new System.Drawing.Point(849, 391);
            this.Makebtn.Name = "Makebtn";
            this.Makebtn.Size = new System.Drawing.Size(103, 25);
            this.Makebtn.TabIndex = 9;
            this.Makebtn.Text = "&Make";
            this.Makebtn.UseVisualStyleBackColor = true;
            this.Makebtn.Click += new System.EventHandler(this.Makebtn_Click);
            // 
            // Sizetxt
            // 
            this.Sizetxt.Location = new System.Drawing.Point(690, 391);
            this.Sizetxt.Name = "Sizetxt";
            this.Sizetxt.Size = new System.Drawing.Size(153, 25);
            this.Sizetxt.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 731);
            this.Controls.Add(this.Sizetxt);
            this.Controls.Add(this.Makebtn);
            this.Controls.Add(this.Navibtn);
            this.Controls.Add(this.Animatebtn);
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.RecursiveRB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage mazePage;
        private System.Windows.Forms.TextBox Sizetxt;
        private System.Windows.Forms.Button Makebtn;
        private System.Windows.Forms.Button Navibtn;
        private System.Windows.Forms.Button Animatebtn;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.RadioButton RecursiveRB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
//        private System.Windows.Forms.TabPage tabPage2;
    }
}

