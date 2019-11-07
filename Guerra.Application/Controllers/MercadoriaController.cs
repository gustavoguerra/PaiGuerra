using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Guerra.Domain.Cadastro;
using Guerra.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Guerra.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MercadoriaController : ControllerBase
    {
        protected readonly IMercadoriaService _services;

        public MercadoriaController(IMercadoriaService mercadoriaService)
        {
            _services = mercadoriaService;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Mercadoria>> GetAll()
        {
            try
            {
                return Ok(_services.GetAll());
            }
            catch
            {
                return new StatusCodeResult(500);
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Mercadoria> GetById(int id)
        {
            try
            {
                return Ok(_services.GetById(id));
            }
            catch
            {
                return new StatusCodeResult(500);
            }
        }

        // POST api/values
        [HttpPost]
        public ActionResult<string> Insert([FromBody]Mercadoria obj)
        {
            try
            {
                _services.Insert(obj);

                return Ok();
            }
            catch
            {
                return new StatusCodeResult(500);
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult<string> Put(int id, [FromBody]Mercadoria obj)
        {
            try
            {
                obj.id = id;
                _services.Update(obj);

                return Ok();
            }
            catch
            {
                return new StatusCodeResult(500);
            }

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult<string> Delete(int id, [FromBody] Mercadoria obj)
        {
            try
            {
                obj.id = id;

                _services.Update(obj);

                return Ok();
            }
            catch
            {
                return new StatusCodeResult(500);
            }
        }
    }
}