using System.Collections.Generic;

namespace DrSneuss.Models
{
  public class Machine
  {
    public Machine()
    {
      this.Engineers = new HashSet<MachineEngineer>();
    }

    public int MachineId { get; set; }
    public string MachineName { get; set; }
    public virtual ICollection<MachineEngineer> Engineers { get; set; }
  }
}