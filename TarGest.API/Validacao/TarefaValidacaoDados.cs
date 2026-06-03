using FluentValidation;
using System.Data;
using TarGest.API.Entidades;

namespace TarGest.API.Validacao
{
    public class TarefaValidacaoDados: AbstractValidator<Tarefa>
    {
        public TarefaValidacaoDados()
        {
            RuleFor(x => x.tituloTarefa).NotEmpty().NotNull().WithMessage("O título do livro não pode ser nulo");

        }
    }
}
