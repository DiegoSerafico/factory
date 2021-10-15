using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }

    public int EngineerId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public virtual ICollection<EngineerMachine> JoinEntities { get; set; }

    // private List<Engineer> GetEngineers()
    // {
    //   List<Engineer> engineers = new List<Engineer>();
    //   return engineers;
    // }
  }
}