using Microsoft.AspNetCore.Mvc;
using Tectonner.Service.Implementations;

namespace Tectonner.Controllers;

[ApiController]
[Route("tectonner/api")]
public class TectonnerHomeController : Controller
{
    private readonly IServiceCliente _serviceCliente;

    public TectonnerHomeController(IServiceCliente service)
    {
        _serviceCliente = service;
    } 

    [HttpGet("external/{id}")]
    public async Task<IActionResult> GetOneExternalData(int id)
    {
        try
        {
            string a = await _serviceCliente.GetCliente(id);
            return Ok(a);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Error: {ex.Message}");
        }
    }
}
