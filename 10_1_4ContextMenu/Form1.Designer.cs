namespace _10_1_4ContextMenu
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripCut = new System.Windows.Forms.ToolStripMenuItem();
            this.lblResult = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripCopy,
            this.ToolStripPaste,
            this.ToolStripCut});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 70);
            this.contextMenuStrip1.Text = "콘텍스트 메뉴";
            // 
            // ToolStripCopy
            // 
            this.ToolStripCopy.Name = "ToolStripCopy";
            this.ToolStripCopy.Size = new System.Drawing.Size(180, 22);
            this.ToolStripCopy.Text = "복사";
            this.ToolStripCopy.Click += new System.EventHandler(this.ToolStripCopy_Click);
            // 
            // ToolStripPaste
            // 
            this.ToolStripPaste.Name = "ToolStripPaste";
            this.ToolStripPaste.Size = new System.Drawing.Size(180, 22);
            this.ToolStripPaste.Text = "붙여넣기";
            this.ToolStripPaste.Click += new System.EventHandler(this.ToolStripPaste_Click);
            // 
            // ToolStripCut
            // 
            this.ToolStripCut.Name = "ToolStripCut";
            this.ToolStripCut.Size = new System.Drawing.Size(180, 22);
            this.ToolStripCut.Text = "잘라내기";
            this.ToolStripCut.Click += new System.EventHandler(this.ToolStripCut_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblResult.Location = new System.Drawing.Point(266, 212);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(183, 19);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "결과를 출력합니다.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripCopy;
        private System.Windows.Forms.ToolStripMenuItem ToolStripPaste;
        private System.Windows.Forms.ToolStripMenuItem ToolStripCut;
        private System.Windows.Forms.Label lblResult;
    }
}

