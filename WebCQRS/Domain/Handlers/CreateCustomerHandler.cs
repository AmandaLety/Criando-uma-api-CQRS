using System;
using WebCQRS.Domain.Commands.Handlers;
using WebCQRS.Domain.Commands.Requests;
using WebCQRS.Domain.Commands.Responses;

namespace WebCQRS.Domain.Commands.Handlers
{
    public class CreateCustomerHandler : ICreateCustomerHandler
    {
        public CreateCustomerResponse Handle(CreateCustomerRequest request)
        {
            //Verifica se o cliente já está cadastrado
            //valida os dados
            //Insere o cliente
            //Envia E-mail de boas vindas
            return new CreateCustomerResponse
            {
                Id = Guid.NewGuid(),
                Name = "Amanda Letícia",
                Email = "amandalletycia@hotmail.com",
                Date = DateTime.Now
            };
        }
    }
}
