using System.Text.Json.Serialization;

namespace AgentProtocol.Sdk.Models;

/// <summary> Task that defines specific goal for agent </summary>
public class AgentTask
{
    /// <summary> The Id of task. </summary> 
    [JsonPropertyName("task_id")]
    public string TaskId { get; set; }
    
    /// <summary> Input prompt for the task. </summary> 
    [JsonPropertyName("input")]
    public string Input { get; set; }
    
    // TODO: find out which type this should be
    /// <summary> Additional input for the task. </summary>
    [JsonPropertyName("additional_input")]
    public object? AdditionalInput { get; set; }
    
    /// <summary> A list of artifacts that the task has produced. </summary>
    [JsonPropertyName("artifacts")] 
    public List<Artifact>? Artifacts { get; set; }
}