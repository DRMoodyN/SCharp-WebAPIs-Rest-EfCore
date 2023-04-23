namespace WebAppHosting.Controllers.Authentication
{
    public sealed class Authentication : ApiBaseController
    {
        private readonly IServiceManager _service;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;

        public Authentication(IServiceManager service, IMapper mapper, UserManager<User> manager)
        {
            _service = service;
            _mapper = mapper;
            _userManager = manager;
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterUser([FromBody] UserRegister model)
        {
            if (model == null)
                return StatusCode(StatusCodes.Status400BadRequest, "El Objecto es incorrrecto");

            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            User user = _mapper.Map<User>(model);

            var result = await _userManager.CreateAsync(user, model.Password);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }
                return BadRequest(ModelState);
            }

            await _userManager.AddToRolesAsync(user, model.Role);

            return StatusCode(201, "Usuario Creado Correctamente");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] Login model)
        {
            if (!await _service.AuthenticationLogic.ValidateUserAsync(model))
                return Unauthorized("El usuario es incorrecto");

            var token = await _service.AuthenticationLogic.CreateTokenAsync();

            return StatusCode(200, new { token = token });
        }
    }
}