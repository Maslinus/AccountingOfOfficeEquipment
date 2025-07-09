using AccountingOfOfficeEquipment.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace AccountingOfOfficeEquipment.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private readonly DataService _dataService;
        public ObservableCollection<OfficeEquipment> Equipment => _dataService.Equipment;

        public ICommand AddCommand { get; }
        public ICommand RemoveCommand { get; }

        private OfficeEquipment? _selectedEquipment;
        public OfficeEquipment? SelectedEquipment
        {
            get => _selectedEquipment;
            set { _selectedEquipment = value; OnPropertyChanged(); }
        }

        public MainViewModel()
        {
            _dataService = new DataService();
            AddCommand = new RelayCommand(AddEquipment);
            RemoveCommand = new RelayCommand(RemoveEquipment, () => SelectedEquipment != null);
        }

        private void AddEquipment()
        {
            var newEq = new OfficeEquipment
            {
                Name = "New Equipment",
                Type = EquipmentType.Printer,
                Status = EquipmentStatus.InStock
            };
            _dataService.AddEquipment(newEq);
        }

        private void RemoveEquipment()
        {
            if (SelectedEquipment != null)
                _dataService.RemoveEquipment(SelectedEquipment);
        }
    }
}
