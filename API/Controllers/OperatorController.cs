using API.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/{controller}")]
    public class OperatorController:ControllerBase
    {
        [HttpPost]
        [Route("add-package")]
        public async Task<ActionResult> AddPackage([FromBody]PackageRegisterDto packageRegisterDto)
        {

            

            return Ok(packageRegisterDto);
        }
    }
}
