# AccountingOfOfficeEquipment
Приложение для учета офисного оборудования с возможностью добавления, удаления и редактирования записей.

## Описание
* **Платформа:** .NET (WPF)
* **Архитектура:** MVVM
* **База данных:** SQLite (через Entity Framework Core)

* **Функционал:**
  * Добавление и удаление оборудования
  * Редактирование полей
  * При нажатии на ячейки колонок **Тип** и **Статус** появляется выпадающее меню для выбора значений
  
* **Поля оборудования:**
  * Наименование (string)
  * Тип (Printer, Scanner, Monitor)
  * Статус (InUse, InStock, UnderRepair)

* База данных создаётся и инициализируется при первом запуске

## Установка
1. Клонируйте репозиторий:
   `git clone https://github.com/Maslinus/AccountingOfOfficeEquipment.git`
2. Откройте решение в Visual Studio:
   `AccountingOfOfficeEquipment.sln`
3. Восстановите NuGet-пакеты:
    * Microsoft.EntityFrameworkCore (Основная библиотека для работы с Entity Framework Core)
    * Microsoft.EntityFrameworkCore.Sqlite (Провайдер EF Core для работы с SQLite)    
    * Microsoft.EntityFrameworkCore.Tools (Инструменты EF Core для миграций и управления базой данных из командной строки и Visual Studio)
4. Соберите и запустите приложение
