using Infrastructure.Helpers.Models.Common;
using Infrastructure.Helpers.Services.ServiceInterface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        public readonly IBasicTestCrudFunctionality _iBasicTestCrud;
        private readonly IHttpContextAccessor _contextHttp;
        private readonly IWebHostEnvironment _env;
        private readonly IConfiguration _configuration;

        public DefaultController(IBasicTestCrudFunctionality basicTestCrud, IHttpContextAccessor httpContextAccessor,
                                IWebHostEnvironment webHostEnvironment, IConfiguration configuration)
        {
            _iBasicTestCrud = basicTestCrud;
            _contextHttp = httpContextAccessor;
            _env = webHostEnvironment;
            _configuration = configuration;
        }

        [HttpGet("GetBasicTestDataList")]
        public async Task<IActionResult> GetBasicTestDataList()
        {
            try
            {
                var result = await _iBasicTestCrud.GetBasicTestDataList();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiResponse()
                {
                    Status = "Error",
                    StatusCode = 400,
                    Message = ex.Message
                });
            }
        }

    }
}
