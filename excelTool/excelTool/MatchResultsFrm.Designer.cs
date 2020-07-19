namespace excelTool
{
    partial class MatchResultsFrm
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
            this.yBtn = new System.Windows.Forms.Button();
            this.yTxt = new System.Windows.Forms.TextBox();
            this.nTxt = new System.Windows.Forms.TextBox();
            this.nBtn = new System.Windows.Forms.Button();
            this.yLbl = new System.Windows.Forms.Label();
            this.nLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.msgLbl = new System.Windows.Forms.Label();
            this.resultTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yBtn
            // 
            this.yBtn.Location = new System.Drawing.Point(163, 459);
            this.yBtn.Name = "yBtn";
            this.yBtn.Size = new System.Drawing.Size(106, 23);
            this.yBtn.TabIndex = 8;
            this.yBtn.Text = "复制到剪切板";
            this.yBtn.UseVisualStyleBackColor = true;
            this.yBtn.Click += new System.EventHandler(this.yBtn_Click);
            // 
            // yTxt
            // 
            this.yTxt.Location = new System.Drawing.Point(123, 293);
            this.yTxt.Multiline = true;
            this.yTxt.Name = "yTxt";
            this.yTxt.ReadOnly = true;
            this.yTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.yTxt.Size = new System.Drawing.Size(191, 160);
            this.yTxt.TabIndex = 6;
            this.yTxt.TabStop = false;
            this.yTxt.WordWrap = false;
            // 
            // nTxt
            // 
            this.nTxt.Location = new System.Drawing.Point(368, 293);
            this.nTxt.Multiline = true;
            this.nTxt.Name = "nTxt";
            this.nTxt.ReadOnly = true;
            this.nTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.nTxt.Size = new System.Drawing.Size(191, 160);
            this.nTxt.TabIndex = 6;
            this.nTxt.TabStop = false;
            this.nTxt.WordWrap = false;
            // 
            // nBtn
            // 
            this.nBtn.Location = new System.Drawing.Point(410, 459);
            this.nBtn.Name = "nBtn";
            this.nBtn.Size = new System.Drawing.Size(106, 23);
            this.nBtn.TabIndex = 8;
            this.nBtn.Text = "复制到剪切板";
            this.nBtn.UseVisualStyleBackColor = true;
            this.nBtn.Click += new System.EventHandler(this.nBtn_Click);
            // 
            // yLbl
            // 
            this.yLbl.AutoSize = true;
            this.yLbl.Location = new System.Drawing.Point(121, 263);
            this.yLbl.Name = "yLbl";
            this.yLbl.Size = new System.Drawing.Size(0, 12);
            this.yLbl.TabIndex = 9;
            // 
            // nLbl
            // 
            this.nLbl.AutoSize = true;
            this.nLbl.Location = new System.Drawing.Point(366, 263);
            this.nLbl.Name = "nLbl";
            this.nLbl.Size = new System.Drawing.Size(0, 12);
            this.nLbl.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "复制到剪切板";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // msgLbl
            // 
            this.msgLbl.AutoSize = true;
            this.msgLbl.Location = new System.Drawing.Point(121, 9);
            this.msgLbl.Name = "msgLbl";
            this.msgLbl.Size = new System.Drawing.Size(0, 12);
            this.msgLbl.TabIndex = 11;
            // 
            // resultTxt
            // 
            this.resultTxt.Location = new System.Drawing.Point(123, 37);
            this.resultTxt.Multiline = true;
            this.resultTxt.Name = "resultTxt";
            this.resultTxt.ReadOnly = true;
            this.resultTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resultTxt.Size = new System.Drawing.Size(436, 153);
            this.resultTxt.TabIndex = 10;
            this.resultTxt.TabStop = false;
            this.resultTxt.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "详情";
            // 
            // MatchResultsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 510);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.msgLbl);
            this.Controls.Add(this.resultTxt);
            this.Controls.Add(this.nLbl);
            this.Controls.Add(this.yLbl);
            this.Controls.Add(this.nBtn);
            this.Controls.Add(this.yBtn);
            this.Controls.Add(this.nTxt);
            this.Controls.Add(this.yTxt);
            this.Name = "MatchResultsFrm";
            this.Text = "匹配结果";
            this.Load += new System.EventHandler(this.MatchResultsFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button yBtn;
        private System.Windows.Forms.TextBox yTxt;
        private System.Windows.Forms.TextBox nTxt;
        private System.Windows.Forms.Button nBtn;
        private System.Windows.Forms.Label yLbl;
        private System.Windows.Forms.Label nLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label msgLbl;
        private System.Windows.Forms.TextBox resultTxt;
        private System.Windows.Forms.Label label1;
    }
}