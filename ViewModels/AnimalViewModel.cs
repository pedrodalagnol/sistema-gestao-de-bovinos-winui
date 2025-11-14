using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SistemaGestaoDeBovinos.Models;
using SistemaGestaoDeBovinos.Services;
using SistemaGestaoDeBovinos.Views;
using System.Collections.ObjectModel;

namespace SistemaGestaoDeBovinos.ViewModels
{
    public partial class AnimalViewModel : ObservableObject
    {
        private readonly AnimalService _animalService;

        [ObservableProperty]
        private ObservableCollection<Animal> _animais;

        [ObservableProperty]
        private Animal _selectedAnimal;

        public AnimalViewModel()
        {
            _animalService = new AnimalService();
            LoadAnimais();
        }

        private void LoadAnimais()
        {
            Animais = new ObservableCollection<Animal>(_animalService.GetAll());
        }

        [RelayCommand]
        private void Add()
        {
            NavigationService.Navigate(typeof(AddEditAnimalView));
        }

        [RelayCommand]
        private void Edit()
        {
            if (SelectedAnimal != null)
            {
                NavigationService.Frame.Navigate(typeof(AddEditAnimalView), SelectedAnimal);
            }
        }

        [RelayCommand]
        private void Delete()
        {
            if (SelectedAnimal != null)
            {
                _animalService.Delete(SelectedAnimal.Id);
                LoadAnimais();
            }
        }
    }
}
