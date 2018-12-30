using ReactTemplate.Data.Data;
using ReactTemplate.WebApi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactTemplate.WebApi.Services
{
    public class ExampleService : IExampleService
    {
        private readonly IExampleData data;

        public ExampleService(IExampleData data)
        {
            this.data = data;
        }

        public async Task<int> AddExampleModelItem(string itemName, double value)
        {
            return await data.AddItem(itemName, value);
        }

        public async Task<ISet<ExampleModel>> GetExampleModelItems()
        {
            return (await data.AllItems()).Select(d =>
                new ExampleModel
                {
                    Id = d.Id,
                    ItemName = d.Name,
                    Value = d.Value
                }
            ).ToHashSet();
        }
    }
}
