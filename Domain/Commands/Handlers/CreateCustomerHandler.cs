using MediatR;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Commands.Responses;

namespace Shop.Domain.Commands.Handlers {
    public class CreateCustomerHandler: 
    IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>{
        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            //Verifica se o cliente já existe
            //Valida os dados
            //Insere o cliente
            //Envia E-mail de cadastro
            var result = new CreateCustomerResponse{
                Id = Guid.NewGuid(),
                Name = "Leonardo",
                Email = "leo@algo.com",
                Date = DateTime.Now
            };

            return Task.FromResult(result);
        }
    }
}