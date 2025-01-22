using LivrariaAPIs.Banco;
using LivrariaAPIs.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LivrariaAPIs.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LivrariaController : ControllerBase
{
    private readonly MeuContext _context;

    public LivrariaController(MeuContext context)
    {
        _context = context;

        // Iniciar dados, remover após integrar com banco de dados
        _context.SeedData(_context);
    }


    [HttpGet]
    public async Task<ActionResult<IEnumerable<Produto>>> GetProdutos()
    {
        return await _context.Produtos.ToListAsync();
    }

    [HttpGet]
    [Route("{id}")]
    public async Task<ActionResult<Produto>> GetProduto(int id)
    {
        var produto = await _context.Produtos.FindAsync(id);
        if (produto == null)
        {
            return NotFound();
        }
        return produto;
    }
    [HttpPost]
    public async Task<ActionResult<Produto>> PostProduto(Produto produto)
    {
        _context.Produtos.Add(produto);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetProduto), new { id = produto.Id }, produto);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutProduto(int id, Produto produto)
    {
        if (id != produto.Id)
        {
            return BadRequest();
        }

        _context.Entry(produto).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!ProdutoExists(id))
            {
                return NotFound();
            }
            throw;
        }

        return NoContent();
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteProduto(int id)
    {
        var produto = await _context.Produtos.FindAsync(id);
        if (produto == null)
        {
            return NotFound();
        }

        _context.Produtos.Remove(produto);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool ProdutoExists(int id) => _context.Produtos.Any(e => e.Id == id);
}

