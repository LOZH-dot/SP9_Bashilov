using System;
using System.IO;
using System.Windows.Forms;

namespace Ex2_Forms {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void ResultButton_Click(object sender, EventArgs e) {
			int k = 0;
			try {
				k = int.Parse(NumberTextBox.Text);

				if (k <= 0) throw new Exception("Число должно быть больше нуля!");
			}
			catch (FormatException) {
				MessageBox.Show("Ожидается ввод целого числа!");
				return;
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
				return;
			}

			string result = "";

			using (StreamReader file = new StreamReader("file.txt")) {
				string line = string.Empty;
				int i = 1;
				while ((line = file.ReadLine()) != null) {
					if (line.Length < k) result += ($"Строка [{i}]: {line} [{line.Length} символов]\n");
					i++;
				}
			}


			MessageBox.Show((result == "" ? "Строки не найдены" : result), "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);


		}
	}
}
