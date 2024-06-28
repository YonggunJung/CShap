namespace BlueMarble
{
    partial class Turn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnDice2 = new System.Windows.Forms.Button();
            this.btnDice1 = new System.Windows.Forms.Button();
            this.btnThrow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMooInDo = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblPlayer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDice2
            // 
            this.btnDice2.Location = new System.Drawing.Point(197, 125);
            this.btnDice2.Name = "btnDice2";
            this.btnDice2.Size = new System.Drawing.Size(75, 68);
            this.btnDice2.TabIndex = 1;
            this.btnDice2.Text = "5";
            this.btnDice2.UseVisualStyleBackColor = true;
            // 
            // btnDice1
            // 
            this.btnDice1.Location = new System.Drawing.Point(96, 125);
            this.btnDice1.Name = "btnDice1";
            this.btnDice1.Size = new System.Drawing.Size(75, 68);
            this.btnDice1.TabIndex = 2;
            this.btnDice1.Text = "1";
            this.btnDice1.UseVisualStyleBackColor = true;
            // 
            // btnThrow
            // 
            this.btnThrow.Location = new System.Drawing.Point(123, 236);
            this.btnThrow.Name = "btnThrow";
            this.btnThrow.Size = new System.Drawing.Size(113, 51);
            this.btnThrow.TabIndex = 3;
            this.btnThrow.Text = "주사위 던지기";
            this.btnThrow.UseVisualStyleBackColor = true;
            this.btnThrow.Click += new System.EventHandler(this.btnThrow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "무인도";
            // 
            // lblMooInDo
            // 
            this.lblMooInDo.AutoSize = true;
            this.lblMooInDo.Location = new System.Drawing.Point(306, 32);
            this.lblMooInDo.Name = "lblMooInDo";
            this.lblMooInDo.Size = new System.Drawing.Size(29, 12);
            this.lblMooInDo.TabIndex = 5;
            this.lblMooInDo.Text = "아님";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(163, 88);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(35, 12);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "더블?";
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(43, 32);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(99, 25);
            this.lblPlayer.TabIndex = 6;
            this.lblPlayer.Text = "플레이어X";
            // 
            // Turn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 310);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblMooInDo);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThrow);
            this.Controls.Add(this.btnDice2);
            this.Controls.Add(this.btnDice1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Turn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turn";
            this.Load += new System.EventHandler(this.Turn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDice2;
        private System.Windows.Forms.Button btnDice1;
        private System.Windows.Forms.Button btnThrow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMooInDo;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblPlayer;
    }
}