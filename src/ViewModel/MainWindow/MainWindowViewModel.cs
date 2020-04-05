using Muffin.Common.Base;
using Muffin.Common.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Muffin.ViewModel.MainWindow
{
    class MainWindowViewModel : ClosableViewModel
    {
        #region Properties
        private UserControl _currentPage;
        public UserControl CurrentPage
        {
            get { return _currentPage; }
            set { SetProperty(ref _currentPage, value, () => CurrentPage); }
        }
        #endregion Properties

        #region Commands
        public ICommand CloseCommand { get; private set; }
        #endregion Commands

        // Constructor
        public MainWindowViewModel()
        {
            CloseCommand = new RelayCommand(x =>
            {
                Application.Current.Shutdown();
            });
        }
    }
}
