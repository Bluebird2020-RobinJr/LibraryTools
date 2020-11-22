namespace LibraryTools
{
    partial class Form1
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
            this.ButtonGenerate = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelBookName = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelResolution = new System.Windows.Forms.Label();
            this.labelOther = new System.Windows.Forms.Label();
            this.textBoxBookName = new System.Windows.Forms.TextBox();
            this.textBoxVersion = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxResolution = new System.Windows.Forms.TextBox();
            this.textBoxOther = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonGenerate
            // 
            this.ButtonGenerate.Location = new System.Drawing.Point(111, 238);
            this.ButtonGenerate.Name = "ButtonGenerate";
            this.ButtonGenerate.Size = new System.Drawing.Size(546, 32);
            this.ButtonGenerate.TabIndex = 0;
            this.ButtonGenerate.Text = "生成";
            this.ButtonGenerate.UseVisualStyleBackColor = true;
            this.ButtonGenerate.Click += new System.EventHandler(this.ButtonGenerate_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxResult.Location = new System.Drawing.Point(111, 285);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(546, 100);
            this.textBoxResult.TabIndex = 1;
            // 
            // labelBookName
            // 
            this.labelBookName.AutoSize = true;
            this.labelBookName.Location = new System.Drawing.Point(108, 31);
            this.labelBookName.Name = "labelBookName";
            this.labelBookName.Size = new System.Drawing.Size(67, 15);
            this.labelBookName.TabIndex = 2;
            this.labelBookName.Text = "书籍名称";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(108, 63);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(67, 15);
            this.labelVersion.TabIndex = 2;
            this.labelVersion.Text = "版本数字";
            this.labelVersion.Click += new System.EventHandler(this.labelVersion_Click);
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(108, 95);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(67, 15);
            this.labelAuthor.TabIndex = 2;
            this.labelAuthor.Text = "第一作者";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(108, 127);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(67, 15);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "出版日期";
            // 
            // labelResolution
            // 
            this.labelResolution.AutoSize = true;
            this.labelResolution.Location = new System.Drawing.Point(108, 159);
            this.labelResolution.Name = "labelResolution";
            this.labelResolution.Size = new System.Drawing.Size(52, 15);
            this.labelResolution.TabIndex = 2;
            this.labelResolution.Text = "清晰度";
            // 
            // labelOther
            // 
            this.labelOther.AutoSize = true;
            this.labelOther.Location = new System.Drawing.Point(108, 191);
            this.labelOther.Name = "labelOther";
            this.labelOther.Size = new System.Drawing.Size(37, 15);
            this.labelOther.TabIndex = 2;
            this.labelOther.Text = "其他";
            // 
            // textBoxBookName
            // 
            this.textBoxBookName.Location = new System.Drawing.Point(225, 20);
            this.textBoxBookName.Name = "textBoxBookName";
            this.textBoxBookName.Size = new System.Drawing.Size(432, 25);
            this.textBoxBookName.TabIndex = 3;
            // 
            // textBoxVersion
            // 
            this.textBoxVersion.Location = new System.Drawing.Point(225, 53);
            this.textBoxVersion.Name = "textBoxVersion";
            this.textBoxVersion.Size = new System.Drawing.Size(432, 25);
            this.textBoxVersion.TabIndex = 3;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(225, 86);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(432, 25);
            this.textBoxAuthor.TabIndex = 3;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(225, 119);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(432, 25);
            this.textBoxDate.TabIndex = 3;
            // 
            // textBoxResolution
            // 
            this.textBoxResolution.Location = new System.Drawing.Point(225, 152);
            this.textBoxResolution.Name = "textBoxResolution";
            this.textBoxResolution.Size = new System.Drawing.Size(432, 25);
            this.textBoxResolution.TabIndex = 3;
            // 
            // textBoxOther
            // 
            this.textBoxOther.Location = new System.Drawing.Point(225, 185);
            this.textBoxOther.Name = "textBoxOther";
            this.textBoxOther.Size = new System.Drawing.Size(432, 25);
            this.textBoxOther.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(663, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "英文版本加（EN）";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(410, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "清晰度：S 电子书 A 影印 B较清晰 C模糊 D拍照、非常差）";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxOther);
            this.Controls.Add(this.textBoxResolution);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.textBoxVersion);
            this.Controls.Add(this.textBoxBookName);
            this.Controls.Add(this.labelOther);
            this.Controls.Add(this.labelResolution);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelBookName);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.ButtonGenerate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonGenerate;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelBookName;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelResolution;
        private System.Windows.Forms.Label labelOther;
        private System.Windows.Forms.TextBox textBoxBookName;
        private System.Windows.Forms.TextBox textBoxVersion;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.TextBox textBoxResolution;
        private System.Windows.Forms.TextBox textBoxOther;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

