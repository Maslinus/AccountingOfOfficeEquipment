/*
Модели и перечисления для учета офисного оборудования.

Этот файл определяет:
- Перечисления типов и статусов оборудования
- Класс OfficeEquipment, отражающий структуру таблицы в БД

Применение:
- Используется Entity Framework для сопоставления с таблицей
- Класс участвует в отображении данных в UI через привязку

Компоненты:
- EquipmentType: тип оборудования (Принтер, Сканер, Монитор)
- EquipmentStatus: статус (В использовании, На складе, В ремонте)
- OfficeEquipment: модель данных с атрибутами валидации

Пример:
    var printer = new OfficeEquipment {
        Name = "HP LaserJet",
        Type = EquipmentType.Printer,
        Status = EquipmentStatus.InStock
    };
*/

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccountingOfOfficeEquipment.Models
{
    public enum EquipmentType { Printer, Scanner, Monitor }
    public enum EquipmentStatus { InUse, InStock, UnderRepair }

    /// <summary>
    /// Модель, представляющая единицу офисного оборудования.
    /// Используется в Entity Framework для создания таблицы.
    /// </summary>
    public class OfficeEquipment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;
        public EquipmentType Type { get; set; }
        public EquipmentStatus Status { get; set; }
    }
}