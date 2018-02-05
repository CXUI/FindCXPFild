namespace ReadCXP
{
    partial class Main
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
            this.textURL = new System.Windows.Forms.TextBox();
            this.url = new System.Windows.Forms.Label();
            this.DetermineButton = new System.Windows.Forms.Button();
            this.testtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GetInformation1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GetInformation2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GetInformation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textURL
            // 
            this.textURL.Location = new System.Drawing.Point(87, 130);
            this.textURL.Name = "textURL";
            this.textURL.Size = new System.Drawing.Size(465, 21);
            this.textURL.TabIndex = 0;
            this.textURL.TextChanged += new System.EventHandler(this.textURL_TextChanged);
            // 
            // url
            // 
            this.url.AutoSize = true;
            this.url.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.url.Location = new System.Drawing.Point(12, 130);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(58, 24);
            this.url.TabIndex = 1;
            this.url.Text = "路径";
            // 
            // DetermineButton
            // 
            this.DetermineButton.Location = new System.Drawing.Point(228, 296);
            this.DetermineButton.Name = "DetermineButton";
            this.DetermineButton.Size = new System.Drawing.Size(134, 54);
            this.DetermineButton.TabIndex = 2;
            this.DetermineButton.Text = "确定";
            this.DetermineButton.UseVisualStyleBackColor = true;
            this.DetermineButton.Click += new System.EventHandler(this.DetermineButton_Click);
            // 
            // testtextBox
            // 
            this.testtextBox.Location = new System.Drawing.Point(75, 382);
            this.testtextBox.Multiline = true;
            this.testtextBox.Name = "testtextBox";
            this.testtextBox.Size = new System.Drawing.Size(477, 151);
            this.testtextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "获取信息1";
            // 
            // GetInformation1
            // 
            this.GetInformation1.Location = new System.Drawing.Point(88, 184);
            this.GetInformation1.Name = "GetInformation1";
            this.GetInformation1.Size = new System.Drawing.Size(91, 21);
            this.GetInformation1.TabIndex = 6;
            this.GetInformation1.TextChanged += new System.EventHandler(this.GetInformation1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "获取信息2";
            // 
            // GetInformation2
            // 
            this.GetInformation2.Location = new System.Drawing.Point(252, 183);
            this.GetInformation2.Name = "GetInformation2";
            this.GetInformation2.Size = new System.Drawing.Size(100, 21);
            this.GetInformation2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "获取信息3";
            // 
            // GetInformation
            // 
            this.GetInformation.Location = new System.Drawing.Point(425, 184);
            this.GetInformation.Name = "GetInformation";
            this.GetInformation.Size = new System.Drawing.Size(100, 21);
            this.GetInformation.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(531, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "获取信息4";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(597, 184);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "生成txt名字(必须是英文)";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(164, 237);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 21);
            this.textName.TabIndex = 14;
            this.textName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 552);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GetInformation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GetInformation2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GetInformation1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.testtextBox);
            this.Controls.Add(this.DetermineButton);
            this.Controls.Add(this.url);
            this.Controls.Add(this.textURL);
            this.Name = "Main";
            this.Text = "主要页面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textURL;
        private System.Windows.Forms.Label url;
        private System.Windows.Forms.Button DetermineButton;
        private System.Windows.Forms.TextBox testtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GetInformation1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox GetInformation2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GetInformation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textName;
    }
}

