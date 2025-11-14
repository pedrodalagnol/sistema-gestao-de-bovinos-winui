using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SistemaGestaoDeBovinos.Models;
using SistemaGestaoDeBovinos.Services;
using SistemaGestaoDeBovinos.Views;

namespace SistemaGestaoDeBovinos.ViewModels
{
    public partial class AddEditEstoqueViewModel : ObservableObject
    {
        private readonly EstoqueService _estoqueService;

        [ObservableProperty]
        private Estoque _estoque;

        public AddEditEstoqueViewModel(Estoque estoque = null)
        {
            _estoqueService = new EstoqueService();
            Estoque = estoque ?? new Estoque();
        }

        [RelayCommand]
        private void Save()
        {
            if (Estoque.Id == 0)
            {
                _estoqueService.Add(Estoque);
            }
            else
            {
                _estoqueService.Update(Estoque);
            }
            NavigationService.Navigate(typeof(EstoqueView));
        }

        [RelayCommand]
        private void Cancel()
        {
            NavigationService.Navigate(typeof(EstoqueView));
        }
    }
}
