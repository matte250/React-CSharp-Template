using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ReactTemplate.WebApi.Models;
using ReactTemplate.WebApi.Services;

namespace ReactTemplate.WebApi.Controllers
{
    [Route("v1/")]
    [ApiController]
    public class ExampleController : ControllerBase
    {
        private readonly IExampleServices _services;

        public ExampleController(IExampleServices services)
        {
            _services = services;
        }
        [HttpPost]
        [Route("AddExampleItem")]
        public ActionResult<ExampleModel> AddExampleItem(ExampleModel item)
        {
            var exampleModelItem = _services.AddExampleModelItem(item);

            if(exampleModelItem == null)
            {
                return NotFound();
            }
            return Ok(exampleModelItem);
        }

        [HttpGet]
        [Route("GetExampleItems")]
        public ActionResult<Dictionary<string, ExampleModel>> GetExampleItems()
        {
            var exampleModelItems = _services.GetExampleModelItems();

            if (exampleModelItems.Count == 0)
            {
                return NotFound();
            }

            return Ok(exampleModelItems);
        }
    }
}