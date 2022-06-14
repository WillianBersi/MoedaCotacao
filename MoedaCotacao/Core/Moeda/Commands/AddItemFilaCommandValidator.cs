using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq; 
using System.Threading.Tasks;

namespace MoedaCotacao.Core.Moeda.Commands
{
    public class AddItemFilaCommandValidator : AbstractValidator<AddItemFilaCommand>
    {
        public AddItemFilaCommandValidator()
        {
            RuleFor(x => x.Moedas)
                .NotEmpty()
                .WithMessage("Dados da moeda obrigatório.");
        }
    }
}
