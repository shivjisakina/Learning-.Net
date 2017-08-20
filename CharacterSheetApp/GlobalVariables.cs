/* Use these SPARINGLY because they cause problems but Codeschool did it this way because Databases werent in the course */

using System.Collections.Generic;
using CharacterSheetApp.Models;
using System;

namespace CharacterSheetApp
{
  public static class GlobalVariables
  {
    public static List<Equipment> Equipment { get; set; } 
      = new List<Equipment>();
  }
}