using Domain.Entities;
using Domain.Interfaces.Services;
namespace USAProperties.Services
{
    using Interfaces;
    public class PropertyImageApiService : ApiServiceBase<PropertyImage>, IPropertyImageService
    {
        private readonly IPropertyImageService _propertyImageService;

        public PropertyImageApiService(IPropertyImageService propertyImageService) : base(propertyImageService)
        {
            _propertyImageService = propertyImageService;
        }
    }
}
