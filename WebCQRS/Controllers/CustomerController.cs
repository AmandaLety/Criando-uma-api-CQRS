using Microsoft.AspNetCore.Mvc;
using WebCQRS.Domain.Commands.Handlers;
using WebCQRS.Domain.Commands.Requests;
using WebCQRS.Domain.Commands.Responses;

namespace WebCQRS.Controllers
{
    [ApiController]
    [Route("v1/customers")]
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public CreateCustomerResponse Create(
          [FromServices]ICreateCustomerHandler handler,
          [FromBody]CreateCustomerRequest command
        )
        {
            return handler.Handle(command);
        }
    }
}
