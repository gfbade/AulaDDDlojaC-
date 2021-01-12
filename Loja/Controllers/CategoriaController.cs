using Loja.Domain.Interfaces.Service;
using Loja.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Loja.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaService CategoriaService;

        public CategoriaController(ICategoriaService categoriaService) =>
            CategoriaService = categoriaService;

        // GET: api/<CategoriaController>
        [HttpGet]
        public IEnumerable<CategoriaModel> Get()
        {
            return CategoriaService.GetAll();
        }

        // GET api/<CategoriaController>/5
        [HttpGet("{id}")]
        public CategoriaModel Get(long id)
        {
            return CategoriaService.GetById(id);
        }

        // POST api/<CategoriaController>
        [HttpPost]
        public IActionResult Post([FromBody] CategoriaModel model)
        {
            try
            {
                var user = CategoriaService.Add(model);

                return Created($"/api/users/{user?.Id}", user?.Id);
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = ex.Message });
            }
        }

        // PUT api/<CategoriaController>/5
        [HttpPut("{id}")]
        public IActionResult Put([FromRoute] long id, [FromBody] CategoriaModel model)
        {
            try
            {
                model.Id = id;
                CategoriaService.Update(model);

                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = ex.Message });
            }
        }

        // DELETE api/<CategoriaController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                CategoriaService.Remove(id);

                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = ex.Message });
            }
        }
    }
}
