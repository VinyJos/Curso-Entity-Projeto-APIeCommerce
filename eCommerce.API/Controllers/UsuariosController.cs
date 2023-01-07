using eCommerce.API.Repositories;
using eCommerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        // vamos usar a injeção de dependência

        // readonly - apenas leitura
        private readonly IUsuarioRepository _repository;

        public UsuariosController(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        // mostrar todos , {endereço-site}/api/usuarios
        [HttpGet]
        public IActionResult Get()
        {
            var listaDeUsuarios = _repository.Get();

            return Ok(listaDeUsuarios);
        }

        // Obter por ID
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var usuario = _repository.Get(id);

            if (usuario == null)
                return NotFound("Não encontrado");

            return Ok(usuario);
        }

        // Adicionar usuario
        [HttpPost]
        public IActionResult Add([FromBody]Usuario usuario)
        {
            _repository.Add(usuario);

            return Ok(usuario);
        }

        // Atualizar
        [HttpPut("{id}")]
        public IActionResult Update([FromBody]Usuario usuario, int id)
        {
            _repository.Update(usuario);

            return Ok(usuario);
        }

        // Excluir
        [HttpDelete("{id}")]
        public IActionResult Delete(int id) 
        { 
            _repository.Delete(id);
            return Ok();
        }
    }
}
