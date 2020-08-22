using Shared.Data.Interfaces;
using Shared.Model.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Data.Repositories
{
    public class PeopleRepository : BaseRepository<Person>, IPeopleRepository
    {
        public PeopleRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
