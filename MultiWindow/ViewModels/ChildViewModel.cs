using MultiWindow.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MultiWindow.ViewModels
{
    class ChildViewModel
    {
        ICommand _buttonDoItCommand;
        public ChildViewModel()
        {

        }

        public ICommand ButtonDoItCommand
        {
            get
            {
                if (_buttonDoItCommand == null)
                    return _buttonDoItCommand = new RelayCommand(c => MyOwnBusiness());
                else
                    return _buttonDoItCommand;

            }
        }

        public void MyOwnBusiness()
        {

        }
    }
}
