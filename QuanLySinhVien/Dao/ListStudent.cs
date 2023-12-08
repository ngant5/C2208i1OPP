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

    public void FintStudent()
    {
        string id = Valid<string>.CheckCR("Vui lòng nhập id cần tìm: ");
        //ListPro.RemoveAll(p => p.ProId.ToLower() == id.ToLower());

        var findStu = ListStu.SingleOrDefault(p => string.Compare(p.HoTen, id, true) == 0);
        if (findStu is not null)
        {
            Console.WriteLine(findStu);
        }
    }

    

    internal void ShowStudent20()
    {
        throw new NotImplementedException();
    }

    internal void ShowStudentPoint()
    {
        throw new NotImplementedException();
    }

    internal void SortStudent()
    {
        throw new NotImplementedException();
    }
}
