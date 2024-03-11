using Innovt.Domain.Core.Model;

namespace SmartphonesApi.Domain.Smartphone
{
    public class Smartphone : Entity<Guid>
    {
        public string? Name { get; set; }
        public string? Brand { get; set; }
        public int Storage { get; set; }

        public Smartphone()
        {
            Id = Guid.NewGuid();
        }

        public void Update(string name, string brand)
        {
            ArgumentNullException.ThrowIfNullOrEmpty(name);
            ArgumentNullException.ThrowIfNullOrEmpty(brand);

            Name = name;
            Brand = brand;
        }
    }
}
