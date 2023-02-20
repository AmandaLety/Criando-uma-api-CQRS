using System.Security.Principal;
using WebCQRS.Domain.Commands.Requests;
using WebCQRS.Domain.Commands.Responses;

namespace WebCQRS.Domain.Commands.Handlers
{
    public interface ICreateCustomerHandler
    {
       CreateCustomerResponse Handle(CreateCustomerRequest request);
    }
}
