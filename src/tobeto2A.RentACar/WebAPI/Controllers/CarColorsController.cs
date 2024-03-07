using Application.Features.CarColors.Commands.Create;
using Application.Features.CarColors.Commands.Delete;
using Application.Features.CarColors.Commands.Update;
using Application.Features.CarColors.Queries.GetById;
using Application.Features.CarColors.Queries.GetList;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CarColorsController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateCarColorCommand createCarColorCommand)
    {
        CreatedCarColorResponse response = await Mediator.Send(createCarColorCommand);

        return Created(uri: "", response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateCarColorCommand updateCarColorCommand)
    {
        UpdatedCarColorResponse response = await Mediator.Send(updateCarColorCommand);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        DeletedCarColorResponse response = await Mediator.Send(new DeleteCarColorCommand { Id = id });

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        GetByIdCarColorResponse response = await Mediator.Send(new GetByIdCarColorQuery { Id = id });
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListCarColorQuery getListCarColorQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListCarColorListItemDto> response = await Mediator.Send(getListCarColorQuery);
        return Ok(response);
    }
}