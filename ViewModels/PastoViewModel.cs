using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SistemaGestaoDeBovinos.Models;
using SistemaGestaoDeBovinos.Services;
using SistemaGestaoDeBovinos.Views;
using System.Collections.ObjectModel;

namespace SistemaGestaoDeBovinos.ViewModels
{
    public partial class PastoViewModel : ObservableObject
    {
        private readonly PastoService _pastoService;

        [ObservableProperty]
        private ObservableCollection<Pasto> _pastos;

        [ObservableProperty]
        private Pasto _selectedPasto;

        public PastoViewModel()
        {
            _pastoService = new PastoService();
            LoadPastos();
        }

        private void LoadPastos()
        {
            Pastos = new ObservableCollection<Pasto>(_pastoService.GetAll());
        }

        [RelayCommand]
        private void Add()
        {
            NavigationService.Navigate(typeof(AddEditPastoView));
        }

        [RelayCommand]
        private void Edit()
        {
            if (SelectedPasto != null)
            {
                NavigationService.Frame.Navigate(typeof(AddEditPastoView), SelectedPasto);
            }
        }

        [RelayCommand]
        private void Delete()
        {
            if (SelectedPasto != null)
            {
                _pastoService.Delete(SelectedPasto.Id);
                LoadPastos();
            }
        }
    }
}
