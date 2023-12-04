using Exer1.Entity;
using Exer1.Validate;

namespace Exer1.Dao;

public class ListProduct
{
    public List<Product> ListPro { get; set; } = [];

    public void AddProduct()
    {
        var n = Valid<int>.CheckCR("vui lòng nhập số lượng sản phẩm cần thêm:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("==========================");
            Console.WriteLine($"nhập sản phẩm thứ {i + 1}: ");
            var pro = new Product
            {
                ProId = Valid<string>.CheckCR("vui lòng nhập id: "),
                ProName = Valid<string>.CheckCR("vui lòng nhập tên sản phẩm: "),
                ProPrice = Valid<double>.CheckCR("vui lòng nhập giá sản phẩm: "),
                Quantity = Valid<int>.CheckCR("vui lòng nhập số lượng sản phẩm: "),
                ProMfg = Valid<DateTime>.CheckCR("vui lòng nhập ngày sản xuất: ")
            };
            ListPro.Add(pro);
        }
    }

    public void ShowProduct() => ListPro.ForEach(Console.WriteLine);

    public void DeleteProduct()
    {
        string id = Valid<string>.CheckCR("vui lòng nhập id cần xóa: ");
        //ListPro.RemoveAll(p => p.ProId.ToLower() == id.ToLower());
        ListPro.RemoveAll(p => string.Compare(p.ProId, id, true) == 0);
    }

    public void FindProduct()
    {

        string id = Valid<string>.CheckCR("Vui lòng nhập id cần tìm: ");
        //ListPro.RemoveAll(p => p.ProId.ToLower() == id.ToLower());

        var findPro = ListPro.SingleOrDefault(p => string.Compare(p.ProId, id, true) == 0);
        if (findPro is not null)
        {
            Console.WriteLine(findPro);
        }

    }

    internal void SortProduct()
    {
        //sort xong cho vào new list (list cũ không ảnh hưởng
        var list = ListPro.OrderBy(p => p.ProId);
        list.ToList().ForEach(Console.WriteLine);

        //quick sort
        ListPro.Sort(
            (p1, p2) => p1.ProId.CompareTo(p2.ProId)
            );
    }
}