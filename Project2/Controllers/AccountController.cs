using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Project2.Data.DataEntities;
using Project2.Data.Repository;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Project2.Controllers
{
    public class AccountController : Controller
    {
        private IRepository<Customer> _customerRepository;
        public AccountController(IRepository<Customer>customers)
        {
            _customerRepository = customers;
        }
        public async Task<IActionResult> Register(string login , string password , string name)
        {
            var allCustomers = await _customerRepository.GetAllAsync();
            var customer = allCustomers.Where(c => c.Login == login && c.Password == password).FirstOrDefault();
            if(customer == null)
            {
                _customerRepository.Add(new Customer { CustomerName = name , Login = login , Password = password});
                return Ok();
            }
            return BadRequest();

        }
        public async Task<IActionResult> Login(string login, string password)
        {
           return await CreateToken(login, password);
        }
        public async Task<IActionResult> CreateToken(string login, string password)
        {
            var allCustomers = await _customerRepository.GetAllAsync();
            var customer = allCustomers.Where(c => c.Login == login && c.Password == password).FirstOrDefault();
            if (customer != null)
            {
                var claim = new List<Claim>() { new Claim(login, password) };
                var now = DateTime.Now;
                var jwt = new JwtSecurityToken(
                       issuer: AuthOptions.ISSUER,
                       audience: AuthOptions.AUDIENCE,
                       notBefore: now,
                       claims: claim,
                       signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));
                var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

                var response = new
                {
                    access_token = encodedJwt,
                    username = login
                };

                return Json(response);
            }
            return BadRequest();
        }
       
        public class AuthOptions
        {
            public const string ISSUER = "MyAuthServer"; // издатель токена
            public const string AUDIENCE = "MyAuthClient"; // потребитель токена
            const string KEY = "mysupersecret_secretkey!123";   // ключ для шифрации
            public static SymmetricSecurityKey GetSymmetricSecurityKey() =>
                new SymmetricSecurityKey(Encoding.UTF8.GetBytes(KEY));
        }
    }
}
