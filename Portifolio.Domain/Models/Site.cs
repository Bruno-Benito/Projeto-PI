using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Portifolio.Domain.Entities;

namespace Portifolio.Domain.Models
{
    public class Site : EntityBase
    {
        public bool IsActive { get; set; }
        public string Description { get; set; } = "";
    }
}