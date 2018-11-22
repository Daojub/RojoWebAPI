using ECommerceApp3.Services;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ECommerceApp3.ViewModels
{
    public class MenuItemViewModel
    {

        #region Atributes
        public NavigationService navigationService;
        #endregion

        #region Properties
        public string Icon { get; set; }
        public string Title { get; set; }
        public string PageName { get; set; }
        #endregion

        #region Constructor
        public MenuItemViewModel()
        {
            navigationService = new NavigationService();
        } 
        #endregion

        #region Commands
        public ICommand NavigateCommand { get { return new RelayCommand(Navigate); } }
        #endregion

        private async void Navigate()
        {
            await navigationService.Navigate(PageName);
        }
        


    }
}
