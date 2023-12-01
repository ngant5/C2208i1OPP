using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ReviewExtensionMethod;
// class sử dụng theo các phương thức mở rộng (extension method)
// bắt buộc phải là static
// toàn bộ bên trong class đề phải là static
static class ExtMethod
{
    public static bool IsGreater(this int i, int value) => i > value;

    public static void Hi(this Program obj) => Console.WriteLine("xin chào");
  
}
