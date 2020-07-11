using Microsoft.AspNetCore.Mvc;

namespace simpleApi.Controllers
{
    [ApiController]
    public class ValuesController: ControllerBase
    {
        [HttpGet("/{id}")]
        public ActionResult<string> Get(int id) {
            return $"returned value is {id}";
        }
        
    }
}
