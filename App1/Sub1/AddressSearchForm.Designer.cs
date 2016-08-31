namespace App1.Sub1
{
    partial class AddressSearchForm
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
            this.input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.postalCodeInput = new System.Windows.Forms.TextBox();
            this.prefectureInput = new System.Windows.Forms.TextBox();
            this.cityInput = new System.Windows.Forms.TextBox();
            this.townInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(73, 12);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(121, 19);
            this.input.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "郵便番号:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "検索";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // postalCodeInput
            // 
            this.postalCodeInput.Location = new System.Drawing.Point(162, 79);
            this.postalCodeInput.Name = "postalCodeInput";
            this.postalCodeInput.ReadOnly = true;
            this.postalCodeInput.Size = new System.Drawing.Size(100, 19);
            this.postalCodeInput.TabIndex = 0;
            // 
            // prefectureInput
            // 
            this.prefectureInput.Location = new System.Drawing.Point(162, 104);
            this.prefectureInput.Name = "prefectureInput";
            this.prefectureInput.ReadOnly = true;
            this.prefectureInput.Size = new System.Drawing.Size(100, 19);
            this.prefectureInput.TabIndex = 1;
            // 
            // cityInput
            // 
            this.cityInput.Location = new System.Drawing.Point(162, 129);
            this.cityInput.Name = "cityInput";
            this.cityInput.ReadOnly = true;
            this.cityInput.Size = new System.Drawing.Size(100, 19);
            this.cityInput.TabIndex = 1;
            // 
            // townInput
            // 
            this.townInput.Location = new System.Drawing.Point(162, 154);
            this.townInput.Name = "townInput";
            this.townInput.ReadOnly = true;
            this.townInput.Size = new System.Drawing.Size(100, 19);
            this.townInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "郵便番号:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "都道府県:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "市町村:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "町名:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(334, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Location = new System.Drawing.Point(415, 242);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // AddressSearchForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button3;
            this.ClientSize = new System.Drawing.Size(502, 277);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.postalCodeInput);
            this.Controls.Add(this.prefectureInput);
            this.Controls.Add(this.cityInput);
            this.Controls.Add(this.townInput);
            this.Name = "AddressSearchForm";
            this.Text = "住所検索";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox postalCodeInput;
        private System.Windows.Forms.TextBox prefectureInput;
        private System.Windows.Forms.TextBox cityInput;
        private System.Windows.Forms.TextBox townInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}