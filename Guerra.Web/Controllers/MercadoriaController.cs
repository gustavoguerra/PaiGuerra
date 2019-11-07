using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Guerra.Domain.Cadastro;
using Guerra.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Guerra.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MercadoriaController : ControllerBase
    {

        protected readonly IMercadoriaService _mercadoriaService;
        
        public MercadoriaController(IMercadoriaService mercadoriaService)
        {
            _mercadoriaService = mercadoriaService;
        }

        // GET: api/Mercadoria
        [HttpGet]
        public ActionResult<IEnumerable<Mercadoria>> Getall()
        {
            return Ok(_mercadoriaService.GetAll());
        }

        // GET: api/Mercadoria/5
        [HttpGet("{id}")]
        public ActionResult<Mercadoria> Getbyid(int id)
        {
            return Ok(_mercadoriaService.GetById(id));
        }

        // POST: api/Mercadoria
        [HttpPost]
        public ActionResult<bool> insert([FromBody] Mercadoria obj)
        {
            return Ok(_mercadoriaService.Insert(obj));        
        }

        // PUT: api/Mercadoria/5
        [HttpPut("{id}")]
        public ActionResult<bool> update([FromBody] Mercadoria obj)
        {
            return Ok(_mercadoriaService.Update(obj));            
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete([FromBody] Mercadoria obj)
        {
            return Ok(_mercadoriaService.Remove(obj));            
        }
    }
}
