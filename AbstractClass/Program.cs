using System;
using System.Text;
using AbstractClass;

Console.OutputEncoding = Encoding.Unicode;

//object initializer => giảm thiểu constructor
Teacher teacher = new()
{
    FullName = "nguyên",
    Age = 45
};

teacher.ShowInfo();
Console.WriteLine(teacher);