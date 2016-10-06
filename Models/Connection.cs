
using System.Collections.Generic;
using Newtonsoft.Json;

namespace VizceralAPI.Models
{
  public class Connection
  {
      public string source { get; set; }
      public string target { get; set; }
      public IList<Metrics> metrics { get; set; }
      public IList<object> notices { get; set; }
      
      [JsonProperty("class")]
      public string objectClass { get; set; }
  }
}