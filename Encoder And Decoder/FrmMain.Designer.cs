namespace Encoder_And_Decoder
{
    partial class FrmMain
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabMain = new System.Windows.Forms.TabControl();
            this.Url = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbDecode = new System.Windows.Forms.RadioButton();
            this.rdbEncode = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Unicode = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkKeepSpace = new System.Windows.Forms.CheckBox();
            this.rdb2Chinese = new System.Windows.Forms.RadioButton();
            this.rdb2Unicode = new System.Windows.Forms.RadioButton();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.chkEnChar = new System.Windows.Forms.CheckBox();
            this.tabMain.SuspendLayout();
            this.Url.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Unicode.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.Url);
            this.tabMain.Controls.Add(this.Unicode);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(637, 425);
            this.tabMain.TabIndex = 0;
            // 
            // Url
            // 
            this.Url.Controls.Add(this.panel1);
            this.Url.Controls.Add(this.textBox2);
            this.Url.Controls.Add(this.textBox1);
            this.Url.Location = new System.Drawing.Point(4, 29);
            this.Url.Name = "Url";
            this.Url.Padding = new System.Windows.Forms.Padding(3);
            this.Url.Size = new System.Drawing.Size(629, 392);
            this.Url.TabIndex = 0;
            this.Url.Text = "Url编码解码";
            this.Url.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.rdbDecode);
            this.panel1.Controls.Add(this.rdbEncode);
            this.panel1.Location = new System.Drawing.Point(9, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 36);
            this.panel1.TabIndex = 5;
            // 
            // rdbDecode
            // 
            this.rdbDecode.AutoSize = true;
            this.rdbDecode.Location = new System.Drawing.Point(64, 5);
            this.rdbDecode.Name = "rdbDecode";
            this.rdbDecode.Size = new System.Drawing.Size(55, 24);
            this.rdbDecode.TabIndex = 4;
            this.rdbDecode.Text = "解码";
            this.rdbDecode.UseVisualStyleBackColor = true;
            // 
            // rdbEncode
            // 
            this.rdbEncode.AutoSize = true;
            this.rdbEncode.Checked = true;
            this.rdbEncode.Location = new System.Drawing.Point(3, 5);
            this.rdbEncode.Name = "rdbEncode";
            this.rdbEncode.Size = new System.Drawing.Size(55, 24);
            this.rdbEncode.TabIndex = 3;
            this.rdbEncode.TabStop = true;
            this.rdbEncode.Text = "编码";
            this.rdbEncode.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(9, 208);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(612, 176);
            this.textBox2.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(9, 7);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(612, 152);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Unicode
            // 
            this.Unicode.Controls.Add(this.panel2);
            this.Unicode.Controls.Add(this.textBox4);
            this.Unicode.Controls.Add(this.textBox3);
            this.Unicode.Location = new System.Drawing.Point(4, 29);
            this.Unicode.Name = "Unicode";
            this.Unicode.Padding = new System.Windows.Forms.Padding(3);
            this.Unicode.Size = new System.Drawing.Size(629, 392);
            this.Unicode.TabIndex = 1;
            this.Unicode.Text = "Unicode编码";
            this.Unicode.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.chkEnChar);
            this.panel2.Controls.Add(this.chkKeepSpace);
            this.panel2.Controls.Add(this.rdb2Chinese);
            this.panel2.Controls.Add(this.rdb2Unicode);
            this.panel2.Location = new System.Drawing.Point(8, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(612, 60);
            this.panel2.TabIndex = 8;
            // 
            // chkKeepSpace
            // 
            this.chkKeepSpace.AutoSize = true;
            this.chkKeepSpace.Enabled = false;
            this.chkKeepSpace.Location = new System.Drawing.Point(375, 6);
            this.chkKeepSpace.Name = "chkKeepSpace";
            this.chkKeepSpace.Size = new System.Drawing.Size(234, 24);
            this.chkKeepSpace.TabIndex = 5;
            this.chkKeepSpace.Text = "保留首尾空格(编码成Unicode时)";
            this.chkKeepSpace.UseVisualStyleBackColor = true;
            // 
            // rdb2Chinese
            // 
            this.rdb2Chinese.AutoSize = true;
            this.rdb2Chinese.Checked = true;
            this.rdb2Chinese.Location = new System.Drawing.Point(12, 29);
            this.rdb2Chinese.Name = "rdb2Chinese";
            this.rdb2Chinese.Size = new System.Drawing.Size(125, 24);
            this.rdb2Chinese.TabIndex = 4;
            this.rdb2Chinese.TabStop = true;
            this.rdb2Chinese.Text = "从Unicode解码";
            this.rdb2Chinese.UseVisualStyleBackColor = true;
            // 
            // rdb2Unicode
            // 
            this.rdb2Unicode.AutoSize = true;
            this.rdb2Unicode.Location = new System.Drawing.Point(12, 5);
            this.rdb2Unicode.Name = "rdb2Unicode";
            this.rdb2Unicode.Size = new System.Drawing.Size(125, 24);
            this.rdb2Unicode.TabIndex = 3;
            this.rdb2Unicode.Text = "编码成Unicode";
            this.rdb2Unicode.UseVisualStyleBackColor = true;
            this.rdb2Unicode.CheckedChanged += new System.EventHandler(this.rdb2Unicode_CheckedChanged);
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Location = new System.Drawing.Point(8, 213);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox4.Size = new System.Drawing.Size(612, 172);
            this.textBox4.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(8, 8);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(612, 145);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // chkEnChar
            // 
            this.chkEnChar.AutoSize = true;
            this.chkEnChar.Checked = true;
            this.chkEnChar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnChar.Enabled = false;
            this.chkEnChar.Location = new System.Drawing.Point(375, 30);
            this.chkEnChar.Name = "chkEnChar";
            this.chkEnChar.Size = new System.Drawing.Size(112, 24);
            this.chkEnChar.TabIndex = 6;
            this.chkEnChar.Text = "保留英文字母";
            this.chkEnChar.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 425);
            this.Controls.Add(this.tabMain);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "编码解码";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tabMain.ResumeLayout(false);
            this.Url.ResumeLayout(false);
            this.Url.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Unicode.ResumeLayout(false);
            this.Unicode.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage Url;
        private System.Windows.Forms.RadioButton rdbDecode;
        private System.Windows.Forms.RadioButton rdbEncode;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage Unicode;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdb2Chinese;
        private System.Windows.Forms.RadioButton rdb2Unicode;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox chkKeepSpace;
        private System.Windows.Forms.CheckBox chkEnChar;
    }
}

