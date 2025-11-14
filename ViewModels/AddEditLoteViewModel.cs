using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SistemaGestaoDeBovinos.Models;
using SistemaGestaoDeBovinos.Services;
using SistemaGestaoDeBovinos.Views;

namespace SistemaGestaoDeBovinos.ViewModels
{
    public partial class AddEditLoteViewModel : ObservableObject
    {
        private readonly LoteService _loteService;

        [ObservableProperty]
        private Lote _lote;

        public AddEditLoteViewModel(Lote lote = null)
        {
            _loteService = new LoteService();
            Lote = lote ?? new Lote();
        }

        [RelayCommand]
        private void Save()
        {
            if (Lote.Id == 0)
            {
                _loteService.Add(Lote);
            }
            else
            {
                _loteService.Update(Lote);
            }
            NavigationService.Navigate(typeof(LoteView));
        }

        [RelayCommand]
        private void Cancel()
        {
            NavigationService.Navigate(typeof(LoteView));
        }
    }
}
