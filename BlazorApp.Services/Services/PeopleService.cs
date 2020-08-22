using Shared.BusinessLogic.Interfaces;
using Shared.Data.Interfaces;
using Shared.Model.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shared.BusinessLogic.Services
{
    
    public class PeopleService : IPeopleService
    {
        private IPeopleRepository _peopleRepository;

        public PeopleService(IPeopleRepository peopleRepository)
        {
            _peopleRepository = peopleRepository;
        }

        public async Task AddOrUpdateAsync(Person person)
        {
            await _peopleRepository.AddOrUpdateAsync(person);
        }

        public async Task<IEnumerable<Person>> GetAllAsync()
        {
            return await _peopleRepository.GetAllAsync();
        }
    }
}
