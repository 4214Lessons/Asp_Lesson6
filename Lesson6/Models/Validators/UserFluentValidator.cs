using FluentValidation;

namespace Lesson6.Models.Validators
{
    public class UserFluentValidator : AbstractValidator<User>
    {
        public UserFluentValidator()
        {
            RuleFor(user => user.Email).EmailAddress().WithMessage("Maili duzgun yaz");
            RuleFor(u => u.Age).NotEmpty().WithMessage("Bosh ola bilmez");
            RuleFor(u => u.Rating).LessThanOrEqualTo(5).WithMessage("max 5");
        }
    }
}
