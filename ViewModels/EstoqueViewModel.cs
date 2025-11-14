using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SistemaGestaoDeBovinos.Models;
using SistemaGestaoDeBovinos.Services;
using SistemaGestaoDeBovinos.Views;
using System.Collections.ObjectModel;

namespace SistemaGestaoDeBovinos.ViewModels
{
    public partial class EstoqueViewModel : ObservableObject
    {
        private readonly EstoqueService _estoqueService;

        [ObservableProperty]
        private ObservableCollection<Estoque> _estoques;

        [ObservableProperty]
        private Estoque _selectedEstoque;

        public EstoqueViewModel()
        {
            _estoqueService = new EstoqueService();
            LoadEstoques();
        }

        private void LoadEstoques()
        {
            Estoques = new ObservableCollection<Estoque>(_estoqueService.GetAll());
        }

        [RelayCommand]
        private void Add()
        {
            NavigationService.Navigate(typeof(AddEditEstoqueView));
        }

        [RelayCommand]
        private void Edit()
        {
            if (SelectedEstoque != null)
            {
                NavigationService.Frame.Navigate(typeof(AddEditEstoqueView), SelectedEstoque);
            }
        }

        [RelayCommand]
        private void Delete()
        {
            if (SelectedEstoque != null)
            {
                _estoqueService.Delete(SelectedEstoque.Id);
                LoadEstoques();
            }
        }
    }
}
