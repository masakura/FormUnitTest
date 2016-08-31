namespace App1.Sub1
{
    partial class ItemForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.postalCodeInput = new System.Windows.Forms.TextBox();
            this.prefectureInput = new System.Windows.Forms.TextBox();
            this.cityInput = new System.Windows.Forms.TextBox();
            this.townInput = new System.Windows.Forms.TextBox();
            this.addressSearchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.addressInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 19);
            this.textBox1.TabIndex = 0;
            // 
            // postalCodeInput
            // 
            this.postalCodeInput.Location = new System.Drawing.Point(140, 38);
            this.postalCodeInput.Name = "postalCodeInput";
            this.postalCodeInput.Size = new System.Drawing.Size(100, 19);
            this.postalCodeInput.TabIndex = 0;
            // 
            // prefectureInput
            // 
            this.prefectureInput.Location = new System.Drawing.Point(140, 63);
            this.prefectureInput.Name = "prefectureInput";
            this.prefectureInput.Size = new System.Drawing.Size(100, 19);
            this.prefectureInput.TabIndex = 1;
            // 
            // cityInput
            // 
            this.cityInput.Location = new System.Drawing.Point(140, 88);
            this.cityInput.Name = "cityInput";
            this.cityInput.Size = new System.Drawing.Size(100, 19);
            this.cityInput.TabIndex = 1;
            // 
            // townInput
            // 
            this.townInput.Location = new System.Drawing.Point(140, 113);
            this.townInput.Name = "townInput";
            this.townInput.Size = new System.Drawing.Size(100, 19);
            this.townInput.TabIndex = 1;
            // 
            // addressSearchButton
            // 
            this.addressSearchButton.Location = new System.Drawing.Point(246, 34);
            this.addressSearchButton.Name = "addressSearchButton";
            this.addressSearchButton.Size = new System.Drawing.Size(75, 23);
            this.addressSearchButton.TabIndex = 2;
            this.addressSearchButton.Text = "住所検索";
            this.addressSearchButton.UseVisualStyleBackColor = true;
            this.addressSearchButton.Click += new System.EventHandler(this.addressSearchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "氏名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "郵便番号:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "都道府県:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "市町村:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "町名:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(179, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "保存";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Location = new System.Drawing.Point(260, 163);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "キャンセル";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // addressInput
            // 
            this.addressInput.Location = new System.Drawing.Point(140, 138);
            this.addressInput.Name = "addressInput";
            this.addressInput.Size = new System.Drawing.Size(100, 19);
            this.addressInput.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "残りの住所:";
            // 
            // ItemForm
            // 
            this.AcceptButton = this.button2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button3;
            this.ClientSize = new System.Drawing.Size(345, 199);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addressSearchButton);
            this.Controls.Add(this.addressInput);
            this.Controls.Add(this.townInput);
            this.Controls.Add(this.cityInput);
            this.Controls.Add(this.prefectureInput);
            this.Controls.Add(this.postalCodeInput);
            this.Controls.Add(this.textBox1);
            this.Name = "ItemForm";
            this.Text = "詳細";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox postalCodeInput;
        private System.Windows.Forms.TextBox prefectureInput;
        private System.Windows.Forms.TextBox cityInput;
        private System.Windows.Forms.TextBox townInput;
        private System.Windows.Forms.Button addressSearchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox addressInput;
        private System.Windows.Forms.Label label6;
    }
}