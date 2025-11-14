using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SistemaGestaoDeBovinos.Models;
using SistemaGestaoDeBovinos.Services;
using SistemaGestaoDeBovinos.Views;

namespace SistemaGestaoDeBovinos.ViewModels
{
    public partial class AddEditFinanceiroViewModel : ObservableObject
    {
        private readonly FinanceiroService _financeiroService;

        [ObservableProperty]
        private Financeiro _financeiro;

        public AddEditFinanceiroViewModel(Financeiro financeiro = null)
        {
            _financeiroService = new FinanceiroService();
            Financeiro = financeiro ?? new Financeiro();
        }

        [RelayCommand]
        private void Save()
        {
            if (Financeiro.Id == 0)
            {
                _financeiroService.Add(Financeiro);
            }
            else
            {
                _financeiroService.Update(Financeiro);
            }
            NavigationService.Navigate(typeof(FinanceiroView));
        }

        [RelayCommand]
        private void Cancel()
        {
            NavigationService.Navigate(typeof(FinanceiroView));
        }
    }
}
