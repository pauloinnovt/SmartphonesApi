using Innovt.Core.Attributes;
using Microsoft.AspNetCore.Mvc;
using SmartphonesApi.Platform.Application.Smartphone.Filters;

namespace SmartphonesApi.ViewModels
{
    public class GetSmartphoneByIdViewModel
    {
        [RequiredGuid]
        [FromRoute]
        public Guid Id { get; set; }

        public GetSmartphoneByIdViewModel SetId(Guid id)
        {
            Id = id;
            return this;
        }

        public GetSmartphoneFilter ToFilter()
        {
            var filter = new GetSmartphoneFilter()
            {
                Id = Id,
            };

            return filter;
        }
    }
}
