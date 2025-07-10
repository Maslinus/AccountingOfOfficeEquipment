/*
Сервис доступа к данным оборудования.

Этот класс инкапсулирует работу с базой данных:
- Загружает все данные в коллекцию
- Добавляет и удаляет записи из БД и коллекции
- Обеспечивает связь между UI и EF

Применение:
- Используется во ViewModel для отображения и управления списком оборудования

Компоненты:
- DataService: сервис для операций с БД
- ObservableCollection<OfficeEquipment>: привязка к UI

Пример:
    var service = new DataService();
    service.AddEquipment(new OfficeEquipment { Name = "New", ... });
*/

using AccountingOfOfficeEquipment.Models;
using System.Collections.ObjectModel;

/// <summary>
/// Класс для работы с данными.
/// Управляет базой данных и синхронизирует коллекцию для UI.
/// </summary>
public class DataService
{
    private readonly AppDbContext _context;
    public ObservableCollection<OfficeEquipment> Equipment { get; private set; }

    public DataService()
    {
        _context = new AppDbContext();
        _context.Database.EnsureCreated();
        Equipment = new ObservableCollection<OfficeEquipment>(_context.Equipment.ToList());
    }

    public void AddEquipment(OfficeEquipment eq)
    {
        _context.Equipment.Add(eq);
        _context.SaveChanges();
        Equipment.Add(eq);
    }

    public void RemoveEquipment(OfficeEquipment eq)
    {
        _context.Equipment.Remove(eq);
        _context.SaveChanges();
        Equipment.Remove(eq);
    }
}
