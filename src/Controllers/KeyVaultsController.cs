using Microsoft.AspNetCore.Mvc;

namespace WebApiHandsOn.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class KeyVaultsController : Controller
    {

        private readonly IConfiguration _Configuration;
        private readonly string _myNameFromKeyVault;
        private readonly string _connectionStringFromKeyVault;

        public KeyVaultsController(IConfiguration configuration)
        {
            _Configuration = configuration;
            _myNameFromKeyVault = configuration["TestMyName"];
            _connectionStringFromKeyVault = configuration["ConnectionToMySQLDBCloud"];
        }
        
        [HttpPost("GetMyName")]
        public IActionResult GetMyNameFromAzureKeyVault()
        {
            return Ok(_myNameFromKeyVault);
        }

        [HttpPost("GetMyConnectionString")]
        public IActionResult GetMyConnectionStringFromAzureKeyVault()
        {
            return Ok(_connectionStringFromKeyVault);
        }
    }
}
