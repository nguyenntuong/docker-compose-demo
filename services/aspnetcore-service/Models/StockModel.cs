using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace aspnetcore_service.Models
{
    public class StockModel
    {
        [JsonPropertyName("stocks")]
        public List<string> Stocks { get; set; }
    }
}
