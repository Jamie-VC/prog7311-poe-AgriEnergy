
namespace prjAgriEnergyConnect.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int? FarmerId { get; set; }
        public Farmer? Farmer { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public DateOnly ProductionDate { get; set; } 
    }
}
