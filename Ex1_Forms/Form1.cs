using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Ex1_Forms {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void ResultButton_Click(object sender, EventArgs e) {
			string[] strs = NumberTextBox.Text.Split(' ');

			List<double> numbers = new List<double>();

			try {
				foreach (string s in strs)
					numbers.Add(double.Parse(s));
			}
			catch {
				MessageBox.Show("Ожидается ввод вещественных чисел в поле!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			using (FileStream write = new FileStream("file.txt", FileMode.OpenOrCreate)) {
				foreach (double num in numbers) {
					byte[] buffer = Encoding.UTF8.GetBytes(num.ToString() + "\n");
					write.Write(buffer, 0, buffer.Length);
				}
			}

			double av = 0;

			using (FileStream read = new FileStream("file.txt", FileMode.Open)) {
				string line = string.Empty;
				int iterator = 1;
				double sum = 0;
				int count = 0;
				byte[] buffer = new byte[read.Length];
				read.Read(buffer, 0, buffer.Length);

				string[] nums =	Encoding.UTF8.GetString(buffer).Split('\n');
				foreach (string s in nums) {
					if (iterator % 2 == 0){
						MessageBox.Show(s);
						try{
						sum += double.Parse(s);
						}
						catch{ continue; }
						count++;
					}
					iterator++;
				}

				av = sum / count;

			}

			MessageBox.Show($"\nСреднее арифметическое чисел, стоящих на четных позициях: {av}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
