using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace Calculator_API.Controllers;

[ApiController]
[Route("[controller]")]
public class CalcController : ControllerBase
{

    private readonly ILogger<CalcController> _logger;

    public CalcController(ILogger<CalcController> logger)
    {
        _logger = logger;
    }

    [HttpPost("Add")]
    public IActionResult Add([FromBody] Calculation request)
    {
        int result = request.Value + request.Value1;
        return Ok(result);
    }

    [HttpPost("Subtract")]
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

    [HttpPost("Divide")]
    public IActionResult Divide([FromBody] Calculation request)
    {
        int result = request.Value / request.Value1;
        return Ok(result);
    }
}
