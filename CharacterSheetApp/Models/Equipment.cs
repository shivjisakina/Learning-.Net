using System;

namespace CharacterSheetApp.Models
{
  public class Equipment
  {
    public String Name;
  }
}

/* Retaining Data (so it doesnt overwrite previous input)=============================================== */

using System.Collections.Generic;
using System;

namespace CharacterSheetApp.Models
{
  public class Equipment
  {
    public string Name;
    public static void Create(string EquipmentName)
    {
      var equipment = new Equipment();
      equipment.Name = EquipmentName;
      GlobalVariables.Equipment.Add(equipment);
    }
    public static List<Equipment> GetAll()
    {
      return GlobalVariables.Equipment;
    }
  }
}