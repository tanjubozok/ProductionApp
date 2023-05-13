namespace ProductionApp.Common.Abstract;

internal interface IResponse<T> : IResponse
    where T : class, new()
{
    T? Data { get; set; }
}
