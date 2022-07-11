using FluentValidation;

namespace BodyMassIndex.Application.Features.CreateIndex
{
    public class CreateDimensionsCommandValidator : AbstractValidator<CreateDimensionsCommandRequest>
    {
        public CreateDimensionsCommandValidator()
        {
            RuleFor(x => x.Heigth).NotEmpty().WithMessage("Can not be empty").GreaterThan(10).LessThan(230).WithMessage("Must between 10 and 230");
            RuleFor(x => x.Weigth).NotEmpty().WithMessage("Can not be empty!").GreaterThan(10).LessThan(230).WithMessage("Must between 10 and 230");
        }
    }
}
