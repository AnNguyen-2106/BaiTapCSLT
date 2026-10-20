/*
 * Bài: Buoi01_B3 - Sửa lỗi chương trình
 * Sinh viên: Nguyễn Văn An - MSSV: 31251028009
 * Ngày: 20/10/2026
 */
namespace Buoi01_B3
{
    internal class program
    {
        static void Main(string[] args) // sửa: main -> Main
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // sửa: thiếu dấu ;
            Console.WriteLine("Chương trình có lỗi"); // sửa: console -> Console, thiếu dấu " đóng
            Console.WriteLine("Đường dẫn: C:\\Temp\\new"); // sửa: Writeline -> WriteLine, \T và \n -> \\T và \\n
            Console.WriteLine("Kết thúc"); // sửa: nháy đơn -> nháy kép
        } // sửa: thiếu dấu } đóng cuối tệp (thêm } cuối cùng)
    }
}