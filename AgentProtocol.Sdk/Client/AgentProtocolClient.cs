using AgentProtocol.Sdk.Client.Abstractions;
using AgentProtocol.Sdk.Client.Requests;
using AgentProtocol.Sdk.Models;
using AgentProtocol.Sdk.Models.Task;

namespace AgentProtocol.Sdk.Client;

public class AgentProtocolClient : IAgentProtocolClient
{
    private readonly string _endpoint;
    private readonly HttpClient _httpClient;
    
    public AgentProtocolClient(string endpoint, HttpClient httpClient)
    {
        _endpoint = endpoint;
        _httpClient = httpClient;
    }
    
    public async Task<AgentTask> CreateTaskAsync(CreateTaskRequest request, CancellationToken cancellationToken = default)
    {
        
        
        return new AgentTask();
    }

    public async Task<TaskListResponse> GetTasksAsync(int? currentPage = null, int? pageSize = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task<AgentTask> GetTaskAsync(string taskId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}