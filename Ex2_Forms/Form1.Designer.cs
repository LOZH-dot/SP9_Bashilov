namespace Ex2_Forms {
	partial class Form1 {
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent() {
			this.label1 = new System.Windows.Forms.Label();
			this.NumberTextBox = new System.Windows.Forms.TextBox();
			this.ResultButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(117, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Введите целое число:";
			// 
			// NumberTextBox
			// 
			this.NumberTextBox.Location = new System.Drawing.Point(135, 6);
			this.NumberTextBox.Name = "NumberTextBox";
			this.NumberTextBox.Size = new System.Drawing.Size(100, 20);
			this.NumberTextBox.TabIndex = 1;
			// 
			// ResultButton
			// 
			this.ResultButton.Location = new System.Drawing.Point(15, 38);
			this.ResultButton.Name = "ResultButton";
			this.ResultButton.Size = new System.Drawing.Size(75, 23);
			this.ResultButton.TabIndex = 2;
			this.ResultButton.Text = "Результат";
			this.ResultButton.UseVisualStyleBackColor = true;
			this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(265, 78);
			this.Controls.Add(this.ResultButton);
			this.Controls.Add(this.NumberTextBox);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox NumberTextBox;
		private System.Windows.Forms.Button ResultButton;
	}
}

