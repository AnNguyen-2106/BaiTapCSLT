/*
 * Bài: Buoi01_A5 - Chu vi, diện tích hình chữ nhật
 * Sinh viên: Nguyễn Văn An - MSSV: 31251028009
 * Ngày: 20/10/2026
 */
namespace Buoi01_A5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            double a = 5, b = 3;
            double cv = 2 * (a + b);
            double dt = a * b;
            double d = Math.Sqrt(a * a + b * b);
            Console.WriteLine("Chiều dài = " + a);
            Console.WriteLine("Chiều rộng = " + b);
            Console.WriteLine("Chu vi = " + cv);
            Console.WriteLine("Diện tích = " + dt);
            Console.WriteLine("Đường chéo = " + d);
        }
    }
}