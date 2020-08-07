namespace DrSneuss.Models
{
  public class MachineEngineer
  {
    public int MachineEngineerId { get; set; }
    public int MachineId { get; set; }
    public int EngineerId { get; set; }
    public Machine machine { get; set; }
    public Engineer engineer { get; set; }
  }
}