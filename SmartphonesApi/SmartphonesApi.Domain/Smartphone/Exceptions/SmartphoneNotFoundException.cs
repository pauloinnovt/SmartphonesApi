namespace SmartphonesApi.Domain.Smartphone.Exceptions
{
    public class SmartphoneNotFoundException(Guid id) : Exception($"Not found smartphone with specified Id:{id}")
    {

    }
}
