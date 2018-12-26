using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReactTemplate.WebApi.Models;

namespace ReactTemplate.WebApi.Services
{
    public interface IExampleServices
    {
        ExampleModel AddExampleModelItem(ExampleModel items);
        Dictionary<string, ExampleModel> GetExampleModelItems();
    }
}
