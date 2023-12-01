using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer1;
internal class Valid<T>
{
    public static T CheckCR()
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        var type = Type.GetTypeCode(typeof(T));
        var i = new object();
        bool flag;
        do
        {
            flag = true;
            try
            {
                var str = Console.ReadLine();
                //guard clause - design pattern
                if(string.IsNullOrEmpty(str))
                {
                    throw new Exception("lỗi, null or empty");
                }
                switch (type)
                {
                    case TypeCode.String:
                        i = str;
                        if (((string)i).Length <= 5)
                            throw new Exception("lỗi, chiều dài phải lớn hơn 5");
                        break;
                    case TypeCode.Int32:
                        i = Convert.ToInt32(str);
                        if ((int)i < 0) throw new Exception("lỗi, số phải >= 0");
                        break;
                    case TypeCode.Double:
                        i = Convert.ToDouble(str);
                        break;
                    case TypeCode.DateTime:
                        var date = DateTime.TryParseExact(str, ["yyyy-MM-dd", "yyyy/MM/dd"], new CultureInfo("vi-VN"), DateTimeStyles.None, out DateTime t) ? t : throw new Exception("lỗi, phải là dd-MM-yyyy hay dd/MM/yyyy");
                        i = date.Add(DateTime.Now.TimeOfDay);
                    break;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}, enter again");
                flag = false;
            }
        } while (!flag);

        return (T)i;

    }
}
