using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModels.Commands.AsyncCommands
{
    public interface IAsyncCommand : ICommand
    {
        Task ExecuteAsync();
        bool CanExecute();
    }
}