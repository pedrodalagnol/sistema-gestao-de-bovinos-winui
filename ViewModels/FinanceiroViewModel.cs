using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SistemaGestaoDeBovinos.Models;
using SistemaGestaoDeBovinos.Services;
using SistemaGestaoDeBovinos.Views;
using System.Collections.ObjectModel;

namespace SistemaGestaoDeBovinos.ViewModels
{
    public partial class FinanceiroViewModel : ObservableObject
    {
        private readonly FinanceiroService _financeiroService;

        [ObservableProperty]
        private ObservableCollection<Financeiro> _financeiros;

        [ObservableProperty]
        private Financeiro _selectedFinanceiro;

        public FinanceiroViewModel()
        {
            _financeiroService = new FinanceiroService();
            LoadFinanceiros();
        }

        private void LoadFinanceiros()
        {
            Financeiros = new ObservableCollection<Financeiro>(_financeiroService.GetAll());
        }

        [RelayCommand]
        private void Add()
        {
            NavigationService.Navigate(typeof(AddEditFinanceiroView));
        }

        [RelayCommand]
        private void Edit()
        {
            if (SelectedFinanceiro != null)
            {
                NavigationService.Frame.Navigate(typeof(AddEditFinanceiroView), SelectedFinanceiro);
            }
        }

        [RelayCommand]
        private void Delete()
        {
            if (SelectedFinanceiro != null)
            {
                _financeiroService.Delete(SelectedFinanceiro.Id);
                LoadFinanceiros();
            }
        }
    }
}
