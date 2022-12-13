using System;
using System.IO;

namespace Ex2_Console {
	class Program {
		static void Main(string[] args) {
			int k = 0;
			string str = string.Empty;

			while (true) {
				try {
					Console.Write("Введите целое число: ");
					k = int.Parse(Console.ReadLine());

					if (k <= 0) throw new Exception("Число должно быть больше нуля!");
					break;
				}
				catch (FormatException) {
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write("Ошибка: ");
					Console.ResetColor();
					Console.WriteLine("Ожидается ввод вещественного числа для!");
				}
				catch (Exception ex) {
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write("Ошибка: ");
					Console.ResetColor();
					Console.WriteLine(ex.Message);
				}
			}

			using (StreamReader file = new StreamReader("file.txt")) {
				string line = string.Empty;
				int i = 1;
				while ((line = file.ReadLine()) != null) {
					if (line.Length < k) Console.WriteLine($"Строка [{i}]: {line} [{line.Length} символов]");
					i++;
				}
			}
		}
	}
}


