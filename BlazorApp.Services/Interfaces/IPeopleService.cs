using Shared.Model.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shared.BusinessLogic.Interfaces
{
    public interface IPeopleService
    {
        Task<IEnumerable<Person>> GetAllAsync();
        Task AddOrUpdateAsync(Person person);
    }
}
