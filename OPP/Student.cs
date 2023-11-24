namespace OPP;
internal class Student
{
    //vừa là field vừa là auto property
    public int Id { get; set; }
    public string? Fullname { get; set; }
    public bool Gender { get; set; }
    public DateTime Dob { get; set; }

    //constructor
    //public Student() { }

    //public Student(int id, string? fullname, bool gender, DateTime dob)
    //{
    //    Id = id;
    //    Fullname = fullname;
    //    Gender = gender;
    //    Dob = dob;
    //}

    //override tostring 
    public override string ToString()
    {
        return $"{nameof(Id)}={Id.ToString()}, {nameof(Fullname)}={Fullname}, {nameof(Gender)}={Gender.ToString()}, {nameof(Dob)}={Dob.ToString()}";
    }
}