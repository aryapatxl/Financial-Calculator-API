using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace Calculator_API.Controllers;

[ApiController]
[Route("[controller]")]

public class Financial_CalculationsController : ControllerBase
    {
    private readonly ILogger<Financial_CalculationsController> _logger;

    public Financial_CalculationsController(ILogger<Financial_CalculationsController> logger)
    {
        _logger = logger;
    }

    // SIMPLE INTEREST RATE
    [HttpPost("SimpleInterest/{Principal_Amount}/{Yearly_Interest_Rate}/{Years}")]
    public IActionResult SimpleInterest(double Principal_Amount, double Yearly_Interest_Rate, int Years)
    {
        double result = Principal_Amount * Yearly_Interest_Rate * Years;

        result = Math.Round(result, 2);
        return Ok(result);
    }

    // COMPOUND INTEREST
    [HttpPost("CompoundInterest/{Principal_Amount}/{Yearly_Interest_Rate}/{Years}/{Amt_Compounding_Yearly}")]
    public IActionResult CompoundInterest(double Principal_Amount, double Yearly_Interest_Rate, int Years, int Amt_Compounding_Yearly)
    {
        double result = 1 + (Yearly_Interest_Rate / Amt_Compounding_Yearly);
        double exp = Years * Amt_Compounding_Yearly;
        double total = Principal_Amount * (Math.Pow(result,exp));
        total = Math.Round(total, 2);
        string formattedTotal = $"${total}";

        return Ok(formattedTotal);

    }

    // PRICE TO EARNINGS RATIO
    [HttpPost("PriceToEarningsRatio/{PricePerShare}/{EarningsPerShare}")]
    public IActionResult PriceToEarningsRatio(double PricePerShare, double EarningsPerShare)
    {
        double result = PricePerShare / EarningsPerShare;
        result = Math.Round(result, 2);
        string formattedTotal = $"${result}";
        
        return Ok(formattedTotal);
    }
}

