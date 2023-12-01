using System.Collections;
using System.Diagnostics;
using System.Text;
using ListandLinq;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;
#region Arraylist
//ArrayList arrayList1 = new();
//arrayList1.Add("trọng");
//arrayList1.Add(5);
//arrayList1.Add(true);

//ArrayList arrayList2 = ["hiếu", 4, false];

//for(int i = 0; i < arrayList1.Count; i++)
//{
//    Console.WriteLine(arrayList1[i]);
//}

//foreach(var item in arrayList2)
//{
//    Console.WriteLine(item);
//}
#endregion

List<Student> list1 = new();
list1.Add(new Student() { RollNumber = 1, FullName = "trọng", Section = "dãy 1", RoomNumber = 12 });
list1.Add(new Student() { RollNumber = 2, FullName = "hiếu", Section = "dãy 1", RoomNumber = 4 });

List<Student> list2 = [
    new Student() { RollNumber = 1, FullName = "trọng", Section = "dãy 1", RoomNumber = 12 },
    new Student() { RollNumber = 2, FullName = "hiếu", Section = "dãy 1", RoomNumber = 4 }
];

//đo tốc độ
Stopwatch sw = new();
//khởi động bằng cách retart lại
sw.Restart();
foreach (var item in list1)
{
    Console.WriteLine(item);
}
sw.Stop();
Console.WriteLine($"foreach run: {sw.ElapsedMilliseconds}");
Console.WriteLine("=============");
//khởi động bằng cách retart lại
sw.Restart();
IEnumerator enu = list1.GetEnumerator();
while (enu.MoveNext())
{
    Console.WriteLine(enu.Current.ToString());
}
sw.Stop();
Console.WriteLine($"ienumerator run: {sw.ElapsedMilliseconds}");
Console.WriteLine("======");

//duyệt qua list chỉ lấy roomnuber lớn hơn 2
foreach (var stu in list1)
{
    if (stu.RoomNumber > 2)
    {
        Console.WriteLine(stu);
    }
}

//linq có 2 style viết
//a) query syntax => dùng cú pháp của sql theo cấu trúc
//from [biến/đối tượng bất kỳ] in [danhsach]
//where điều kiện là gì đó (biến > hay < gì đó)
//group by gom nhóm
//having xét điều kiện cho nhóm group by
//order by sắp xếp
//cuối cùng mới select

var listStu = from stu in list1
              where stu.RoomNumber > 2
              select stu;

foreach (var t in listStu)
{
    Console.WriteLine(t);
}

//rút gọn code
foreach (var t in from u in list1
                  where u.RoomNumber > 2
                  select u)
{
    Console.WriteLine(t);
}

//b) method syntax (sử dụng lambda)
var x = list1.Where(u => u.RollNumber > 2);

foreach (var i in x)
{
    Console.WriteLine(i);
}

//rút gọn lại
foreach (var i in list1.Where(u => u.RollNumber > 2))
{
    Console.WriteLine(i);
}

//bản thân collection có luôn foreach
list1.ForEach(Console.WriteLine);
list1.ForEach(stu => Console.WriteLine(stu.FullName));

list1.ForEach(
    stu =>
    {
        if (stu.RoomNumber > 2)
        {
            Console.WriteLine(stu);
        }
    }
);
//============
//method syxtax
list1.Where(u => u.RollNumber > 2)
    .ToList()
    .ForEach(Console.WriteLine);

//query syntax
(from stu in list1
 where stu.RoomNumber > 2
 select stu).ToList().ForEach(Console.WriteLine);