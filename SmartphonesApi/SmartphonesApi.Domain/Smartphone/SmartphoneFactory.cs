namespace SmartphonesApi.Domain.Smartphone
{
    public static class SmartphoneFactory
    {
        public static Smartphone Create(string name, string brand, int storage)
        {
            ArgumentNullException.ThrowIfNull(name, nameof(name));
            ArgumentNullException.ThrowIfNull(brand, nameof(brand));

            var smartphone = new Smartphone()
            {
                Name = name,
                Brand = brand,
                Storage = storage
            };

            return smartphone;
        }
    }
}
