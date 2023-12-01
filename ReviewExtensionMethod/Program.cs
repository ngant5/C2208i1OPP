
using ReviewExtensionMethod;
using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

Console.WriteLine("vui lòng nhập số: ");
int i = int.TryParse(Console.ReadLine(), out int result) ? result : 0;
Console.WriteLine($"{nameof(i)}={i}");

//so sánh i với giá trị bất kỳ
Console.WriteLine("so sánh i có lớn hơn 1 số bất kỳ");
Console.WriteLine(Valid.isGreaterThan(i, 100) ? "i lớn hơn" : "i không lớn hơn");

//so sánh i với giá trị bất kỳ, dùng extensionmethod
Console.WriteLine("so sánh i có lớn hơn 1 số bất kỳ");
Console.WriteLine(i.IsGreater(100) ? "i lớn hơn" : "i không lớn hơn");
Console.WriteLine("============");
int x = 50;
Console.WriteLine(x.IsGreater(10)?"x>10":"x<=10");

Console.WriteLine("============");

Program pro1 = new();
pro1.Hi();
//ExtMethod.Hi(prod1);

