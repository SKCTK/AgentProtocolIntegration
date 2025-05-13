namespace AgentProtocol.Sdk.Models;

/// <summary> Task that defines specific goal for agent </summary>
public class Task
{
    /// <summary> The Id of task. </summary> 
    public string TaskId { get; set; }
    
    /// <summary> Input prompt for the task. </summary> 
    public string Input { get; set; }
    
    // TODO: find out which type this should be
    /// <summary> Additional input for the task. </summary> 
    public object? AdditionalInput { get; set; }
    
    /// <summary> The steps of the task. </summary> 
    public List<Step>? Steps { get; set; }
    
    /// <summary> A list of artifacts that the task has produced. </summary> 
    public List<Artifact>? Artifacts { get; set; }
}