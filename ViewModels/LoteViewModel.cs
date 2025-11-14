using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SistemaGestaoDeBovinos.Models;
using SistemaGestaoDeBovinos.Services;
using SistemaGestaoDeBovinos.Views;
using System.Collections.ObjectModel;

namespace SistemaGestaoDeBovinos.ViewModels
{
    public partial class LoteViewModel : ObservableObject
    {
        private readonly LoteService _loteService;

        [ObservableProperty]
        private ObservableCollection<Lote> _lotes;

        [ObservableProperty]
        private Lote _selectedLote;

        public LoteViewModel()
        {
            _loteService = new LoteService();
            LoadLotes();
        }

        private void LoadLotes()
        {
            Lotes = new ObservableCollection<Lote>(_loteService.GetAll());
        }

        [RelayCommand]
        private void Add()
        {
            NavigationService.Navigate(typeof(AddEditLoteView));
        }

        [RelayCommand]
        private void Edit()
        {
            if (SelectedLote != null)
            {
                NavigationService.Frame.Navigate(typeof(AddEditLoteView), SelectedLote);
            }
        }

        [RelayCommand]
        private void Delete()
        {
            if (SelectedLote != null)
            {
                _loteService.Delete(SelectedLote.Id);
                LoadLotes();
            }
        }
    }
}
