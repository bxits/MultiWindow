using MultiWindow.Helper;
using MultiWindow.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MultiWindow.ViewModels
{

    class MainViewModel
    {
        ICommand _openChildViewCommand;
        BaseViewModel _currentViewModel = new HomeViewModel();

        public MainViewModel()
        {

        }

        private ICommand UpdateViewCommand { get; set; }

        
        public BaseViewModel SelectedViewModel
        {
            get { return _currentViewModel; }
            set { _currentViewModel = value; }
        }

        public ICommand OpenChildViewCommand
        {
            get
            {
                if (_openChildViewCommand == null)
                    return _openChildViewCommand = new RelayCommand(c => OpenChildView());
                else
                    return _openChildViewCommand;
            }
        }

        public BaseViewModel CurrentViewModel { get => _currentViewModel; set => _currentViewModel = value; }

        private void OpenChildView()
        {
            ChildView cv = new ChildView();

            //ggf. Mit 
            //cv.DataContext = _preDefinedVieMModel;
            // einen vordefinierten DC bzw. ViewModel mitgeben.

            cv.ShowDialog();
        }
    }
}
