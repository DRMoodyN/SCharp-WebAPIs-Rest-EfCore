namespace Services
{
    public sealed class AuthenticacionLogic : IAuthenticationLogic
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;
        private User _user;

        public AuthenticacionLogic(UserManager<User> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<string> CreateTokenAsync()
        {
            var signigCredential = GetSigningCredentials();
            var claims = await GetClaims();
            var token = GenerateTokenOptions(signigCredential, claims);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private async Task<List<Claim>> GetClaims()
        {
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name,_user.UserName)
            };

            var roles = await _userManager.GetRolesAsync(_user);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }
            return claims;
        }

        private JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims)
        {
            var tokenOptions = new JwtSecurityToken
            (
                issuer: "Development2023",
                audience: "https://localhost:7061",
                claims: claims,
                expires: DateTime.Now.AddMinutes(2),
                signingCredentials: signingCredentials
            );
            return tokenOptions;
        }

        private SigningCredentials GetSigningCredentials()
        {
            var key = Encoding.UTF8.GetBytes("D@vidSecrete2023#*");
            var secret = new SymmetricSecurityKey(key);
            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }
        public async Task<bool> ValidateUserAsync(Login model)
        {
            _user = await _userManager.FindByNameAsync(model.UserName);
            return (_user != null && await _userManager.CheckPasswordAsync(_user, model.Password));
        }
    }
}
