using Domain.Entities;
using Domain.Interfaces.Services;
namespace USAProperties.Services
{
    using Interfaces;
    public class PropertyApiService : ApiServiceBase<Property>, IPropertyApiService
    {
        private readonly IPropertyService _propertyService;

        public PropertyApiService(IPropertyService propertyService): base(propertyService)
        {
            _propertyService = propertyService;
        }
    }
}
