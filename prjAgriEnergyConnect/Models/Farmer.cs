namespace prjAgriEnergyConnect.Models
{
    public class Farmer
    {
        public int FarmerId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public List<Product>? Products { get; set; }
    }
}
