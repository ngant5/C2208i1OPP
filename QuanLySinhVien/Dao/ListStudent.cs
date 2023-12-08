using QuanLySinhVien.Entity;
using QuanLySinhVien.IService;
using QuanLySinhVien.Validate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.Dao;
internal class ListStudent : IDao
{
    public List<Student> ListStu { get; set; } = [];
    public void AddStudent()
    {
        var n = Valid<int>.CheckCR("vui lòng nhập số lượng sinh viên cần thêm:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("==========================");
            Console.WriteLine($"nhập sinh viên thứ {i + 1}: ");
            var stu = new Student
            {
                MaSV = Valid<int>.CheckCR("vui lòng nhập id: "),
                HoTen = Valid<string>.CheckCR("vui lòng nhập tên sinh viên: "),
                NgaySinh = Valid<DateTime>.CheckCR("vui lòng nhập ngày sinh: "),
                GioiTinh = Valid<string>.CheckCR("vui lòng nhập giới tính: "),
                DiemTrungBinh = Valid<double>.CheckCR("vui lòng nhập điểm: "),
                DiaChiNha = Valid<string>.CheckCR("vui lòng nhập địa chỉ: ")
            };
            ListStu.Add(stu);
        }
    }
    public void ShowStudent() => ListStu.ForEach(Console.WriteLine);

    public void FindStudent()
    {

        int id = Valid<int>.CheckCR("Vui lòng nhập id cần tìm: ");
        

        var findStu = ListStu.SingleOrDefault(p => p.MaSV == id);
        if (findStu is not null)
        {
            Console.WriteLine("Sinh viên cần tìm có thông tin như sau:");
            Console.WriteLine(findStu);
        }
        else
        {
            Console.WriteLine($"Không tìm thấy sản phẩm có id {id} trong danh sách.");
        }

    }

    internal void ShowStudent20()
    {
        throw new NotImplementedException();
    }

    public void ShowStudentWithHighest()
    {
        // Tìm điểm trung bình lớn nhất
        double maxAverage = ListStu.Max(p => p.DiemTrungBinh);

        // Lọc danh sách sinh viên có điểm trung bình bằng điểm trung bình lớn nhất
        var studentsWithMaxAverage = ListStu.Where(p => p.DiemTrungBinh == maxAverage);

        Console.WriteLine($"Danh sách sinh viên có điểm trung bình bằng điểm trung bình lớn nhất ({maxAverage}):");

        // Hiển thị danh sách sinh viên
        studentsWithMaxAverage.ToList().ForEach(Console.WriteLine);

    }

    public void SortStudent()
    {
        var list = ListStu.OrderByDescending(p => p.DiemTrungBinh);
        list.ToList().ForEach(Console.WriteLine);
    }

    public void UpdateStudent()
    {
        int id = Valid<int>.CheckCR("Vui lòng nhập id cần cập nhật: ");
        var StuToUpdate = ListStu.SingleOrDefault(p => p.MaSV == id);


        if (StuToUpdate is not null)
        {
            Console.WriteLine($"Thông tin hiện tại của sản phẩm có id {id}:");
            Console.WriteLine(StuToUpdate);

            Console.WriteLine("\nNhập thông tin mới cho sản phẩm:");
            StuToUpdate.HoTen = Valid<string>.CheckCR("Nhập lại tên sinh viên: ");
            StuToUpdate.NgaySinh = Valid<DateTime>.CheckCR("Nhập lại ngày sinh: ");
            StuToUpdate.GioiTinh = Valid<string>.CheckCR("Nhập lại giới tính: ");
            StuToUpdate.DiemTrungBinh = Valid<double>.CheckCR("Nhập lại điểm: ");
            StuToUpdate.DiaChiNha = Valid<string>.CheckCR("Nhập lại địa chỉ: ");

            Console.WriteLine($"Thông tin của sinh viên có id {id} đã được cập nhật.");
        }
        else
        {
            Console.WriteLine($"Không tìm thấy sinh viên có id {id} trong danh sách.");
        }
    }

    public void DeleteStudent()
    {
        int id = Valid<int>.CheckCR("Vui lòng nhập id cần xóa: ");
        var findStu = ListStu.SingleOrDefault(p => p.MaSV == id);
        if (findStu is not null)
        {
            Console.WriteLine(findStu);
        }
        else
        {
            Console.WriteLine($"Không tìm thấy sản phẩm có id {id} trong danh sách.");
        }

        ListStu.RemoveAll(p => p.MaSV == id);
    }


}
