namespace _10_4_2TaryIcon
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
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ToolStripOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripClose = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripOpen,
            this.ToolStripClose});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(99, 48);
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.contextMenu;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "notifyIcon1";
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseDoubleClick);
            // 
            // ToolStripOpen
            // 
            this.ToolStripOpen.Name = "ToolStripOpen";
            this.ToolStripOpen.Size = new System.Drawing.Size(98, 22);
            this.ToolStripOpen.Text = "열기";
            this.ToolStripOpen.Click += new System.EventHandler(this.ToolStripOpen_Click);
            // 
            // ToolStripClose
            // 
            this.ToolStripClose.Name = "ToolStripClose";
            this.ToolStripClose.Size = new System.Drawing.Size(98, 22);
            this.ToolStripClose.Text = "닫기";
            this.ToolStripClose.Click += new System.EventHandler(this.ToolStripClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ToolStripMenuItem ToolStripOpen;
        private System.Windows.Forms.ToolStripMenuItem ToolStripClose;
    }
}

