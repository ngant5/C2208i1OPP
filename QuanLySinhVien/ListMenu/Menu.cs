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
            Console.WriteLine("1 - nhập danh sách sinh viên: ");
            Console.WriteLine("2 - hiển thị danh sách sinh viên: ");
            Console.WriteLine("3 - Thong tin sinh viên tuoi lon hon 20 và diem lon hon 8: ");
            Console.WriteLine("4 - Thong tin sinh vien có diem trung bình băng diem trung bình lon nhat: ");
            Console.WriteLine("5 - Săp xep theo diem so : ");
            Console.WriteLine("6 - Tim sinh vien theo ho ten : ");

            var choose = Valid<int>.CheckCR("vui lòng chọn số: ");
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
                    list.ShowStudentPoint();
                    break;
                case 5:
                    list.SortStudent();
                    break;
                case 6:
                    list.FintStudent();
                    break;
                default:
                    loop = false;
                    break;
            }
        }
    }
}
