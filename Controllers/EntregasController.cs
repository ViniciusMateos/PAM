using Microsoft.AspNetCore.Mvc;
using FUSCA_API.Data;
using FUSCA_API.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace FUSCA_API.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class EntregasController : ControllerBase
    {
        private readonly DataContext _context;

        public EntregasController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("GetAll")]
    public async Task<IActionResult> Get()
    {
      try
      {
        List<Entrega> lista = await _context.Entregas.ToListAsync();
        return Ok(lista);
      }
      catch (Exception ex)
      {
        return BadRequest(ex.Message);
      }
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetSingle(int id)
    {
      try
      {
        Entrega p = await _context.Entregas.FirstOrDefaultAsync(pBusca => pBusca.Id == id);
        return Ok(p);
      }
      catch (Exception ex)
      {
        return BadRequest(ex.Message);
      }
    }

    [HttpPost]
    public async Task<IActionResult> Add(Entrega novaEntrega)
    {
      await _context.Entregas.AddAsync(novaEntrega);
      await _context.SaveChangesAsync();
      return Ok(novaEntrega.Id);

    }

    [HttpPut]
    public async Task<IActionResult> Update(Entrega novaEntrega)
    {
      _context.Entregas.Update(novaEntrega);
      int linhasAfetadas = await _context.SaveChangesAsync();
      return Ok(novaEntrega.Id);
    }

    [HttpDelete("{Id}")]
    public async Task<IActionResult> Delete(int id)
    {
      try
      {
        Entrega pRemover = await _context.Entregas.FirstOrDefaultAsync(p => p.Id == id);
        _context.Entregas.Remove(pRemover);
        int linhasAfetadas = await _context.SaveChangesAsync();
        return Ok(linhasAfetadas);
      }
      catch (Exception ex)
      {
        return BadRequest(ex.Message);
      }
    }
    }

    
}