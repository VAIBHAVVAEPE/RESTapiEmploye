using Microsoft.AspNetCore.Mvc;
using RESTapiEmploye.Model;
using RESTapiEmploye.Services;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RESTapiEmploye.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeController : ControllerBase
    {
       readonly IEmployeServices _service;
        public EmployeController(IEmployeServices service)
        {
            _service = service;
        }
        // GET: api/<EmployeController>
        [HttpGet]
        [Route ("GetAllEmployes")]
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
        public int AddEmploye([FromBody] Employe emp)
        {
            return _service.AddEmploye(emp);
        }
        [HttpPost]
        [Route("ModifyEmploye")]
        public int ModifyEmploye([FromBody] Employe emp)
        {
            return _service.ModifyEmploye(emp);
        }


        

        // DELETE api/<EmployeController>/5
        [HttpGet("{id}")]
        [Route("DeleteEmploye/{id} ")]
        public int DeleteEmploye(int id)
        {
            return _service.DeleteEmploye(id);
        }
    }
}
