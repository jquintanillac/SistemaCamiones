using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Driver.web.IServices;
using Driver.web.Data.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Driver.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SVMDClienteController : ControllerBase
    {
        IMDClienteServices _mDClienteServices;

        public SVMDClienteController(IMDClienteServices mDClienteServices)
        {
            _mDClienteServices = mDClienteServices;
        }

        // GET: api/<SVMDClienteController>
        [HttpGet]
        public IEnumerable<MDCliente> GetAll()
        {
            return _mDClienteServices.GetAll();
        }

        // GET api/<SVMDClienteController>/5
        [HttpGet("{id}")]
        public MDCliente Getbyid(int id_cliente)
        {
            return _mDClienteServices.GetbyId(id_cliente);
        }

        // POST api/<SVMDClienteController>
        [HttpPost]
        public void Post([FromForm] MDCliente mDCliente)
        {
            if(mDCliente.id_cliente == 0)
            {
                _mDClienteServices.Save(mDCliente);
            }
            else
            {
                _mDClienteServices.Update(mDCliente);
            }
        }

        // DELETE api/<SVMDClienteController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _mDClienteServices.Delete(id);
        }
    }
}
