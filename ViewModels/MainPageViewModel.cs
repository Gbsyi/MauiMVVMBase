using System;
using ViewModels.Commands.QuickCommands;

namespace ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel()
        {
            _counter = 1;
            _addNumber = new(Plus);
        }
        private int _counter;
        public int Counter
        {
            get => _counter;
            set => Set(ref _counter, value);

        }
        private Command _addNumber;
        public Command AddNumber
        {
            get => _addNumber;
        }
        private void Plus()
        {
            Counter++;
        }
    }
}
