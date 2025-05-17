using System.Text.Json.Serialization;

namespace AgentProtocol.Sdk.Models.Task;

public class TaskListResponse
{
    [JsonPropertyName("tasks")]
    public List<AgentTask> Tasks { get; set; }
    
    [JsonPropertyName("pagination")]
    public Pagination Pagination { get; set; }
}