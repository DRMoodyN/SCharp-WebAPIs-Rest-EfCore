namespace WebAppHosting.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TypePersonController : ControllerBase
    {
        private IServiceManager _service;
        public TypePersonController(IServiceManager service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] TypePersonEntity model)
        {
            if (model == null)
            {
                return StatusCode(StatusCodes.Status400BadRequest, "El Objecto es incorrrecto");
            }

            if (!ModelState.IsValid)
            {
                return UnprocessableEntity(ModelState);
            }

            var result = await _service.TypePersonLogic.AddAsync(model);
            return StatusCode(200, result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _service.TypePersonLogic.GetList();
            return StatusCode(200, result);
        }
    }
}
