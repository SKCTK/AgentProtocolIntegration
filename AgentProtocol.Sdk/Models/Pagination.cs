using System.Text.Json.Serialization;

namespace AgentProtocol.Sdk.Models;

public class Pagination
{
    [JsonPropertyName("total_items")]
    public int TotalItems { get; set; }
    
    [JsonPropertyName("total_pages")]
    public int TotalPages { get; set; }
    
    [JsonPropertyName("current_page")]
    public int CurrentPage { get; set; }
    
    [JsonPropertyName("page_size")]
    public int PageSize { get; set; }
}