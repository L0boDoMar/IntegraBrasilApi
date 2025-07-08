using IntegraBrasilApi.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace IntegraBrasilApi.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class EnderecoController : ControllerBase
{
    public readonly IEnderecoService _enderecoService;

    public EnderecoController(IEnderecoService enderecoService)
    {
        _enderecoService = enderecoService;
    }

    public async Task<IActionResult> BuscarEndereco([FromRoute] string cep)
    {
        var res = await _enderecoService.BuscarEndereco(cep);

        if (res.CodigoHttp == HttpStatusCode.OK)
            return Ok(res.DadosRetorno);
        else
            return StatusCode((int)res.CodigoHttp, res.ErroRetorno);
    }
}
