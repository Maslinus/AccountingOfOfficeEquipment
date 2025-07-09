using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccountingOfOfficeEquipment.Models
{
    public enum EquipmentType { Printer, Scanner, Monitor }
    public enum EquipmentStatus { InUse, InStock, UnderRepair }

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
