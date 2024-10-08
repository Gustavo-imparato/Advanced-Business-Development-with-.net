using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class CarroController : ControllerBase
{
    private readonly ICarroRepository _carroRepository;

    public CarroController(ICarroRepository carroRepository)
    {
        _carroRepository = carroRepository;
    }

    // GET: api/carro
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Carro>>> Get()
    {
        var carros = await _carroRepository.GetAllAsync();
        return Ok(carros);
    }

    // GET: api/carro/{id}
    [HttpGet("{id}")]
    public async Task<ActionResult<Carro>> GetById(string id) // ID permanece como string
    {
        var carro = await _carroRepository.GetByIdAsync(id);
        if (carro == null)
        {
            return NotFound();
        }
        return Ok(carro);
    }

    // POST: api/carro
    [HttpPost]
    public async Task<ActionResult<Carro>> Create(Carro carro)
    {
        await _carroRepository.AddAsync(carro);
        return CreatedAtAction(nameof(GetById), new { id = carro.Id }, carro);
    }

    // PUT: api/carro/{id}
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(string id, Carro carro)
    {
        var existingCarro = await _carroRepository.GetByIdAsync(id);
        if (existingCarro == null)
        {
            return NotFound();
        }

        await _carroRepository.UpdateAsync(id, carro);
        return NoContent();
    }

    // DELETE: api/carro/{id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        var carro = await _carroRepository.GetByIdAsync(id);
        if (carro == null)
        {
            return NotFound();
        }

        await _carroRepository.DeleteAsync(id);
        return NoContent();
    }
}
