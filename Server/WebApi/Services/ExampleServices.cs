using System.Collections.Generic;
using ReactTemplate.WebApi.Models;

namespace ReactTemplate.WebApi.Services
{
    public class ExampleServices : IExampleServices
    {
        private readonly Dictionary<string, ExampleModel> _exampleModelItems;

        public ExampleServices()
        {
            _exampleModelItems = new Dictionary<string, ExampleModel>();
        }
        public ExampleModel AddExampleModelItem(ExampleModel item)
        {
            _exampleModelItems.Add(item.ItemName, item);
            return item;
        }

        Dictionary<string,ExampleModel> IExampleServices.GetExampleModelItems()
        {
            return _exampleModelItems;
        }
    }
}
