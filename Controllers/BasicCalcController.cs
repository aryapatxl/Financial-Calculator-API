using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace Calculator_API.Controllers;

[ApiController]
[Route("[controller]")]
public class BasicCalcController : ControllerBase
{

    private readonly ILogger<BasicCalcController> _logger;

    public BasicCalcController(ILogger<BasicCalcController> logger)
    {
        _logger = logger;
    }

    [HttpPost("Add/{Number1}/{Number2}")]
    public IActionResult Add(int Number1, int Number2)
    {
        int result = Number1 + Number2;
        return Ok(result);
    }



[HttpPost("Subtract/{value}/{value1}")]
    public IActionResult Subtract([FromBody] Calculation request)
    {
        int result = request.Value - request.Value1;
        return Ok(result);
    }
    [HttpPost("Multiply")]
    public IActionResult Multiply([FromBody] Calculation request)
    {
        int result = request.Value * request.Value1;
        return Ok(result);
    }

    [HttpPost("Divide/{value}/{value1}")]
    public IActionResult Divide([FromBody] Calculation request)
    {
        int result = request.Value / request.Value1;
        return Ok(result);
    }
}
