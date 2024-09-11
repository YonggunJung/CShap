namespace _9_3_7ThreadMutex
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
            this.btnThreadMutex = new System.Windows.Forms.Button();
            this.tbThreadState = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnThreadMutex
            // 
            this.btnThreadMutex.Location = new System.Drawing.Point(47, 298);
            this.btnThreadMutex.Name = "btnThreadMutex";
            this.btnThreadMutex.Size = new System.Drawing.Size(239, 64);
            this.btnThreadMutex.TabIndex = 0;
            this.btnThreadMutex.Text = "스레드뮤텍스(Mutex)";
            this.btnThreadMutex.UseVisualStyleBackColor = true;
            this.btnThreadMutex.Click += new System.EventHandler(this.BtnThreadMutex_Click);
            // 
            // tbThreadState
            // 
            this.tbThreadState.Location = new System.Drawing.Point(47, 59);
            this.tbThreadState.Multiline = true;
            this.tbThreadState.Name = "tbThreadState";
            this.tbThreadState.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbThreadState.Size = new System.Drawing.Size(239, 204);
            this.tbThreadState.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbThreadState);
            this.Controls.Add(this.btnThreadMutex);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThreadMutex;
        private System.Windows.Forms.TextBox tbThreadState;
    }
}

