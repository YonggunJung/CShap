﻿namespace YutNori
{
    partial class Board
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
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnYut = new System.Windows.Forms.Button();
            this.lblYut = new System.Windows.Forms.Label();
            this.lblGo = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(758, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "-1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.MoveTest);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(758, 143);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.MoveTest);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(758, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.MoveTest);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(758, 163);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "3";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.MoveTest);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(758, 182);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "4";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.MoveTest);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(758, 201);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 0;
            this.button6.Text = "5";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.MoveTest);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnYut
            // 
            this.btnYut.Location = new System.Drawing.Point(886, 235);
            this.btnYut.Name = "btnYut";
            this.btnYut.Size = new System.Drawing.Size(75, 23);
            this.btnYut.TabIndex = 1;
            this.btnYut.Text = "던지기";
            this.btnYut.UseVisualStyleBackColor = true;
            this.btnYut.Click += new System.EventHandler(this.btnYut_Click);
            // 
            // lblYut
            // 
            this.lblYut.AutoSize = true;
            this.lblYut.Location = new System.Drawing.Point(852, 112);
            this.lblYut.Name = "lblYut";
            this.lblYut.Size = new System.Drawing.Size(141, 12);
            this.lblYut.TabIndex = 2;
            this.lblYut.Text = "[000] [000] [000] [000] ";
            // 
            // lblGo
            // 
            this.lblGo.AutoSize = true;
            this.lblGo.Location = new System.Drawing.Point(901, 148);
            this.lblGo.Name = "lblGo";
            this.lblGo.Size = new System.Drawing.Size(17, 12);
            this.lblGo.TabIndex = 3;
            this.lblGo.Text = "모";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(901, 182);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(35, 12);
            this.lblPlayer.TabIndex = 4;
            this.lblPlayer.Text = "유저1";
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 700);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblGo);
            this.Controls.Add(this.lblYut);
            this.Controls.Add(this.btnYut);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Name = "Board";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnYut;
        private System.Windows.Forms.Label lblYut;
        private System.Windows.Forms.Label lblGo;
        private System.Windows.Forms.Label lblPlayer;
    }
}

