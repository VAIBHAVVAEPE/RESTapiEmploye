using Microsoft.AspNetCore.Mvc;
using RESTapiEmploye.Services;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RESTapiEmploye.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeController : ControllerBase
    {
        IEmployeServices _service;
        public EmployeController(IEmployeServices service)
        {
            _service = service;
        }
        // GET: api/<EmployeController>
        [HttpGet]
        [Route ("GEtAllEmployes")]
        public IActionResult GetAllEmployes()
        {
            return new ObjectResult( _service.GetAllEmploye());
        }
        [HttpGet]
        [Route("GetEmployeById/{id}")]
        public IActionResult GetEmployeById()
        {
            return new ObjectResult(_service.GetEmployeById());
        }



        // POST api/<EmployeController>
        [HttpPost]
        [Route ("AddEmploye")]
        public int AddEmploye([FromBody] EmployeController emp)
        {
            return _service.AddEmploye(emp);
        }
        [HttpPost]
        [Route("ModifyEmploye")]
        public int ModifyEmploye([FromBody] EmployeController emp)
        {
            return _service.ModifyEmploye(emp);
        }


        

        // DELETE api/<EmployeController>/5
        [HttpGet("{id}")]
        [Route("DeleteEmploye/{id} ")]
        public int DeleteEmploye(int id)
        {
            return new ObjectResult(_service.DeleteEmploye(id));
        }
    }
}
