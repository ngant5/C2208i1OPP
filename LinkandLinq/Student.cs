namespace ListandLinq;
public class Student
{
    public int RollNumber { get; set; }
    public string FullName { get; set; }
    public string Section { get; set; }
    public int RoomNumber { get; set; }

    public override string ToString()
    {
        return $"{nameof(RollNumber)}={RollNumber.ToString()}, {nameof(FullName)}={FullName}, {nameof(Section)}={Section}, {nameof(RoomNumber)}={RoomNumber.ToString()}";
    }
}