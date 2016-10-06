using System.Collections.Generic;
using Newtonsoft.Json;

namespace VizceralAPI.Models
{
  public class Node
  {
    public string name { get; set; }
    public string renderer { get; set; }
    public object updated { get; set; }
    public IList<Node> nodes { get; set; }
    
    [JsonProperty("class")]
    public string objectClass { get; set; }
    public IList<Connection> connections { get; set; }
    public double? maxVolume { get; set; }
    public Props props { get; set; }
  }
}