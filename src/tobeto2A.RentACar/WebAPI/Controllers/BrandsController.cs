using Application.Features.Brands.Commands.Create;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BrandsController : BaseController
{
    [HttpPost]
    public async IActionResult Add([FromBody]CreateBrandCommand command)
    {
        CreatedBrandResponse response = await Mediator.Send(command);
        return Created("",response);
    }
}