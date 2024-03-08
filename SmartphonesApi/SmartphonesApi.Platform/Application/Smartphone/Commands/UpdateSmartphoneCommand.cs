namespace SmartphonesApi.Platform.Application.Smartphone.Commands
{
    public class UpdateSmartphoneCommand
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
    }
}
