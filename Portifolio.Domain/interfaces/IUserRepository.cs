using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Portifolio.Domain.Models;

namespace Portifolio.Domain.interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllUserAsync();
        Task<User> GetByIdAsync(Guid id);

        Task<User> AddAsync(User user);
        
    }
}