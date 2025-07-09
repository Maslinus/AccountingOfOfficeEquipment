using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AccountingOfOfficeEquipment
{
    public enum EquipmentStatus { В_пользовании, На_складе, На_ремонте };
    public enum EquipmentType { Принтер, Сканер, Монитор };
    internal class OfficeEquipment
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public EquipmentType Type { get; set; }
        public EquipmentStatus Status { get; set; }
    }
}
