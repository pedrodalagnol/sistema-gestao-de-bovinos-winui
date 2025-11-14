using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;
using SistemaGestaoDeBovinos.Models;
using SistemaGestaoDeBovinos.ViewModels;

namespace SistemaGestaoDeBovinos.Views
{
    public sealed partial class AddEditFinanceiroView : Page
    {
        public AddEditFinanceiroView()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            var financeiro = e.Parameter as Financeiro;
            DataContext = new AddEditFinanceiroViewModel(financeiro);
        }
    }
}
