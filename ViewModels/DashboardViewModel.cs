using CommunityToolkit.Mvvm.ComponentModel;
using SistemaGestaoDeBovinos.Services;

namespace SistemaGestaoDeBovinos.ViewModels
{
    public partial class DashboardViewModel : ObservableObject
    {
        private readonly AnimalService _animalService;
        private readonly LoteService _loteService;
        private readonly PastoService _pastoService;

        [ObservableProperty]
        private int _numeroDeAnimais;

        [ObservableProperty]
        private int _numeroDeLotes;

        [ObservableProperty]
        private int _numeroDePastos;

        public DashboardViewModel()
        {
            _animalService = new AnimalService();
            _loteService = new LoteService();
            _pastoService = new PastoService();

            NumeroDeAnimais = _animalService.GetAll().Count;
            NumeroDeLotes = _loteService.GetAll().Count;
            NumeroDePastos = _pastoService.GetAll().Count;
        }
    }
}
