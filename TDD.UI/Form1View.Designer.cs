namespace TDD.UI
{
    partial class Form1View
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.CalculationButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label_operator = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CalculationButton
            // 
            this.CalculationButton.Location = new System.Drawing.Point(72, 112);
            this.CalculationButton.Name = "CalculationButton";
            this.CalculationButton.Size = new System.Drawing.Size(112, 31);
            this.CalculationButton.TabIndex = 0;
            this.CalculationButton.Text = "計算";
            this.CalculationButton.UseVisualStyleBackColor = true;
            this.CalculationButton.Click += new System.EventHandler(this.CalculationButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 19);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(169, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 19);
            this.textBox2.TabIndex = 2;
            // 
            // label_operator
            // 
            this.label_operator.AutoSize = true;
            this.label_operator.Location = new System.Drawing.Point(146, 51);
            this.label_operator.Name = "label_operator";
            this.label_operator.Size = new System.Drawing.Size(11, 12);
            this.label_operator.TabIndex = 3;
            this.label_operator.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "=";
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Location = new System.Drawing.Point(305, 50);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(26, 12);
            this.label_result.TabIndex = 5;
            this.label_result.Text = "XXX";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 184);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_operator);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CalculationButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculationButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label_operator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_result;
    }
}

