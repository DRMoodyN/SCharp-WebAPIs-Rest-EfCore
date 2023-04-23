namespace WebAppHosting.Controllers
{
    public class TypePersonController : ApiBaseController
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
                return StatusCode(StatusCodes.Status400BadRequest, "El Objecto es incorrrecto");

            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            var result = await _service.TypePersonLogic.AddAsync(model);
            return StatusCode(201, result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _service.TypePersonLogic.GetList();
            return StatusCode(200, result);
        }

        [HttpDelete("{id}"), Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _service.TypePersonLogic.DeleteLogic(id);
            return StatusCode(200, result);
        }

        [HttpPut("{id}"), Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Update(int id, [FromBody] TypePersonEntity model)
        {
            if (model == null)
                return StatusCode(StatusCodes.Status400BadRequest, "El Objecto es incorrrecto");

            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            var result = await _service.TypePersonLogic.Update(id, model);
            return StatusCode(201, result);
        }
    }
}
