/*
 * Bài: Buoi01_B2 - Thiệp chúc mừng 20/11
 * Sinh viên: Nguyễn Văn An - MSSV: 31251028009
 * Ngày: 20/10/2026
 */
namespace Buoi01_B2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(new string('*', 40));
            Console.WriteLine("*" + new string(' ', 38) + "*");
            Console.WriteLine("*" + "  CHÚC MỪNG NGÀY NHÀ GIÁO VIỆT NAM".PadRight(38) + "*");
            Console.WriteLine("*" + "              20/11".PadRight(38) + "*");
            Console.WriteLine("*" + new string(' ', 38) + "*");
            Console.WriteLine("*" + "  Học trò kính chúc:".PadRight(38) + "*");
            Console.WriteLine("*" + "  \"Thầy cô luôn mạnh khỏe!\"".PadRight(38) + "*");
            Console.WriteLine("*" + new string(' ', 38) + "*");
            Console.WriteLine(new string('*', 40));
        }
    }
}