using ECommerceApp3.Pages;
using System;
using System.Threading.Tasks;

namespace ECommerceApp3.Services
{
    public class NavigationService
    {
        public async Task Navigate(string pageName)
        {
            App.Master.IsPresented = false;

            switch(pageName)
            {
                case "CostumersPage":
                    await App.Navigator.PushAsync(new CostumersPage());
                    break;
                case "DeliveriesPage":
                    await App.Navigator.PushAsync(new DeliveriesPage());
                    break;
                case "OrdersPage":
                    await App.Navigator.PushAsync(new OrdersPage());
                    break;
                case "ProductsPages":
                    await App.Navigator.PushAsync(new ProductsPages());
                    break;
                case "SetupPage":
                    await App.Navigator.PushAsync(new SetupPage());
                    break;
                case "SyncPage":
                    await App.Navigator.PushAsync(new SyncPage());
                    break;
                case "UserPage":
                    await App.Navigator.PushAsync(new UserPage());
                    break;
                default:
                    break;
            }
        }

        internal void SetMainPage()
        {
            App.Current.MainPage = new MasterPage();
        }
    }
}
