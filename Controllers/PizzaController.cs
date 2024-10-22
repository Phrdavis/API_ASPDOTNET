using API_ASPDOTNET.Models;
using API_ASPDOTNET.Services;
using Microsoft.AspNetCore.Mvc;

namespace API_ASPDOTNET.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class PizzaController : ControllerBase{

    public PizzaController(){}

    [HttpGet]
    public ActionResult<List<Pizza>> GetAll() =>
            PizzaService.GetAll();

    [HttpGet("{id}")]
    public ActionResult<Pizza> GetId (int id){

        var pizza = PizzaService.Get(id);

        if(pizza is null) return NotFound();

        return pizza;

    }

    [HttpPost]
    public IActionResult Create(Pizza pizza){

        PizzaService.Add(pizza);
        return CreatedAtAction(nameof(Create), new { id = pizza.Id }, pizza);

    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Pizza pizza){

        if (id != pizza.Id)
            return BadRequest();

        var old_pizza = PizzaService.Get(id);

        if(old_pizza is null) return NotFound();

        PizzaService.Update(pizza);

        return NoContent();

    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id){

        var pizza = PizzaService.Get(id);

        if(pizza is null) return NotFound();

        PizzaService.Delete(id);

        return NoContent();

    }

}