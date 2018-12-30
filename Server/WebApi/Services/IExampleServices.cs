using System.Collections.Generic;
using ReactTemplate.WebApi.Models;

namespace ReactTemplate.WebApi.Services
{
    public interface IExampleServices
    {
        ExampleModel AddExampleModelItem(ExampleModel items);
        Dictionary<string, ExampleModel> GetExampleModelItems();
    }
}
