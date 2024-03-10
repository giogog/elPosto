using API.Dtos;
using DapperLibrary.DataAccess;
using GeneralLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/{controller}")]
    public class OperatorController:ControllerBase
    {
        private readonly IDbAccess _access;

        public OperatorController(IDbAccess access)
        {
            _access = access;
        }


        [HttpGet]
        [Route("add-package/{id}")]
        public async Task<ActionResult> AddPackage([FromQuery]int id)
        {
            string sqlQuerry = "SELECT ID,NAME FROM USERS_ WHERE ID = @id";
            var result = await _access.LoadDataProcedure<User ,dynamic>(sqlQuerry, new { ID = id });

            return Ok(result.FirstOrDefault());
        }
    }
}
