using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    using Entities;
    using Interfaces.Repositories;
    public class PropertyImageService : ServiceBase<PropertyImage>, IPropertyImageService
    {
        private readonly IPropertyImageRepository _propertyImageRepository;

        public PropertyImageService(IPropertyImageRepository propertyImageRepository) : base
            (propertyImageRepository)
        {
            _propertyImageRepository = propertyImageRepository;
        }
    }
}
