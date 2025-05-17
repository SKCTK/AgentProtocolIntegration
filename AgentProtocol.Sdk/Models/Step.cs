using System.Text.Json.Serialization;
using AgentProtocol.Sdk.Models.Enums;

namespace AgentProtocol.Sdk.Models;

// TODO: add xml annotations to all types
public class Step
{
    [JsonPropertyName("step_id")]
    public string StepId { get; set; }
    
    [JsonPropertyName("task_id")]
    public string TaskId { get; set; }
    
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    [JsonPropertyName("status")]
    public StepStatus Status { get; set; }
    
    [JsonPropertyName("input")]
    public string Input { get; set; }
    
    [JsonPropertyName("additional_input")]
    public object? AdditionalInput { get; set; }
    
    [JsonPropertyName("output")]
    public string Output { get; set; }
    
    [JsonPropertyName("additional_output")]
    public object? AdditionalOutput { get; set; }
    
    [JsonPropertyName("is_last")]
    public bool IsLast { get; set; }
    
    [JsonPropertyName("artifacts")]
    public List<Artifact>? Artifacts { get; set; }
}