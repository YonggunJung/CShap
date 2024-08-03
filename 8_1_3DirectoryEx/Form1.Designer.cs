namespace _8_1_3DirectoryEx
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
            this.lbDir = new System.Windows.Forms.ListBox();
            this.lbFiles = new System.Windows.Forms.ListBox();
            this.btnDirList = new System.Windows.Forms.Button();
            this.btnFileList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDir
            // 
            this.lbDir.FormattingEnabled = true;
            this.lbDir.ItemHeight = 12;
            this.lbDir.Location = new System.Drawing.Point(0, 0);
            this.lbDir.Name = "lbDir";
            this.lbDir.Size = new System.Drawing.Size(351, 160);
            this.lbDir.TabIndex = 0;
            // 
            // lbFiles
            // 
            this.lbFiles.FormattingEnabled = true;
            this.lbFiles.ItemHeight = 12;
            this.lbFiles.Location = new System.Drawing.Point(0, 166);
            this.lbFiles.Name = "lbFiles";
            this.lbFiles.Size = new System.Drawing.Size(351, 196);
            this.lbFiles.TabIndex = 0;
            // 
            // btnDirList
            // 
            this.btnDirList.Location = new System.Drawing.Point(381, 54);
            this.btnDirList.Name = "btnDirList";
            this.btnDirList.Size = new System.Drawing.Size(97, 43);
            this.btnDirList.TabIndex = 1;
            this.btnDirList.Text = "디렉터리 목록";
            this.btnDirList.UseVisualStyleBackColor = true;
            this.btnDirList.Click += new System.EventHandler(this.BtnDirList_Click);
            // 
            // btnFileList
            // 
            this.btnFileList.Location = new System.Drawing.Point(381, 229);
            this.btnFileList.Name = "btnFileList";
            this.btnFileList.Size = new System.Drawing.Size(97, 42);
            this.btnFileList.TabIndex = 2;
            this.btnFileList.Text = "파일 목록";
            this.btnFileList.UseVisualStyleBackColor = true;
            this.btnFileList.Click += new System.EventHandler(this.BtnFileList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFileList);
            this.Controls.Add(this.btnDirList);
            this.Controls.Add(this.lbFiles);
            this.Controls.Add(this.lbDir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbDir;
        private System.Windows.Forms.ListBox lbFiles;
        private System.Windows.Forms.Button btnDirList;
        private System.Windows.Forms.Button btnFileList;
    }
}

