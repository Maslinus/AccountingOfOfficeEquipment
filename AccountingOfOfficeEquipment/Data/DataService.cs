using AccountingOfOfficeEquipment.Models;
using System.Collections.ObjectModel;

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
