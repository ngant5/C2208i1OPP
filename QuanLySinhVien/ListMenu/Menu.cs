using QuanLySinhVien.Dao;
using QuanLySinhVien.Validate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.ListMenu;
public class Menu
{

    public static void Show()
    {
        var loop = true;
        ListStudent list = new();

        while (loop)
        {
            Console.ResetColor();
            Console.WriteLine("==============================");
            Console.WriteLine("1 - Nhập danh sách sinh viên: ");
            Console.WriteLine("2 - Hiển thị danh sách sinh viên: ");
            Console.WriteLine("3 - Hiển thị danh sách sinh viên có tuổi lớn hơn 20 và có điểm trung bình lớn hơn 8: ");
            Console.WriteLine("4 - Hiển thị danh sách sinh viên có điểm trung bình bằng điểm trung bình lớn nhất: ");
            Console.WriteLine("5 - Hiển thị danh sách sắp xếp theo điểm số của sinh viên : ");
            Console.WriteLine("6 - Tìm xem mã sinh viên có tồn tại không : ");
            Console.WriteLine("7 - Cập nhật thông tin theo mã sinh viên : ");
            Console.WriteLine("8 - Xóa sinh viên : ");

            var choose = Valid<int>.CheckCR("vui lòng chọn nội dung muốn thực hiện: ");
            switch (choose)
            {
                case 1:
                    list.AddStudent();
                    break;
                case 2:
                    list.ShowStudent();
                    break;
                case 3:
                    list.ShowStudent20();
                    break;
                case 4:
                    list.ShowStudentWithHighest();
                    break;
                case 5:
                    list.SortStudent();
                    break;
                case 6:
                    list.FindStudent();
                    break;
                case 7:
                    list.UpdateStudent();
                    break;
                case 8:
                    list.DeleteStudent();
                    break;
                default:
                    loop = false;
                    break;
            }
        }
    }
}
