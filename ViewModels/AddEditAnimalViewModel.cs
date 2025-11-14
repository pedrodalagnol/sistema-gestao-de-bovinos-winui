using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SistemaGestaoDeBovinos.Models;
using SistemaGestaoDeBovinos.Services;
using SistemaGestaoDeBovinos.Views;

namespace SistemaGestaoDeBovinos.ViewModels
{
    public partial class AddEditAnimalViewModel : ObservableObject
    {
        private readonly AnimalService _animalService;

        [ObservableProperty]
        private Animal _animal;

        public AddEditAnimalViewModel(Animal animal = null)
        {
            _animalService = new AnimalService();
            Animal = animal ?? new Animal();
        }

        [RelayCommand]
        private void Save()
        {
            if (Animal.Id == 0)
            {
                _animalService.Add(Animal);
            }
            else
            {
                _animalService.Update(Animal);
            }
            NavigationService.Navigate(typeof(AnimalView));
        }

        [RelayCommand]
        private void Cancel()
        {
            NavigationService.Navigate(typeof(AnimalView));
        }
    }
}
