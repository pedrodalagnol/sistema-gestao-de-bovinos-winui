using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;
using SistemaGestaoDeBovinos.Models;
using SistemaGestaoDeBovinos.ViewModels;

namespace SistemaGestaoDeBovinos.Views
{
    public sealed partial class AddEditLoteView : Page
    {
        public AddEditLoteView()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            var lote = e.Parameter as Lote;
            DataContext = new AddEditLoteViewModel(lote);
        }
    }
}
