using System.Collections.Generic;

namespace VizceralAPI.Models
{
  public class Traffic
  {
    public string renderer { get; set; }
    public string name { get; set; }
    public IList<Node> nodes { get; set; }
    public IList<Connection> connections { get; set; }
    public double maxVolume { get; set; }
    public long serverUpdateTime { get; set; }
  }
}