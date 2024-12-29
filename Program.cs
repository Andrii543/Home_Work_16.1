using System.Text;

namespace Home_Work_16._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.OutputEncoding = UTF8Encoding.UTF8;


                Console.Write("\n\nВведіть шлях до вихідного файлу: ");
                string? sourcePath = Console.ReadLine();
                 
                Console.Write("Введіть шлях до файлу, в який потрібно скопіювати дані: ");
                string? destinationPath = Console.ReadLine();

                File.Copy(sourcePath, destinationPath, true);

                Console.WriteLine("Файл успішно скопійовано!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Сталася помилка: {ex.Message}");
            }
        }
    }
}
