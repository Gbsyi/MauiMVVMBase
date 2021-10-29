using System;

namespace ViewModels.Commands
{
    public interface IErrorHandler
    {
        void HandleError(Exception ex);
    }
}
