using Newtonsoft.Json;

namespace VizceralAPI.Models
{
  public class Status : Metrics 
  {
    [JsonProperty("warning")]
    public double? warning { get; set; }
  }
}