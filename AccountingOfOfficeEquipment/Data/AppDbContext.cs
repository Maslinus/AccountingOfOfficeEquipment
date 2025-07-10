/*
Контекст взаимодействия с базой данных для приложения учета офисного оборудования.

Этот класс реализует доступ к базе данных SQLite через Entity Framework Core.
Он содержит:
- Определение таблиц через DbSet
- Настройку подключения к базе данных
- Поддержку миграций и создания базы при необходимости

Компоненты:
- AppDbContext: основной класс контекста EF
- DbSet<OfficeEquipment>: таблица с данными об оборудовании
- OnConfiguring: настройка подключения (используется SQLite)

Пример использования:
   using var context = new AppDbContext();
   var allEquipment = context.Equipment.ToList();
*/

using AccountingOfOfficeEquipment.Models;
using Microsoft.EntityFrameworkCore;

/// <summary>
/// Контекст базы данных для работы с оборудованием.
/// Использует SQLite и Entity Framework Core.
/// </summary>
public class AppDbContext : DbContext
{
    public DbSet<OfficeEquipment> Equipment { get; set; }

    /// <summary>
    /// Конфигурация строки подключения (используется SQLite).
    /// </summary>
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlite("Data Source=equipment.db");
        }
    }
}