using System.Globalization;

namespace Exer1.Validate;
public class Valid<T>
{
    public static T CheckCR(string message)
    {
        Console.WriteLine(message);
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
                if (string.IsNullOrEmpty(str))
                    throw new Exception("lỗi, null hay empty");

                switch (type)
                {
                    case TypeCode.String:
                        i = str;
                        if (((string)i).Length < 5)
                            throw new Exception("lỗi, chiều dài chuỗi phải >= 5");
                        break;
                    case TypeCode.Int32:
                        i = Convert.ToInt32(str);
                        if ((int)i < 0)
                            throw new Exception("lỗi, số phải >= 0");
                        break;
                    case TypeCode.Double:
                        i = Convert.ToDouble(str);
                        break;
                    case TypeCode.DateTime:
                        var date = DateTime.TryParseExact(str, ["dd-MM-yyyy", "dd/MM/yyyy"], new CultureInfo("vi-VN"), DateTimeStyles.None,
                         out DateTime t) ? t : throw new Exception("lỗi, phải là dd-MM-yyyy hay dd/MM/yyyy");
                        i = date.Add(DateTime.Now.TimeOfDay);
                        break;
                }
            }
            catch (Exception e)
            {

                Console.WriteLine($"{e.Message}, nhập lại");
                flag = false;
            }

        } while (!flag);

        return (T)i;
    }
}