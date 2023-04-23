namespace WebAppHosting.Controllers
{
    public sealed class TypeEmailController : ApiBaseController
    {
        public readonly IServiceManager _service;
        public TypeEmailController(IServiceManager service)
        {
            _service = service;
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] TypeEmailDTO email)
        {
            if (email == null)
                return StatusCode(StatusCodes.Status400BadRequest, "El Objecto es incorrrecto");

            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            var result = await _service.TypeEmailLogic.AddAsync(email, GetUserNameSeccion());
            return StatusCode(StatusCodes.Status201Created, result);
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetAll([FromBody] string email)
        {
            var result = await _service.TypeEmailLogic.GetList();
            return StatusCode(StatusCodes.Status200OK, result);
        }
    }
}
