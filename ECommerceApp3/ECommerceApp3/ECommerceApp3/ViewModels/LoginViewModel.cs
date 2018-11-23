using ECommerceApp3.Services;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ECommerceApp3.ViewModels
{
    public class LoginViewModel
    {

        #region Attributes
        private NavigationService navigationService;
        private DialogService dialogService;
        #endregion

        #region Properties
        public string User { get; set; }
        public string Password { get; set; }
        public bool IsRemembered { get; set; }
        #endregion

        #region Contructors
        public LoginViewModel()
        {
            navigationService = new NavigationService();
            dialogService = new DialogService();
            IsRemembered = true;
        } 
        #endregion

        #region Commands
        public ICommand LoginCommand { get { return new RelayCommand(Login); } }
        #endregion

        #region Methods
        private async void Login()
        {
            if (string.IsNullOrEmpty(User))
            {
                await dialogService.ShowMessage("Error", "Debes introducir un usuario");
                return;
            }

            if (string.IsNullOrEmpty(User))
            {
                await dialogService.ShowMessage("Error", "Debes introducir una contraseña");
                return;
            }

            navigationService.SetMainPage();
        }  
        #endregion

    }
}
