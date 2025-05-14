namespace AgentProtocol.Sdk.Models.Task;

public class TaskListResponse
{
    public List<AgentTask> Tasks { get; set; }
    public Pagination Pagination { get; set; }
}