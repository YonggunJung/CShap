namespace _8_1_4DirectoryInfoEx
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
            this.lbDirInfo = new System.Windows.Forms.ListBox();
            this.btnDirInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDirInfo
            // 
            this.lbDirInfo.FormattingEnabled = true;
            this.lbDirInfo.ItemHeight = 12;
            this.lbDirInfo.Location = new System.Drawing.Point(66, 51);
            this.lbDirInfo.Name = "lbDirInfo";
            this.lbDirInfo.Size = new System.Drawing.Size(384, 256);
            this.lbDirInfo.TabIndex = 0;
            // 
            // btnDirInfo
            // 
            this.btnDirInfo.Location = new System.Drawing.Point(178, 330);
            this.btnDirInfo.Name = "btnDirInfo";
            this.btnDirInfo.Size = new System.Drawing.Size(164, 54);
            this.btnDirInfo.TabIndex = 1;
            this.btnDirInfo.Text = "디렉터리 정보";
            this.btnDirInfo.UseVisualStyleBackColor = true;
            this.btnDirInfo.Click += new System.EventHandler(this.BtnDirInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDirInfo);
            this.Controls.Add(this.lbDirInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbDirInfo;
        private System.Windows.Forms.Button btnDirInfo;
    }
}

