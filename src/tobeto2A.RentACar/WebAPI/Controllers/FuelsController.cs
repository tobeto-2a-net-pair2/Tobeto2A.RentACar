using Application.Features.Fuels.Commands.Create;
using Application.Features.Fuels.Queries.GetList;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;

namespace WebAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class FuelsController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateFuelCommand command)
    {
        CreatedFuelResponse response = await Mediator.Send(command);
        return Created("", response);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
    {
        GetListFuelQuery query = new() { PageRequest = pageRequest };
        GetListResponse<GetListFuelItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }
}