using System.Collections.Generic;
using System.Threading.Tasks;
using ReactTemplate.WebApi.Models;

namespace ReactTemplate.WebApi.Services
{
    public interface IExampleService
    {
        /// <summary>
        ///     Adds new item
        /// </summary>
        /// <param name="itemName">Name of item</param>
        /// <param name="value">Value of item</param>
        /// <returns>Id of created object</returns>
        Task<int> AddExampleModelItem(string itemName, double value);
        Task<ISet<ExampleModel>> GetExampleModelItems();
    }
}
