using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;
using SistemaGestaoDeBovinos.Models;
using SistemaGestaoDeBovinos.ViewModels;

namespace SistemaGestaoDeBovinos.Views
{
    public sealed partial class AddEditAnimalView : Page
    {
        public AddEditAnimalView()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            var animal = e.Parameter as Animal;
            DataContext = new AddEditAnimalViewModel(animal);
        }
    }
}
