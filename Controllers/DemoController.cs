using Microsoft.AspNetCore.Mvc;

namespace Crisan_Melisa_Lab1_Master.Controllers
{
    public class DemoController : Controller
    {
        [Route("hello")]
        public string Hello()
        {
            return "Salut!";
        }

        [HttpGet("hello/{name}")]
        public string HelloByName(string name)
        {
            return $"Salut, {name}!";
        }

        [HttpGet("calc/{a:int}/{b:int}")]
        public string Calculate(int a, int b)
        {
            return $"Suma este: {a + b}";
        }

    }
}
