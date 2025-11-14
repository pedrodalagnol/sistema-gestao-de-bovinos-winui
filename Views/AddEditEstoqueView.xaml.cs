using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;
using SistemaGestaoDeBovinos.Models;
using SistemaGestaoDeBovinos.ViewModels;

namespace SistemaGestaoDeBovinos.Views
{
    public sealed partial class AddEditEstoqueView : Page
    {
        public AddEditEstoqueView()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            var estoque = e.Parameter as Estoque;
            DataContext = new AddEditEstoqueViewModel(estoque);
        }
    }
}
