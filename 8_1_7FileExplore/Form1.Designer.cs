namespace _8_1_7FileExplore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAttr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.ToolStripOpen = new System.Windows.Forms.MenuStrip();
            this.열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripOpen.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chAttr,
            this.chSize,
            this.chTime});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(25, 39);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(704, 335);
            this.listView.SmallImageList = this.imageList;
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.Click += new System.EventHandler(this.ListView_Click);
            // 
            // chName
            // 
            this.chName.Text = "이름";
            this.chName.Width = 150;
            // 
            // chAttr
            // 
            this.chAttr.Text = "속성";
            this.chAttr.Width = 100;
            // 
            // chSize
            // 
            this.chSize.Text = "크기";
            this.chSize.Width = 100;
            // 
            // chTime
            // 
            this.chTime.Text = "생성 시간";
            this.chTime.Width = 300;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "1.jpg");
            this.imageList.Images.SetKeyName(1, "2.jpg");
            this.imageList.Images.SetKeyName(2, "3.jpg");
            this.imageList.Images.SetKeyName(3, "4.jpg");
            this.imageList.Images.SetKeyName(4, "5.jpg");
            // 
            // ToolStripOpen
            // 
            this.ToolStripOpen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.열기ToolStripMenuItem});
            this.ToolStripOpen.Location = new System.Drawing.Point(0, 0);
            this.ToolStripOpen.Name = "ToolStripOpen";
            this.ToolStripOpen.Size = new System.Drawing.Size(800, 24);
            this.ToolStripOpen.TabIndex = 1;
            this.ToolStripOpen.Text = "열기";
            this.ToolStripOpen.Click += new System.EventHandler(this.ToolStripOpen_Click);
            // 
            // 열기ToolStripMenuItem
            // 
            this.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
            this.열기ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.열기ToolStripMenuItem.Text = "파일";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.ToolStripOpen);
            this.MainMenuStrip = this.ToolStripOpen;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ToolStripOpen.ResumeLayout(false);
            this.ToolStripOpen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chAttr;
        private System.Windows.Forms.ColumnHeader chSize;
        private System.Windows.Forms.ColumnHeader chTime;
        private System.Windows.Forms.MenuStrip ToolStripOpen;
        private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem;
    }
}

