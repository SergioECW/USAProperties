using Domain.Entities;
using Domain.Interfaces.Services;
namespace USAProperties.Services
{
    using Interfaces;
    public class OwnerApiService : ApiServiceBase<Owner>, IOwnerApiService
    {
        private readonly IOwnerService _ownerService;

        public OwnerApiService(IOwnerService ownerService) : base(ownerService)
        {
            _ownerService = ownerService;
        }
    }
}
