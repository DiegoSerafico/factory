using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Machine
  {
    public class Machine
    {
      public Engineer()
      {
        this.JoinEntities = new HashSet<EngineerMachine>();
      }

      public int MachineId { get; set; }
      public string Model { get; set; }

      [DisplayFormat(DataFormatString = "{0:MMMM dd, yyyy}")]
      public DateTime ManufactureDate { get; set; }
    }
  }
}