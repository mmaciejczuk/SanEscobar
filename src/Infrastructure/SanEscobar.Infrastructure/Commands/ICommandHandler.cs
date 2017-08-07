using System.Threading.Tasks;

namespace SanEscobar.Infrastructure.Commands
{
    public interface ICommandHandler<T> where T : ICommand
    {
        Task HandleAsync(T command);
    }
}
