using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi_Tarefas.Model;

namespace WebApi_Tarefas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TarefaController : ControllerBase
    {
        private readonly Data.AppDbContext _appDbContext;

        public TarefaController(Data.AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpPost]
        public async Task<ActionResult<Model.Tarefa>> AddTarefa([FromBody] Model.Tarefa tarefa)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _appDbContext.Tarefas.Add(tarefa);
            await _appDbContext.SaveChangesAsync();
            return Created("Tarefa adicionado com sucesso!", tarefa);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Model.Tarefa>>> GetTarefas()
        {
            var tarefa = await _appDbContext.Tarefas.ToListAsync();
            return Ok(tarefa);
        }

        
        [HttpGet("{id}")]
        public async Task<ActionResult<Model.Tarefa>> GetTarefaId(int id)
        {
            var tarefa = await _appDbContext.Tarefas.FindAsync(id);

            if (tarefa == null)
            {
                return NotFound("Tarefa não encontrada.");
            }

            return Ok(tarefa);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateTarefa(int id, [FromBody] Tarefa tarefaAtualizada)
        {
            var tarefaExistente = await _appDbContext.Tarefas.FindAsync(id);

            if (tarefaExistente == null)
            {
                return NotFound("Tarefa não encontrada.");
            }

            _appDbContext.Entry(tarefaExistente).CurrentValues.SetValues(tarefaAtualizada);

            await _appDbContext.SaveChangesAsync();

            return StatusCode(201, tarefaExistente);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteTarefa(int id)
        {
            var tarefa = await _appDbContext.Tarefas.FindAsync(id);

            if (tarefa == null)
            {
                return NotFound("Tarefa não encontrada.");
            }

            _appDbContext.Tarefas.Remove(tarefa);

            await _appDbContext.SaveChangesAsync();

            return Ok("Tarefa deletada com sucesso.");
        }
 
    }
}