using System;

namespace ViewModels.Commands
{
    public interface IErrorCancelHandler : IErrorHandler
    {
        void HandleCancel(OperationCanceledException ex);
    }
}
