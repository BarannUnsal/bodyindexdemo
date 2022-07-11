using BodyMassIndex.Application.Repositories;
using MediatR;

namespace BodyMassIndex.Application.Features.CreateIndex
{
    public class CreateDimensionsCommandHandler : IRequestHandler<CreateDimensionsCommandRequest, CreateDimensionsCommandResponse>
    {
        readonly IDimensionsRepository _repository;

        public CreateDimensionsCommandHandler(IDimensionsRepository repository)
        {
            _repository = repository;
        }

        public async Task<CreateDimensionsCommandResponse> Handle(CreateDimensionsCommandRequest request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new()
            {
                Heigth = request.Heigth,
                Weigth = request.Weigth
            });

            await _repository.SaveAsync();
            return new();
        }
    }
}
