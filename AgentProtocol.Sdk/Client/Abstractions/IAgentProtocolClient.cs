using AgentProtocol.Sdk.Client.Requests;
using AgentProtocol.Sdk.Models;
using AgentProtocol.Sdk.Models.Task;

namespace AgentProtocol.Sdk.Client.Abstractions;

// Each endpoint represents a separate agent
// Probably use some facade pattern to create a client for each agent
public interface IAgentProtocolClient
{
    Task<AgentTask> CreateTaskAsync(CreateTaskRequest request, CancellationToken cancellationToken = default);
    Task<TaskListResponse> GetTasksAsync(int? currentPage = null, int? pageSize = null, CancellationToken cancellationToken = default);
    Task<AgentTask> GetTaskAsync(string taskId, CancellationToken cancellationToken = default); 
}