using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using SistemaGestaoDeBovinos.Services;

namespace SistemaGestaoDeBovinos
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            NavigationService.Frame = ContentFrame;
        }

        private void NavView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            if (args.IsSettingsInvoked)
            {
                // Navigate to settings page
            }
            else
            {
                var item = args.InvokedItemContainer;
                if (item != null)
                {
                    var tag = item.Tag.ToString();
                    switch (tag)
                    {
                        case "dashboard":
                            ContentFrame.Navigate(typeof(Views.DashboardView));
                            break;
                        case "animais":
                            ContentFrame.Navigate(typeof(Views.AnimalView));
                            break;
                        case "lotes":
                            ContentFrame.Navigate(typeof(Views.LoteView));
                            break;
                        case "pastos":
                            ContentFrame.Navigate(typeof(Views.PastoView));
                            break;
                        case "estoque":
                            ContentFrame.Navigate(typeof(Views.EstoqueView));
                            break;
                        case "financeiro":
                            ContentFrame.Navigate(typeof(Views.FinanceiroView));
                            break;
                        case "relatorios":
                            ContentFrame.Navigate(typeof(Views.RelatorioView));
                            break;
                    }
                }
            }
        }
    }
}
