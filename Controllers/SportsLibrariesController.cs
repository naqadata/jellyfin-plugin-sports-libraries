using Jellyfin.Plugin.SportsLibraries.Configuration;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Jellyfin.Plugin.SportsLibraries.Controllers;

[ApiController]
[Route("SportsLibraries")]
[Authorize]
public class SportsLibrariesController : ControllerBase
{
    [HttpGet]
    public ActionResult<SportsLibrariesDto> Get() => new(new SportsLibrariesDto
    {
        SportsLibraryIds = Plugin.Instance?.Configuration.SportsLibraryIds ?? []
    });
}

public class SportsLibrariesDto
{
    public string[] SportsLibraryIds { get; set; } = [];
}
