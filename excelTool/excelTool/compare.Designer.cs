namespace excelTool
{
    partial class Excel小工具
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataTxt1 = new System.Windows.Forms.TextBox();
            this.dataTxt2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dataTxt1
            // 
            this.dataTxt1.Location = new System.Drawing.Point(148, 39);
            this.dataTxt1.Margin = new System.Windows.Forms.Padding(2);
            this.dataTxt1.Multiline = true;
            this.dataTxt1.Name = "dataTxt1";
            this.dataTxt1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataTxt1.Size = new System.Drawing.Size(106, 171);
            this.dataTxt1.TabIndex = 0;
            this.dataTxt1.TextChanged += new System.EventHandler(this.dataTxt1_TextChanged);
            // 
            // dataTxt2
            // 
            this.dataTxt2.Location = new System.Drawing.Point(327, 39);
            this.dataTxt2.Margin = new System.Windows.Forms.Padding(2);
            this.dataTxt2.Multiline = true;
            this.dataTxt2.Name = "dataTxt2";
            this.dataTxt2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataTxt2.Size = new System.Drawing.Size(106, 171);
            this.dataTxt2.TabIndex = 0;
            this.dataTxt2.TextChanged += new System.EventHandler(this.dataTxt2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 301);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Excel小工具
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 410);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataTxt2);
            this.Controls.Add(this.dataTxt1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Excel小工具";
            this.Text = "Excel小工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dataTxt1;
        private System.Windows.Forms.TextBox dataTxt2;
        private System.Windows.Forms.Button button1;
    }
}

