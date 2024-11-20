namespace DesignPatternsPlayground.FactoryStrategy.Generics;

internal interface IServiceFactory
{
    IService GetService(int logicType);
}

internal class ServiceFactory(IEnumerable<IService> services) : IServiceFactory
{
    public IService GetService(int logicType)
    {
        return services.Single(s => s.CanHandle(logicType));
    }
}
