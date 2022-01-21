using Domain.Entities;
using Domain.Interfaces.Services;
namespace USAProperties.Services
{
    using Interfaces;
    public class PropertyTraceApiService : ApiServiceBase<PropertyTrace>, IPropertyTraceService
    {
        private readonly IPropertyTraceService _propertyTraceService;

        public PropertyTraceApiService(IPropertyTraceService propertyTraceService) : base(propertyTraceService)
        {
            _propertyTraceService = propertyTraceService;
        }
    }
}
