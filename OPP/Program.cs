
using OPP;

//object by constructor
//Student stu1 = new Student(1, "nguyen", true, new DateTime(1982,04,27));
//Student stu2 = new(2, "nguyen", true, new DateTime(1982,04,27));

//object initializer => class không cần tạo constructor làm gì
Student stu3 = new()
{
    Id = 3,
    Gender = false,
    Fullname = "trong",
    Dob = DateTime.Now
};

Console.WriteLine(stu3);