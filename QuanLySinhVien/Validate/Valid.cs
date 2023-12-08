using System;
using System.Globalization;

namespace QuanLySinhVien.Validate
{
    public class Valid<T>
    {
        public static T CheckCR(string message)
        {
            Console.WriteLine(message);
            var type = Type.GetTypeCode(typeof(T));
            var i = default(T);
            bool flag;

            do
            {
                flag = true;
                try
                {
                    var str = Console.ReadLine();

                    // Guard clause - design pattern
                    if (string.IsNullOrEmpty(str))
                        throw new Exception("Lỗi, giá trị không được null hoặc empty");

                    switch (type)
                    {
                        case TypeCode.String:
                            i = (T)Convert.ChangeType(str, typeof(T));
                            if (((string)(object)i).Length < 2)
                                throw new Exception("Lỗi, chiều dài chuỗi phải >= 2");
                            break;
                        case TypeCode.Int32:
                            i = (T)Convert.ChangeType(Convert.ToInt32(str), typeof(T));
                            if ((int)(object)i < 0)
                                throw new Exception("Lỗi, điểm phải >= 0.");
                            break;

                        case TypeCode.Double:
                            i = (T)Convert.ChangeType(Convert.ToDouble(str), typeof(T));
                            break;
                        case TypeCode.DateTime:
                            var date = DateTime.TryParseExact(str, new[] { "dd-MM-yyyy", "dd/MM/yyyy" }, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime t)
                                ? (T)Convert.ChangeType(t.Add(DateTime.Now.TimeOfDay), typeof(T))
                                : throw new Exception("Lỗi, phải là dd-MM-yyyy hoặc dd/MM/yyyy.");
                            break;
                    }

                    
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e.Message}, nhập lại");
                    flag = false;
                }

            } while (!flag);

            return i;
        }
    }
}
