using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerService.Core.ApplicationService.People.Commands.PersonCreate
{
    public class PersonCreateValidator : AbstractValidator<PersonCreateCommand>
    {
        public PersonCreateValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("first name is empty");
        }
    }

    public class MemberCreateValidator : AbstractValidator<PersonCreateCommand>
    {    
        public MemberCreateValidator()
        {

            RuleFor(c => c.FirstName).NotEmpty().WithMessage("لطفا نام را پر کنید")
                .MinimumLength(2).WithMessage("نام نمیتواند کمتر از دو کاراکتر باشد")
                .MaximumLength(50).WithMessage("نام نمیتواند بیشتر از 50 کاراکتر باشد.");

            RuleFor(c => c.LastName).NotEmpty().WithMessage("")
                .MinimumLength(2).WithMessage("")
                .MaximumLength(70).WithMessage("");

            RuleFor(c => c.FatherName).NotEmpty().WithMessage("")
                .MinimumLength(2).WithMessage("")
                .MaximumLength(50).WithMessage("");        

            RuleFor(c => c.BirthDate).NotEmpty().WithMessage("");

            RuleFor(c => c.ZipCode)
                .MaximumLength(10).WithMessage("");

            RuleFor(c => c.CityId)
                .GreaterThanOrEqualTo(1).WithMessage("")
                .LessThanOrEqualTo(long.MaxValue).WithMessage("");           

            RuleFor(c => c.Mobile).NotEmpty().WithMessage("")
                .Length(11).WithMessage("");

        }
    }
}
