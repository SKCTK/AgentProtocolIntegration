using AgentProtocol.Sdk.Models.Enums;

namespace AgentProtocol.Sdk.Models;

// TODO: add xml annotations to all types
public class Step
{
    public string StepId { get; set; }
    public string TaskId { get; set; }
    public string Name { get; set; }
    public StepStatus Status { get; set; }
    public string Input { get; set; }
    public object? AdditionalInput { get; set; }
    public string Output { get; set; }
    public object? AdditionalOutput { get; set; }
    public bool IsLast { get; set; }
    public List<Artifact>? Artifacts { get; set; }
}