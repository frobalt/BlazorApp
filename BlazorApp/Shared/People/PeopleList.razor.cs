using Microsoft.AspNetCore.Components;
using Shared.BusinessLogic.Interfaces;
using Shared.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorApp.Shared.People
{
    public partial class PeopleList : ComponentBase
    {
        [Inject]
        public IPeopleService PeopleService { get; set; }

        private IEnumerable<Person> People;

        protected override async Task OnInitializedAsync()
        {
            await Load();
        }

        public async Task Load()
        {
            People = null;
            await Task.Delay(1000);
            People = await PeopleService.GetAllAsync();
        }
    }
}
