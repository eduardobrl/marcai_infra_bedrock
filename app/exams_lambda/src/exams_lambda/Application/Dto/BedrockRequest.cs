using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exams_lambda.Dto
{
public class Parameter
{
    public string name { get; set; }
    public string type { get; set; }
    public string value { get; set; }
}

public class Content
{
    public Dictionary<string, ContentProperty> properties { get; set; }
}

public class ContentProperty
{
    public string Name { get; set; }
    public string Type { get; set; }
    public string Value { get; set; }
}

public class BedrockRequest
{
    public string MessageVersion { get; set; }
    public Agent Agent { get; set; }
    public string InputText { get; set; }
    public string SessionId { get; set; }
    public string ActionGroup { get; set; }
    public string ApiPath { get; set; }
    public string HttpMethod { get; set; }
    public List<Parameter> Parameters { get; set; }
    public RequestBody RequestBody { get; set; }
    public Dictionary<string, string> SessionAttributes { get; set; }
    public Dictionary<string, string> PromptSessionAttributes { get; set; }
}

public class Agent
{
    public string Name { get; set; }
    public string Id { get; set; }
    public string Alias { get; set; }
    public string Version { get; set; }
}

public class RequestBody
{
    public Content Content { get; set; }
}
}