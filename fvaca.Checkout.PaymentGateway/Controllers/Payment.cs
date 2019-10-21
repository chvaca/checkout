using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
namespace fvaca.Checkout.PaymentGateway.Controllers
{
    [ApiController]
    [Route("api/paymentgateway")]
    public class Payment: ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetPayment(int id) => Ok("Hello world");

        [HttpPost("payment")]
        public IActionResult MakePayment(string payment) => throw new NotImplementedException();
    }
}
