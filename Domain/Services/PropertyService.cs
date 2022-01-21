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
    public class PropertyService : ServiceBase<Property>, IPropertyService
    {
        private readonly IPropertyRepository _propertyRepository;

        public PropertyService(IPropertyRepository propertyRepository)
            : base(propertyRepository)
        {
            _propertyRepository = propertyRepository;
        }
    }
}
