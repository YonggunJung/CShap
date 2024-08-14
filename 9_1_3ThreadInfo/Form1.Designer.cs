namespace _9_1_3ThreadInfo
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
            this.tbThreadInfo = new System.Windows.Forms.TextBox();
            this.btnThreadInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbThreadInfo
            // 
            this.tbThreadInfo.Location = new System.Drawing.Point(58, 23);
            this.tbThreadInfo.Multiline = true;
            this.tbThreadInfo.Name = "tbThreadInfo";
            this.tbThreadInfo.Size = new System.Drawing.Size(319, 232);
            this.tbThreadInfo.TabIndex = 0;
            // 
            // btnThreadInfo
            // 
            this.btnThreadInfo.Location = new System.Drawing.Point(109, 288);
            this.btnThreadInfo.Name = "btnThreadInfo";
            this.btnThreadInfo.Size = new System.Drawing.Size(232, 61);
            this.btnThreadInfo.TabIndex = 1;
            this.btnThreadInfo.Text = "스레드 정보";
            this.btnThreadInfo.UseVisualStyleBackColor = true;
            this.btnThreadInfo.Click += new System.EventHandler(this.BtnThreadInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThreadInfo);
            this.Controls.Add(this.tbThreadInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbThreadInfo;
        private System.Windows.Forms.Button btnThreadInfo;
    }
}

