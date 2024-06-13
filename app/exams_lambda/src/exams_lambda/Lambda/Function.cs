using Amazon.Lambda.Core;
using exams_lambda.Dto;


// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace exams_lambda;

public class Function
{
    public Function()
    {

    }
    public async Task<BedrockResponse> FunctionHandler(BedrockRequest evnt, ILambdaContext context)
    {
        return new BedrockResponse();
    }

    private async Task ProcessMessageAsync(SQSEvent.SQSMessage message, ILambdaContext context)
    {
        await Task.CompletedTask;
    }
}