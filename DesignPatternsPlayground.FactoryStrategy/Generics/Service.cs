namespace DesignPatternsPlayground.FactoryStrategy.Generics;

internal interface IService
{
    bool CanHandle(int logicType);

    void DoServiceWork();
}

internal class Service<TStrategy>(TStrategy _strategy) : IService
    where TStrategy : IStrategy
{
    public bool CanHandle(int logicType) => _strategy.CanHandle(logicType);

    public void DoServiceWork()
    {
        Console.WriteLine($"Start DoServiceWork");

        _strategy.DoLogic();

        Console.WriteLine($"End DoServiceWork");
    }
}
