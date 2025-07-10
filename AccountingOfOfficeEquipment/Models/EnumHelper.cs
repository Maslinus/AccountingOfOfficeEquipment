/*
Вспомогательный класс для предоставления значений перечислений в XAML.

Используется:
- Для заполнения ComboBox в DataGrid
- Через ObjectDataProvider в App.xaml

Пример:
    <ObjectDataProvider x:Key="EquipmentTypeValues"
                        MethodName="GetValues"
                        ObjectType="{x:Type sys:Enum}">
        <ObjectDataProvider.MethodParameters>
            <x:Type TypeName="models:EquipmentType"/>
        </ObjectDataProvider.MethodParameters>
    </ObjectDataProvider>
*/
using System;
using System.Collections.Generic;

namespace AccountingOfOfficeEquipment.Models
{
    public static class EnumHelper
    {
        /// <summary>
        /// Получение всех значений перечисления.
        /// </summary>
        public static Array GetValues(Type enumType) => Enum.GetValues(enumType);

        public static IEnumerable<EquipmentType> EquipmentTypeValues => (EquipmentType[])Enum.GetValues(typeof(EquipmentType));
        public static IEnumerable<EquipmentStatus> EquipmentStatusValues => (EquipmentStatus[])Enum.GetValues(typeof(EquipmentStatus));
    }
}