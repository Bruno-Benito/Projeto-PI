using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portifolio.Domain.Entities
{
    public abstract class EntityBase
    {
        public Guid Id {get; protected set;}
        
    }
}