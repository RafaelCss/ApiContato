using Microsoft.AspNetCore.Mvc;
using ApiCadastroDeClientes.Model;
using ApiCadastroDeClientes.Services;

namespace ApiCadastroDeClientes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContatoClientesController : ControllerBase
    {
        private readonly Cadastro _cadastro;

        public ContatoClientesController(Cadastro cadastro )
        {
            _cadastro = cadastro;
          
        }

        // GET: api/ContatoClientes
        [HttpGet]
        public ActionResult<IEnumerable<ContatoCliente>> Get()
        {
             return Ok(_cadastro.Get());
        }

        // GET: api/ContatoClientes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ContatoCliente>> Get(string id)
        {
            var cadastro = _cadastro.Get(id);

            if(cadastro == null)
            {
                return NotFound();
            }

            return Ok(cadastro);
        }

        // PUT: api/ContatoClientes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutContatoCliente(string id, ContatoCliente contatoCliente)
        {

            var cadastro = _cadastro.Get(id);

            if (cadastro == null)
                return NotFound();

            _cadastro.Upadate(id, contatoCliente);

            return NoContent();
        }

        // POST: api/ContatoClientes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ContatoCliente>> PostContatoCliente(ContatoCliente contatoCliente)
        {
            _cadastro.Create(contatoCliente);

            return CreatedAtAction(nameof(Get), new { id = contatoCliente.Id.ToString() }, contatoCliente);
        }

        // DELETE: api/ContatoClientes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContatoCliente(string id)
        {
            var cadastro = _cadastro.Get(id);

            if (cadastro == null)
                return NotFound();

            _cadastro.Remove(cadastro.Id);

            return NoContent();
        }

      
    }
}
