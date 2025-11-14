using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SistemaGestaoDeBovinos.Models;
using SistemaGestaoDeBovinos.Services;
using SistemaGestaoDeBovinos.Views;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaGestaoDeBovinos.ViewModels
{
    public partial class AddEditPastoViewModel : ObservableObject
    {
        private readonly PastoService _pastoService;

        [ObservableProperty]
        private Pasto _pasto;

        public List<PastoStatus> StatusOptions { get; } = Enum.GetValues(typeof(PastoStatus)).Cast<PastoStatus>().ToList();

        public AddEditPastoViewModel(Pasto pasto = null)
        {
            _pastoService = new PastoService();
            Pasto = pasto ?? new Pasto();
        }

        [RelayCommand]
        private void Save()
        {
            if (Pasto.Id == 0)
            {
                _pastoService.Add(Pasto);
            }
            else
            {
                _pastoService.Update(Pasto);
            }
            NavigationService.Navigate(typeof(PastoView));
        }

        [RelayCommand]
        private void Cancel()
        {
            NavigationService.Navigate(typeof(PastoView));
        }
    }
}
