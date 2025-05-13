using AgentProtocol.Sdk.Client.Requests;
using AgentProtocol.Sdk.Models;

namespace AgentProtocol.Sdk.Client.Abstractions;

// Each endpoint represents a separate agent
public interface IAgentProtocolClient
{
    Task<AgentTask> CreateTaskAsync(CreateTaskRequest request, CancellationToken cancellationToken = default);
    
}