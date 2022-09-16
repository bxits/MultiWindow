using MultiWindow.Helper;
using MultiWindow.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MultiWindow.ViewModels
{

    public class MainViewModel : INotifyPropertyChanged
    {
        ICommand _openChildViewCommand;
        BaseViewModel _currentViewModel = new HomeViewModel();

        public event PropertyChangedEventHandler PropertyChanged;

        public MainViewModel()
        {
            UpdateViewCommand = new UpdateViewCommand(this);
        }

        public ICommand UpdateViewCommand { get; set; }


        public BaseViewModel CurrentViewModel
        {
            get { return _currentViewModel; }
            set
            {
                _currentViewModel = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentViewModel"));
            }
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
