using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sainsburyAPI.Models;
using sainsburyAPI.Services;

namespace sainsburyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerStore _store;

        public CustomerController(ICustomerStore store)
        {
            _store = store;
        }

        /// <summary>
        /// This method fetches data and returns a list of Customer.
        /// </summary>
        /// <returns>returns the list of all customers.</returns>
        [HttpGet]
        public async Task<IActionResult> GetCustomerList()
        {
            var result = await _store.GetAllCustomer();
            return Ok(result);
        }

        /// <summary>
        /// This method fetches data for a Customer.
        /// </summary>
        /// <returns>returns the list of all customers.</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomer(int id)
        {
            var result = await _store.GetCustomer(id);
            return Ok(result);
        }

        /// <summary>
        /// This method is for add new Customer.
        /// </summary>
        /// <param name="model">CustomerModel.</param>
        /// <returns>Returns the result customer model.</returns>
        [HttpPost]
        public async Task<IActionResult> AddCustomer([FromForm] CustomerModel model)
        {
           var result = await _store.AddCustomer(model);
            return Ok(result);
        }

        /// <summary>
        /// This method is for update Customer existing details.
        /// </summary>
        /// <param name="model">CustomerModel.</param>
        /// <returns>Returns the result customer model.</returns>
        [HttpPut]
        public async Task<IActionResult> UpdateCustomer([FromForm] CustomerModel model)
        {
           var result = await _store.UpdateCustomer(model);
            return Ok(result);
        }
    }
}
