using ImprovementAttempt.Domain.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ImprovementAttempt.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyBusinessPIExample : ControllerBase
    {
        [HttpPost]
        public MyDataOutputDTO GetMyDataSuff(MyDataInputDTO myDataInputDTO)
        {
            throw new NotImplementedException();
        }
    }
}
