using ReactTemplate.Data.Contexts;
using ReactTemplate.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactTemplate.Data.Data
{
    public class ExampleData : IExampleData
    {
        private readonly ExampleContext exampleContext;

        public ExampleData(ExampleContext exampleContext)
        {
            this.exampleContext = exampleContext;
        }

        public async Task<int> AddItem(string name, double value)
        {
            var exampleModel = new ExampleModel { Name = name, Value = value };
            exampleContext.ExampleModels.Add(exampleModel);
            await exampleContext.SaveChangesAsync();
            return exampleModel.Id;
        }

        public async Task<ISet<ExampleModel>> AllItems()
        {
            return exampleContext.ExampleModels.ToHashSet();
        }
    }
}
