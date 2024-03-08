using SmartphonesApi.Platform.Application.Smartphone.Dtos;

namespace SmartphonesApi.Platform.Application.Extensions
{
    public static class Extensions
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

        public static List<SmartphoneDto> ToDto(this List<Domain.Smartphone.Smartphone> smartphones)
        {
            return smartphones is null ? [] : smartphones.Select(ToDto).ToList();
        }
    }
}
