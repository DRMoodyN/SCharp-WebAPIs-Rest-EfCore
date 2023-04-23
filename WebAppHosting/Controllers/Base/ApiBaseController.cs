namespace WebAppHosting.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class ApiBaseController : ControllerBase
    {
        [Authorize]
        [HttpGet("user")]
        public string GetUserNameSeccion()
        {
            return HttpContext.User.Identity.Name;
        }
    }
}
