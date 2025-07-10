/*
MainViewModel.cs
================

ViewModel для главного окна приложения (MVVM паттерн).

Отвечает за:
- Представление ObservableCollection оборудования
- Обработку команд добавления и удаления
- Выбор текущей записи оборудования
- Связь с DataService

Пример использования:
    var vm = new MainViewModel();
    vm.AddCommand.Execute(null);
*/

using AccountingOfOfficeEquipment.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace AccountingOfOfficeEquipment.ViewModels
{
    /// <summary>
    /// ViewModel для основного окна.
    /// Содержит данные, команды и выделенный элемент.
    /// </summary>
    public class MainViewModel : BaseViewModel
    {
        private readonly DataService _dataService;
        public ObservableCollection<OfficeEquipment> Equipment => _dataService.Equipment;

        public ICommand AddCommand { get; }
        public ICommand RemoveCommand { get; }

        private OfficeEquipment? _selectedEquipment;
        /// <summary>
        /// Выбранное в UI оборудование.
        /// Используется для удаления.
        /// </summary>
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

        /// <summary>
        /// Добавление новой записи (с шаблонными значениями).
        /// </summary>
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

        /// <summary>
        /// Удаление выбранного оборудования.
        /// </summary>
        private void RemoveEquipment()
        {
            if (SelectedEquipment != null)
                _dataService.RemoveEquipment(SelectedEquipment);
        }
    }
}
