using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fvaca.Checkout.Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
namespace fvaca.Checkout.PaymentGateway.Controllers
{
    [ApiController]
    [Route("api/paymentgateway")]
    public class PaymentController: ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetPayment(Guid id) => throw new NotImplementedException();

        [HttpPost("payment")]
        public IActionResult MakePayment(Payment payment) => throw new NotImplementedException();
    }
}
