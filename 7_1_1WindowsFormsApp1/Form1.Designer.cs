namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.ckbSoon = new System.Windows.Forms.CheckBox();
            this.ckbPasta = new System.Windows.Forms.CheckBox();
            this.ckbSteak = new System.Windows.Forms.CheckBox();
            this.ckbTang = new System.Windows.Forms.CheckBox();
            this.btnEvent = new System.Windows.Forms.Button();
            this.radioAgree = new System.Windows.Forms.RadioButton();
            this.radioDisagree = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbArea = new System.Windows.Forms.ListBox();
            this.cbPay = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "주문하세요.";
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Location = new System.Drawing.Point(561, 65);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(121, 12);
            this.lblOrder.TabIndex = 2;
            this.lblOrder.Text = "텍스트를 출력합니다.";
            // 
            // ckbSoon
            // 
            this.ckbSoon.AutoSize = true;
            this.ckbSoon.Location = new System.Drawing.Point(33, 61);
            this.ckbSoon.Name = "ckbSoon";
            this.ckbSoon.Size = new System.Drawing.Size(60, 16);
            this.ckbSoon.TabIndex = 3;
            this.ckbSoon.Text = "순댓국";
            this.ckbSoon.UseVisualStyleBackColor = true;
            // 
            // ckbPasta
            // 
            this.ckbPasta.AutoSize = true;
            this.ckbPasta.Location = new System.Drawing.Point(192, 61);
            this.ckbPasta.Name = "ckbPasta";
            this.ckbPasta.Size = new System.Drawing.Size(60, 16);
            this.ckbPasta.TabIndex = 4;
            this.ckbPasta.Text = "파스타";
            this.ckbPasta.UseVisualStyleBackColor = true;
            // 
            // ckbSteak
            // 
            this.ckbSteak.AutoSize = true;
            this.ckbSteak.Location = new System.Drawing.Point(316, 61);
            this.ckbSteak.Name = "ckbSteak";
            this.ckbSteak.Size = new System.Drawing.Size(72, 16);
            this.ckbSteak.TabIndex = 5;
            this.ckbSteak.Text = "스테이크";
            this.ckbSteak.UseVisualStyleBackColor = true;
            // 
            // ckbTang
            // 
            this.ckbTang.AutoSize = true;
            this.ckbTang.Location = new System.Drawing.Point(434, 61);
            this.ckbTang.Name = "ckbTang";
            this.ckbTang.Size = new System.Drawing.Size(60, 16);
            this.ckbTang.TabIndex = 6;
            this.ckbTang.Text = "탕수육";
            this.ckbTang.UseVisualStyleBackColor = true;
            // 
            // btnEvent
            // 
            this.btnEvent.Location = new System.Drawing.Point(60, 95);
            this.btnEvent.Name = "btnEvent";
            this.btnEvent.Size = new System.Drawing.Size(434, 37);
            this.btnEvent.TabIndex = 7;
            this.btnEvent.Text = "주문";
            this.btnEvent.UseVisualStyleBackColor = true;
            this.btnEvent.Click += new System.EventHandler(this.btnEvent_Click_1);
            // 
            // radioAgree
            // 
            this.radioAgree.AutoSize = true;
            this.radioAgree.Location = new System.Drawing.Point(27, 45);
            this.radioAgree.Name = "radioAgree";
            this.radioAgree.Size = new System.Drawing.Size(47, 16);
            this.radioAgree.TabIndex = 8;
            this.radioAgree.TabStop = true;
            this.radioAgree.Text = "동의";
            this.radioAgree.UseVisualStyleBackColor = true;
            // 
            // radioDisagree
            // 
            this.radioDisagree.AutoSize = true;
            this.radioDisagree.Location = new System.Drawing.Point(251, 45);
            this.radioDisagree.Name = "radioDisagree";
            this.radioDisagree.Size = new System.Drawing.Size(71, 16);
            this.radioDisagree.TabIndex = 9;
            this.radioDisagree.TabStop = true;
            this.radioDisagree.Text = "동의안함";
            this.radioDisagree.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEnter);
            this.groupBox1.Controls.Add(this.radioAgree);
            this.groupBox1.Controls.Add(this.radioDisagree);
            this.groupBox1.Location = new System.Drawing.Point(33, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "개인정보동의";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(401, 45);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 10;
            this.btnEnter.Text = "응모";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(29, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(448, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "이벤트에 응모하려면 개인정보 동의해주세";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "주문 시 요구사항";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(419, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "접수";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnReceipt_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 322);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(309, 21);
            this.textBox1.TabIndex = 14;
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(419, 405);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(108, 53);
            this.btnPay.TabIndex = 15;
            this.btnPay.Text = "결제";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(40, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "결제방법";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(218, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 22);
            this.label5.TabIndex = 19;
            this.label5.Text = "결제 정보";
            // 
            // lbArea
            // 
            this.lbArea.FormattingEnabled = true;
            this.lbArea.ItemHeight = 12;
            this.lbArea.Items.AddRange(new object[] {
            "일시불",
            "3개월 할부",
            "6개월 할부"});
            this.lbArea.Location = new System.Drawing.Point(222, 405);
            this.lbArea.Name = "lbArea";
            this.lbArea.Size = new System.Drawing.Size(120, 88);
            this.lbArea.TabIndex = 20;
            // 
            // cbPay
            // 
            this.cbPay.FormattingEnabled = true;
            this.cbPay.Items.AddRange(new object[] {
            "신용카드",
            "무통장입금",
            "포인트",
            "현금"});
            this.cbPay.Location = new System.Drawing.Point(44, 405);
            this.cbPay.Name = "cbPay";
            this.cbPay.Size = new System.Drawing.Size(121, 20);
            this.cbPay.TabIndex = 21;
            this.cbPay.Text = "신용카드";
            this.cbPay.SelectedIndexChanged += new System.EventHandler(this.CbPay_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 626);
            this.Controls.Add(this.cbPay);
            this.Controls.Add(this.lbArea);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEvent);
            this.Controls.Add(this.ckbTang);
            this.Controls.Add(this.ckbSteak);
            this.Controls.Add(this.ckbPasta);
            this.Controls.Add(this.ckbSoon);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.CheckBox ckbSoon;
        private System.Windows.Forms.CheckBox ckbPasta;
        private System.Windows.Forms.CheckBox ckbSteak;
        private System.Windows.Forms.CheckBox ckbTang;
        private System.Windows.Forms.Button btnEvent;
        private System.Windows.Forms.RadioButton radioAgree;
        private System.Windows.Forms.RadioButton radioDisagree;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbArea;
        private System.Windows.Forms.ComboBox cbPay;
    }
}

