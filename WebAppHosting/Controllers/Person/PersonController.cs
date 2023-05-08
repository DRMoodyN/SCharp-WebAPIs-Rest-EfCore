namespace WebAppHosting.Controllers
{
    public sealed class PersonController : ApiBaseController
    {
        public readonly IServiceManager _service;
        public PersonController(IServiceManager service)
        {
            _service = service;
        }

        [Authorize]
        [HttpGet("type-email")]
        public async Task<IActionResult> GetAllTypeEmail()
        {
            var result = await _service.PersonLogic.GetListTypeEmail();
            return StatusCode(StatusCodes.Status200OK, result);
        }

        [Authorize]
        [HttpGet("type-person")]
        public async Task<IActionResult> GetAllTypePerson()
        {
            var result = await _service.PersonLogic.GetListTypePerson();
            return StatusCode(StatusCodes.Status200OK, result);
        }

        [Authorize]
        [HttpGet("type-phone")]
        public async Task<IActionResult> GetAllTypePhone()
        {
            var result = await _service.PersonLogic.GetListTypePhone();
            return StatusCode(StatusCodes.Status200OK, result);
        }
    }
}