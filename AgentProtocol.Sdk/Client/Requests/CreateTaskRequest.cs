using System.Text.Json.Serialization;

namespace AgentProtocol.Sdk.Client.Requests;

public class CreateTaskRequest
{
    [JsonPropertyName("input")]
    public string Input { get; set; }
    
    [JsonPropertyName("additional_input")]
    public object AdditionalInput { get; set; }
}