using Exer1.Dao;
using Exer1.ExtMethod;
using Exer1.Validate;

namespace Exer1.ListMenu;
public class Menu
{
    public static void Show()
    {
        var loop = true;
        ListProduct list = new();

        while (loop)
        {
            Console.ResetColor();
            Console.WriteLine("==============================");
            Console.WriteLine("1 - nhập danh sách sản phẩm: ");
            Console.WriteLine("2 - in danh sách sản phẩm: ");
            Console.WriteLine("3 - xóa sản phẩm bất kỳ trong danh sách: ");
            Console.WriteLine("4 - tìm sản phẩm: ");
            Console.WriteLine("5 - sắp xếp sản phẩm: ");
            Console.WriteLine("chọn bất kỳ số nào khác ở trên để thoát: ");

            var choose = Valid<int>.CheckCR("vui lòng chọn số: ");
            switch (choose)
            {
                case 1:
                    list.ChangeColor(ConsoleColor.Black, ConsoleColor.Cyan);
                    list.AddProduct();
                    break;
                case 2:
                    list.ChangeColor(ConsoleColor.Black, ConsoleColor.Green);
                    list.ShowProduct();
                    break;
                case 3:
                    list.ChangeColor(ConsoleColor.Black, ConsoleColor.Red);
                    list.DeleteProduct();
                    break;
                case 4:
                    list.ChangeColor(ConsoleColor.Black, ConsoleColor.Yellow);
                    list.FindProduct();
                    break;
                case 5:
                    list.ChangeColor(ConsoleColor.Black, ConsoleColor.Blue);
                    list.SortProduct();
                    break;
                default:
                    loop = false;
                    break;
            }
        }
    }
}