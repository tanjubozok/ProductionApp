using ProductionApp.Common.Abstract;
using ProductionApp.Common.ComplexTypes;

namespace ProductionApp.Common.ResponseObjects;

public class Response<T> : Response, IResponse<T>
    where T : class, new()
{
    public Response(ResponseType responseType)
        : base(responseType)
    {
    }

    public Response(ResponseType responseType, string message)
        : base(responseType, message)
    {
    }

    public Response(ResponseType responseType, T data)
        : base(responseType)
    {
        this.Data = data;
    }

    public T? Data { get; set; }
}
