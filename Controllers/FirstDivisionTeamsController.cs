using Microsoft.AspNetCore.Mvc;
using server_brazilian_first_division.Repository.interfaces;

namespace server_brazilian_first_division.Controllers;

[ApiController]
[Route("[controller]")]
public class FirstDivisionTeamsController : ControllerBase
{
    private readonly IFirstDivisionRepository _repo;

     public FirstDivisionTeamsController(IFirstDivisionRepository repo)
     {
        _repo = repo;
     }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_repo.GetAllTeams());
    }
}
