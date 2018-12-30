using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReactTemplate.WebApi.Models;
using ReactTemplate.WebApi.Services;

namespace ReactTemplate.WebApi.Controllers
{
    [Route("v1/")]
    [ApiController]
    public class ExampleController : Controller
    {
        private readonly IExampleService _services;

        public ExampleController(IExampleService services)
        {
            _services = services;
        }

        /// <summary>
        ///     Creates a new Item
        /// </summary>
        /// <param name="itemName">Name of item</param>
        /// <param name="value">Value of item</param>
        /// <response code="200">Id of created Item</response>
        [HttpPost]
        [Route("AddExampleItem")]
        [ProducesResponseType(200, Type = typeof(int))]
        public async Task<IActionResult> AddExampleItem([FromQuery] [Required] string itemName, [FromQuery] [Required] double value)
        {
            return Ok(await _services.AddExampleModelItem(itemName, value));
        }

        /// <summary>
        ///     Retrieves all items
        /// </summary>
        /// <response code="200">A set of all items</response>
        [HttpGet]
        [Route("GetExampleItems")]
        [ProducesResponseType(200, Type = typeof(ISet<ExampleModel>))]
        public async Task<IActionResult> GetExampleItems()
        {
            var exampleModelItems = await _services.GetExampleModelItems();
            return Ok(exampleModelItems);
        }
    }
}