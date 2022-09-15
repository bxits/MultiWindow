using MultiWindow.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MultiWindow.Helper
{
    public class UpdateViewCommand : ICommand
    {
        MainViewModel viewModel;
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            if (parameter.ToString() == "Home")
                viewModel.SelectedViewModel = new HomeViewModel();
            else if (parameter.ToString() == "List")
                viewModel.SelectedViewModel = new ListViewModel();
        }
    }
}
