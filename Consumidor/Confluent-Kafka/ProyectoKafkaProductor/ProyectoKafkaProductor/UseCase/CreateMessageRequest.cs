using MediatR;

namespace ProyectoKafkaProductor.UseCase
{
    public class CreateMessageRequest : IRequest<Response<string>>
    {
        public string Message { get; set; } 
    }

    public class CreateMessageHandler : IRequestHandler<CreateMessageRequest, Response<string>>
    {
        public Task<Response<string>> Handle(CreateMessageRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
