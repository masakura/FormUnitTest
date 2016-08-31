namespace TestDriver
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.addressSearchButton = new System.Windows.Forms.Button();
            this.addresSearchStubButton = new System.Windows.Forms.Button();
            this.listButton = new System.Windows.Forms.Button();
            this.detailButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addressSearchButton
            // 
            this.addressSearchButton.Location = new System.Drawing.Point(13, 13);
            this.addressSearchButton.Name = "addressSearchButton";
            this.addressSearchButton.Size = new System.Drawing.Size(139, 23);
            this.addressSearchButton.TabIndex = 0;
            this.addressSearchButton.Text = "住所検索";
            this.addressSearchButton.UseVisualStyleBackColor = true;
            this.addressSearchButton.Click += new System.EventHandler(this.addressSearchButton_Click);
            // 
            // addresSearchStubButton
            // 
            this.addresSearchStubButton.Location = new System.Drawing.Point(12, 42);
            this.addresSearchStubButton.Name = "addresSearchStubButton";
            this.addresSearchStubButton.Size = new System.Drawing.Size(139, 23);
            this.addresSearchStubButton.TabIndex = 0;
            this.addresSearchStubButton.Text = "住所検索 (スタブ)";
            this.addresSearchStubButton.UseVisualStyleBackColor = true;
            this.addresSearchStubButton.Click += new System.EventHandler(this.addresSearchStubButton_Click);
            // 
            // listButton
            // 
            this.listButton.Location = new System.Drawing.Point(13, 71);
            this.listButton.Name = "listButton";
            this.listButton.Size = new System.Drawing.Size(139, 23);
            this.listButton.TabIndex = 0;
            this.listButton.Text = "一覧";
            this.listButton.UseVisualStyleBackColor = true;
            this.listButton.Click += new System.EventHandler(this.listButton_Click);
            // 
            // detailButton
            // 
            this.detailButton.Location = new System.Drawing.Point(12, 100);
            this.detailButton.Name = "detailButton";
            this.detailButton.Size = new System.Drawing.Size(139, 23);
            this.detailButton.TabIndex = 0;
            this.detailButton.Text = "詳細";
            this.detailButton.UseVisualStyleBackColor = true;
            this.detailButton.Click += new System.EventHandler(this.detailButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(223, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 122);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "これはテストドライバー\r\n\r\nテストしたい画面を呼び出すボタンを並べておく";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(396, 261);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.detailButton);
            this.Controls.Add(this.listButton);
            this.Controls.Add(this.addresSearchStubButton);
            this.Controls.Add(this.addressSearchButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addressSearchButton;
        private System.Windows.Forms.Button addresSearchStubButton;
        private System.Windows.Forms.Button listButton;
        private System.Windows.Forms.Button detailButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}

