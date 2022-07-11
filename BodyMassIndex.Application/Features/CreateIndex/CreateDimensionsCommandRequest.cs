using MediatR;

namespace BodyMassIndex.Application.Features.CreateIndex
{
    public class CreateDimensionsCommandRequest : IRequest<CreateDimensionsCommandResponse>
    {
        public double Weigth { get; set; }
        public double Heigth { get; set; }
    }
}
