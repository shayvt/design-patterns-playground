namespace DesignPatternsPlayground.FactoryStrategy.ServiceCallFactory;

internal interface IService
{
    void DoServiceWork(int logicType);
}

internal class Service(IStrategyFactory strategyFactory) : IService
{
    public void DoServiceWork(int logicType)
    {
        Console.WriteLine($"Start DoServiceWork");

        var strategy = strategyFactory.GetStrategy(logicType);

        strategy.DoLogic();

        Console.WriteLine($"End DoServiceWork");
    }
}
