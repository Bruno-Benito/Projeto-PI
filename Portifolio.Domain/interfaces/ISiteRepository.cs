using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Portifolio.Domain.Models;

namespace Portifolio.Domain.interfaces
{
    public interface ISiteRepository
    {
         Task<IEnumerable<Site>> GetAllUserAsync();
        Task<Site> GetByIdAsync(Guid id);

        Task<Site> AddAsync(Site site);
    }
}