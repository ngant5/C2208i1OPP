using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.Entity;
internal class Student
{
    public int MaSV { get; set; }
    public string HoTen { get; set; }
    public DateTime NgaySinh { get; set; }
    public string GioiTinh { get; set; }
    public double DiemTrungBinh { get; set; }
    public string DiaChiNha { get; set; }

    public override string ToString()
    {
        return $"{{{nameof(MaSV)}={MaSV},{ nameof(HoTen)}={ HoTen},{ nameof(NgaySinh)}={ NgaySinh}, { nameof(GioiTinh)}={ GioiTinh}, { nameof(DiemTrungBinh)}={ DiemTrungBinh.ToString()},{ nameof(DiaChiNha)}={ DiaChiNha},}}";
    }
}
