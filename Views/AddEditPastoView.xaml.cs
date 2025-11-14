using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;
using SistemaGestaoDeBovinos.Models;
using SistemaGestaoDeBovinos.ViewModels;

namespace SistemaGestaoDeBovinos.Views
{
    public sealed partial class AddEditPastoView : Page
    {
        public AddEditPastoView()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            var pasto = e.Parameter as Pasto;
            DataContext = new AddEditPastoViewModel(pasto);
        }
    }
}
