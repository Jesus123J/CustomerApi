using CustomersApi.dtos;
using CustomersApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CustomersApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : Controller
    {
        private readonly CustomerDataBaseContext _customerDataBaseContext;


        public CustomersController(CustomerDataBaseContext customerDataBaseContext)
        {
            _customerDataBaseContext = customerDataBaseContext;
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CustomerDto))]
        public async Task<IActionResult> GetCustomers ()
        {
            throw new NotImplementedException();

        }


        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CustomerDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetCustomer(long id)
        {
           var vacio = new CustomerDto();
            return new OkObjectResult(vacio);
        }


        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(bool))]
        public async Task<IActionResult> DeleteCustomer(long id)
        {
            throw new NotImplementedException();
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created , Type =typeof(CustomerDto))]
        public async Task<IActionResult> CreateCustomer(CreateCustomerDto customer)
        {
            Console.Write("Linea of comments");
            CustomerEntity result = await _customerDataBaseContext.Add(customer);
            return new CreatedResult($"http://localhost:7030/api/customer/{result.Id}", null);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CustomerDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UdpateCustomer(CustomerDto customer)
        {
            throw new NotImplementedException();
        }
    }
}
