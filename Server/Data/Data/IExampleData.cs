using ReactTemplate.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReactTemplate.Data.Data
{
    public interface IExampleData
    {
        Task<int> AddItem(string name, double value);
        Task<ISet<ExampleModel>> AllItems();
    }
}
