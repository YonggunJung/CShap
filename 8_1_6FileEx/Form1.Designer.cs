namespace _8_1_6FileEx
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
            this.btnFileCopy = new System.Windows.Forms.Button();
            this.btnFileInfo = new System.Windows.Forms.Button();
            this.lbFileInfo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnFileCopy
            // 
            this.btnFileCopy.Location = new System.Drawing.Point(68, 29);
            this.btnFileCopy.Name = "btnFileCopy";
            this.btnFileCopy.Size = new System.Drawing.Size(127, 46);
            this.btnFileCopy.TabIndex = 0;
            this.btnFileCopy.Text = "파일 복사";
            this.btnFileCopy.UseVisualStyleBackColor = true;
            this.btnFileCopy.Click += new System.EventHandler(this.BtnFileCopy_Click);
            // 
            // btnFileInfo
            // 
            this.btnFileInfo.Location = new System.Drawing.Point(265, 29);
            this.btnFileInfo.Name = "btnFileInfo";
            this.btnFileInfo.Size = new System.Drawing.Size(130, 46);
            this.btnFileInfo.TabIndex = 1;
            this.btnFileInfo.Text = "파일 정보";
            this.btnFileInfo.UseVisualStyleBackColor = true;
            this.btnFileInfo.Click += new System.EventHandler(this.BtnFileInfo_Click);
            // 
            // lbFileInfo
            // 
            this.lbFileInfo.FormattingEnabled = true;
            this.lbFileInfo.ItemHeight = 12;
            this.lbFileInfo.Location = new System.Drawing.Point(68, 108);
            this.lbFileInfo.Name = "lbFileInfo";
            this.lbFileInfo.Size = new System.Drawing.Size(327, 160);
            this.lbFileInfo.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbFileInfo);
            this.Controls.Add(this.btnFileInfo);
            this.Controls.Add(this.btnFileCopy);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFileCopy;
        private System.Windows.Forms.Button btnFileInfo;
        private System.Windows.Forms.ListBox lbFileInfo;
    }
}

