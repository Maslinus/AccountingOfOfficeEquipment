/*
Универсальная реализация ICommand для привязки команд к UI.

Используется для:
- Кнопок управления
- Условного выполнения команд (через _canExecute)

Пример:
    new RelayCommand(() => DoSomething(), () => CanDo);
*/
using System.Windows.Input;

namespace AccountingOfOfficeEquipment.ViewModels
{
    /// <summary>
    /// Реализация ICommand с поддержкой делегатов.
    /// </summary>
    public class RelayCommand : ICommand
    {
        private readonly Action _execute;
        private readonly Func<bool>? _canExecute;

        /// <summary>
        /// Создание команды с возможностью проверки условий выполнения.
        /// </summary>
        public RelayCommand(Action execute, Func<bool>? canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object? parameter) => _canExecute == null || _canExecute();
        public void Execute(object? parameter) => _execute();
        public event EventHandler? CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }
    }
}