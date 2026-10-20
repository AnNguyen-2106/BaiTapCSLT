/*
 * Bài: Buoi01_A3 - Vẽ hình bằng ký tự
 * Sinh viên: Nguyễn Văn An - MSSV: 31251028009
 * Ngày: 20/10/2026
 */
namespace Buoi01_A3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Cách 1: mỗi dòng một lệnh
            Console.WriteLine("   *");
            Console.WriteLine("  ***");
            Console.WriteLine(" *****");
            Console.WriteLine("*******");

            // Cách 2: một lệnh, dùng \n
            Console.WriteLine("   *\n  ***\n *****\n*******");

            // Cách 3: ngôi nhà, dùng \\
            Console.WriteLine("  /\\");
            Console.WriteLine(" /  \\");
            Console.WriteLine("/____\\");
            Console.WriteLine("|    |");
            Console.WriteLine("|_[]_|");

            // Cách 4: chuỗi nguyên văn @
            Console.WriteLine(@"  /\
 /  \
/____\
|    |
|_[]_|");
        }
    }
}