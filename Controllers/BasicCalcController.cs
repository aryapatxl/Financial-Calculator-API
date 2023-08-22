using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace Calculator_API.Controllers;

[ApiController]
[Route("[controller]")]
public class BasicCalculationsController : ControllerBase
{

    private readonly ILogger<BasicCalculationsController> _logger;

    public BasicCalculationsController(ILogger<BasicCalculationsController> logger)
    {
        _logger = logger;
    }

    // ADD METHOD
    [HttpPost("Add/{Number1}/{Number2}")]
    public IActionResult Add(int Number1, int Number2)
    {
        int result = Number1 + Number2;
        return Ok(result);
    }

    // SUBTRACT METHOD
    [HttpPost("Subtract/{Number1}/{Number2}")]
    public IActionResult Subtract(int Number1, int Number2)
    {
        int result = Number1 - Number2;
        return Ok(result);
    }

    // MULTIPLY METHOD
    [HttpPost("Multiply/{Number1}/{Number2}")]
    public IActionResult Multiply(int Number1, int Number2)
    {
        int result = Number1 * Number2;
        return Ok(result);
    }

    // INT DIVIDE METHOD
    [HttpPost("Divide/Integer/{Number1}/{Number2}")]
    public IActionResult DivideInteger(int Number1, int Number2)
    {
        int result = Number1 / Number2;
        return Ok(result);
    }

    // DECIMAL DIVIDE METHOD
    [HttpPost("Divide/Decimal/{Number1}/{Number2}")]
    public IActionResult DivideDecimal(double Number1, double Number2)
    {
        double result = Number1 / Number2;
        return Ok(result);
    }


}

