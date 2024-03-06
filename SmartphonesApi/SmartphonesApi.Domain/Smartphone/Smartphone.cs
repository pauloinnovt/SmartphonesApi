using System.ComponentModel.DataAnnotations;

namespace SmartphonesApi.Domain.Smartphone
{
    public class Smartphone
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Storage { get; set; }
    }
}
