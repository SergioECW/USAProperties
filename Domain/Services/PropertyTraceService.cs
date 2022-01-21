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
    public class PropertyTraceService : ServiceBase<PropertyTrace>, IPropertyTraceService
    {
        private readonly IPropertyTraceRepository _propertyTraceRepository;

        public PropertyTraceService(IPropertyTraceRepository propertyTraceRepository)
            : base(propertyTraceRepository)
        {
            _propertyTraceRepository = propertyTraceRepository;
        }        
    }
}
