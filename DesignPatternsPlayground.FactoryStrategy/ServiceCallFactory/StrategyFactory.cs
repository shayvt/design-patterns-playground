namespace DesignPatternsPlayground.FactoryStrategy.ServiceCallFactory;

internal interface IStrategyFactory
{
    IStrategy GetStrategy(int logicType);
}

internal class StrategyFactory(IEnumerable<IStrategy> services) : IStrategyFactory
{
    public IStrategy GetStrategy(int logicType) =>
        services.Single(s => s.CanHandle(logicType));
}