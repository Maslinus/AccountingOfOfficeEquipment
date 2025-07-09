using System;
using System.Collections.Generic;

namespace AccountingOfOfficeEquipment.Models
{
    public static class EnumHelper
    {
        public static Array GetValues(Type enumType) => Enum.GetValues(enumType);

        public static IEnumerable<EquipmentType> EquipmentTypeValues => (EquipmentType[])Enum.GetValues(typeof(EquipmentType));
        public static IEnumerable<EquipmentStatus> EquipmentStatusValues => (EquipmentStatus[])Enum.GetValues(typeof(EquipmentStatus));
    }
}