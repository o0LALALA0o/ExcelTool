namespace excelTool
{
    partial class resultFrm
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
            this.button1 = new System.Windows.Forms.Button();
            this.msgLbl = new System.Windows.Forms.Label();
            this.resultTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "复制到剪切板";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // msgLbl
            // 
            this.msgLbl.AutoSize = true;
            this.msgLbl.Location = new System.Drawing.Point(172, 43);
            this.msgLbl.Name = "msgLbl";
            this.msgLbl.Size = new System.Drawing.Size(0, 12);
            this.msgLbl.TabIndex = 4;
            // 
            // resultTxt
            // 
            this.resultTxt.Location = new System.Drawing.Point(133, 69);
            this.resultTxt.Multiline = true;
            this.resultTxt.Name = "resultTxt";
            this.resultTxt.ReadOnly = true;
            this.resultTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resultTxt.Size = new System.Drawing.Size(191, 145);
            this.resultTxt.TabIndex = 3;
            this.resultTxt.TabStop = false;
            this.resultTxt.WordWrap = false;
            // 
            // resultFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 349);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.msgLbl);
            this.Controls.Add(this.resultTxt);
            this.Name = "resultFrm";
            this.Text = "结果";
            this.Load += new System.EventHandler(this.resultFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label msgLbl;
        private System.Windows.Forms.TextBox resultTxt;
    }
}