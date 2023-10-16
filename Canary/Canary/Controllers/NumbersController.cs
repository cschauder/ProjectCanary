using Microsoft.AspNetCore.Mvc;
using Canary.Models;
using Canary.Services;

namespace Canary.Controllers;

[ApiController]
[Route("[controller]")]
public class NumbersController : ControllerBase
{
    public NumbersController()
    {
    }

    [HttpGet]
    public ActionResult<List<Number>> GetAll() =>
        NumberService.GetAll();

    [HttpGet("{num}")]
    public ActionResult<Number> Get(string num)
    {
        var number = NumberService.Get(num);
        if (number == null)
        {
            return NotFound();
        }
        return number;
    }

    [HttpPost]
    public IActionResult Create(Number number)
    {
        number.Num = NumberService.ConvertStringToNumber(number.SevenDigit);
        NumberService.Add(number);
        return CreatedAtAction(nameof(Get), new { num = number.Num }, number);
    }
}