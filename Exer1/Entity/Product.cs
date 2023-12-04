namespace Exer1.Entity;
public class Product
{
    public string ProId { get; set; }
    public string ProName { get; set; }
    public double ProPrice { get; set; }
    public int Quantity { get; set; }
    public DateTime ProMfg { get; set; }

    public override string ToString()
    {
        return $"{{{nameof(ProId)}={ProId}, {nameof(ProName)}={ProName}, {nameof(ProPrice)}={ProPrice}, {nameof(Quantity)}={Quantity}, {nameof(ProMfg)}={ProMfg.ToString()}}}";
    }
}