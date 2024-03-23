using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace palindromo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PalindromoController : ControllerBase
    {

        public class TagViewModelEntrada
        {
            public string Texto { set; get; }
        }

        [HttpPost]
        public VerificarPalindromo Palindromo([FromBody] TagViewModelEntrada palavra)
        {
            return new VerificarPalindromo(palavra.Texto);
        }
    }
}
