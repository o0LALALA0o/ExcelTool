namespace excelTool
{
    partial class main
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.radDifference = new System.Windows.Forms.RadioButton();
            this.radRepeat = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.compareBtn = new System.Windows.Forms.Button();
            this.dataTxt2 = new System.Windows.Forms.TextBox();
            this.dataTxt1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.distinctBtn = new System.Windows.Forms.Button();
            this.distinctTxt = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.matchingBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataTxt = new System.Windows.Forms.TextBox();
            this.matchingTxt = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-1, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1067, 564);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.radDifference);
            this.tabPage1.Controls.Add(this.radRepeat);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.compareBtn);
            this.tabPage1.Controls.Add(this.dataTxt2);
            this.tabPage1.Controls.Add(this.dataTxt1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1059, 535);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "对比数据";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // radDifference
            // 
            this.radDifference.AutoSize = true;
            this.radDifference.Location = new System.Drawing.Point(464, 348);
            this.radDifference.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radDifference.Name = "radDifference";
            this.radDifference.Size = new System.Drawing.Size(223, 19);
            this.radDifference.TabIndex = 7;
            this.radDifference.TabStop = true;
            this.radDifference.Text = "查找两组数据中的不重复数据";
            this.radDifference.UseVisualStyleBackColor = true;
            // 
            // radRepeat
            // 
            this.radRepeat.AutoSize = true;
            this.radRepeat.Checked = true;
            this.radRepeat.Location = new System.Drawing.Point(180, 348);
            this.radRepeat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radRepeat.Name = "radRepeat";
            this.radRepeat.Size = new System.Drawing.Size(208, 19);
            this.radRepeat.TabIndex = 6;
            this.radRepeat.TabStop = true;
            this.radRepeat.Text = "查找两组数据中的重复数据";
            this.radRepeat.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "数据二";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "数据一";
            // 
            // compareBtn
            // 
            this.compareBtn.Location = new System.Drawing.Point(367, 394);
            this.compareBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.compareBtn.Name = "compareBtn";
            this.compareBtn.Size = new System.Drawing.Size(104, 38);
            this.compareBtn.TabIndex = 4;
            this.compareBtn.Text = "确定";
            this.compareBtn.UseVisualStyleBackColor = true;
            this.compareBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataTxt2
            // 
            this.dataTxt2.Location = new System.Drawing.Point(489, 51);
            this.dataTxt2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataTxt2.Multiline = true;
            this.dataTxt2.Name = "dataTxt2";
            this.dataTxt2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.dataTxt2.Size = new System.Drawing.Size(189, 266);
            this.dataTxt2.TabIndex = 2;
            this.dataTxt2.WordWrap = false;
            // 
            // dataTxt1
            // 
            this.dataTxt1.Location = new System.Drawing.Point(180, 51);
            this.dataTxt1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataTxt1.Multiline = true;
            this.dataTxt1.Name = "dataTxt1";
            this.dataTxt1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.dataTxt1.Size = new System.Drawing.Size(200, 266);
            this.dataTxt1.TabIndex = 3;
            this.dataTxt1.WordWrap = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.distinctBtn);
            this.tabPage2.Controls.Add(this.distinctTxt);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1059, 535);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "去重";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "数据";
            // 
            // distinctBtn
            // 
            this.distinctBtn.Location = new System.Drawing.Point(347, 386);
            this.distinctBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.distinctBtn.Name = "distinctBtn";
            this.distinctBtn.Size = new System.Drawing.Size(104, 38);
            this.distinctBtn.TabIndex = 6;
            this.distinctBtn.Text = "去重";
            this.distinctBtn.UseVisualStyleBackColor = true;
            this.distinctBtn.Click += new System.EventHandler(this.distinctBtn_Click);
            // 
            // distinctTxt
            // 
            this.distinctTxt.Location = new System.Drawing.Point(303, 49);
            this.distinctTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.distinctTxt.Multiline = true;
            this.distinctTxt.Name = "distinctTxt";
            this.distinctTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.distinctTxt.Size = new System.Drawing.Size(251, 266);
            this.distinctTxt.TabIndex = 4;
            this.distinctTxt.WordWrap = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.matchingBtn);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.dataTxt);
            this.tabPage3.Controls.Add(this.matchingTxt);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1059, 535);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "匹配数据";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(451, 356);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "条件列";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(513, 352);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 23);
            this.comboBox1.TabIndex = 11;
            // 
            // matchingBtn
            // 
            this.matchingBtn.Location = new System.Drawing.Point(349, 405);
            this.matchingBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.matchingBtn.Name = "matchingBtn";
            this.matchingBtn.Size = new System.Drawing.Size(104, 38);
            this.matchingBtn.TabIndex = 10;
            this.matchingBtn.Text = "确定";
            this.matchingBtn.UseVisualStyleBackColor = true;
            this.matchingBtn.Click += new System.EventHandler(this.matchingBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(449, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "数据源";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "需要匹配的数据";
            // 
            // dataTxt
            // 
            this.dataTxt.Location = new System.Drawing.Point(452, 58);
            this.dataTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataTxt.Multiline = true;
            this.dataTxt.Name = "dataTxt";
            this.dataTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.dataTxt.Size = new System.Drawing.Size(221, 266);
            this.dataTxt.TabIndex = 6;
            this.dataTxt.WordWrap = false;
            this.dataTxt.TextChanged += new System.EventHandler(this.dataTxt_TextChanged);
            // 
            // matchingTxt
            // 
            this.matchingTxt.Location = new System.Drawing.Point(143, 58);
            this.matchingTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.matchingTxt.Multiline = true;
            this.matchingTxt.Name = "matchingTxt";
            this.matchingTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.matchingTxt.Size = new System.Drawing.Size(231, 266);
            this.matchingTxt.TabIndex = 7;
            this.matchingTxt.WordWrap = false;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 492);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "main";
            this.Text = "Excel小工具";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button compareBtn;
        private System.Windows.Forms.TextBox dataTxt2;
        private System.Windows.Forms.TextBox dataTxt1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radRepeat;
        private System.Windows.Forms.RadioButton radDifference;
        private System.Windows.Forms.TextBox distinctTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button distinctBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dataTxt;
        private System.Windows.Forms.TextBox matchingTxt;
        private System.Windows.Forms.Button matchingBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
    }
}