using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]"), ApiController]
    public class CustomersController : Controller, IPostable<Customer>
    {
        private ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _customerService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _customerService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getbyuserid")]
        public IActionResult GetAllByUserId(int id)
        {
            var result = _customerService.GetAllByUserId(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getbycompanyname")]
        public IActionResult GetAllByCompanyName(string company)
        {
            var result = _customerService.GetAllByCompanyName(company);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Customer entity)
        {
            var result = _customerService.Add(entity);
            if (result.Success)
            {
                return Ok((result));
            }

            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Customer entity)
        {
            var result = _customerService.Update(entity);
            if (result.Success)
            {
                return Ok((result));
            }

            return BadRequest(result);
        }

        [HttpPost("remove")]
        public IActionResult Remove(Customer entity)
        {
            var result = _customerService.Delete(entity);
            if (result.Success)
            {
                return Ok((result));
            }

            return BadRequest(result);
        }
    }
}