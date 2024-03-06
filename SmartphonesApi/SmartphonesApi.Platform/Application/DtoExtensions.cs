using SmartphonesApi.Platform.Application.Smartphone.Dtos;

namespace SmartphonesApi.Platform.Application
{
    public static class DtoExtensions
    {
        public static SmartphoneDto ToDto(this Domain.Smartphone.Smartphone smartphone)
        {
            var dto = new SmartphoneDto()
            {
                Brand = smartphone.Brand,
                Name = smartphone.Name,
            };

            return dto;
        }
    }
}
