/*
Базовая реализация ViewModel с поддержкой уведомлений об изменениях.

Используется:
- Для наследования другими ViewModel (например, MainViewModel)
- Предоставляет метод OnPropertyChanged для уведомления UI

Основные компоненты:
- Интерфейс INotifyPropertyChanged
- Метод OnPropertyChanged: уведомляет об изменении свойства

Пример:
    public string Name {
        get => _name;
        set {
            _name = value;
            OnPropertyChanged();
        }
    }
*/

using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AccountingOfOfficeEquipment.ViewModels
{
    /// <summary>
    /// Базовый класс для всех ViewModel с реализацией INotifyPropertyChanged.
    /// </summary>
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        /// <summary>
        /// Уведомляет об изменении указанного свойства.
        /// </summary>
        protected void OnPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}