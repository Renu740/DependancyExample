using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependancyExample
{
    public class OperationService : IScopedService, ISingletonService, ITransientService
    {
        Guid id;
        public OperationService()
        {
            id = Guid.NewGuid();
        }
        public Guid GetOperationID()
        {
            return id;
        }
    }
}
