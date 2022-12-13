using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Ex1_Console {
	class Program {
		static void Main(string[] args) {
			int n = 0;
			List<double> numbers = new List<double>();

			while (true) {
				try {	
					Console.Write("Введите вещественное число или stop для продолжения: ");
					string str = Console.ReadLine();

					if (str == "stop") break;
					double num = double.Parse(str);
					numbers.Add(num);
				}
				catch (FormatException) {
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write("Ошибка: ");
					Console.ResetColor();
					Console.WriteLine("Ожидается ввод вещественного числа!");
				}
				catch (Exception ex) {
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write("Ошибка: ");
					Console.ResetColor();
					Console.WriteLine(ex.Message);
				}
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
				foreach (string s in nums){
					if (iterator % 2 == 0){
						try{
						sum += double.Parse(s);
						}
						catch {continue;}
						count++;
					}
					iterator++;
				}

				av = sum / count;

			}

			Console.WriteLine($"\nСреднее арифметическое чисел, стоящих на четных позициях: {av}");
		}
	}
}
