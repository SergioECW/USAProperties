using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces.Services;
using Domain.Interfaces.Repositories;


namespace Domain.Services
{
    public class OwnerService : ServiceBase<Owner>, IOwnerRepository
    {
        private readonly IOwnerRepository _ownerRepository;

        public OwnerService(IOwnerRepository ownerRepository)
            : base(ownerRepository)
        {
            _ownerRepository = ownerRepository;
        }
    }
}
