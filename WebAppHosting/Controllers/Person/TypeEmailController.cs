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
            if (email is null)
                return StatusCode(StatusCodes.Status400BadRequest, "El Objecto es incorrrecto");

            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            var result = await _service.TypeEmailLogic.AddAsync(email, GetUserNameSeccion());
            return StatusCode(StatusCodes.Status201Created, result);
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _service.TypeEmailLogic.GetList();
            return StatusCode(StatusCodes.Status200OK, result);
        }

        [Authorize]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _service.TypeEmailLogic.DeleteLogic(id, GetUserNameSeccion());
            return StatusCode(StatusCodes.Status200OK, result);
        }

        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> Create(int id, [FromBody] TypeEmailDTO email)
        {
            if (email is null)
                return StatusCode(StatusCodes.Status400BadRequest, "El Objecto es incorrrecto");

            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            var result = await _service.TypeEmailLogic.Update(id, email, GetUserNameSeccion());
            return StatusCode(StatusCodes.Status201Created, result);
        }
    }
}