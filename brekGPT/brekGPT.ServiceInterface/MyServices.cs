using ServiceStack;
using brekGPT.ServiceModel;

namespace brekGPT.ServiceInterface;

public class MyServices : Service
{
    public object Any(Hello request)
    {
        return new HelloResponse { Result = $"Hello, {request.Name}!" };
    }
}