namespace DesignPatternsPlayground.FactoryStrategy.ServiceParameter;

internal interface IService
{
    void DoServiceWork(IStrategy strategy);
}

internal class Service() : IService
{
    public void DoServiceWork(IStrategy strategy)
    {
        Console.WriteLine($"Start DoServiceWork");

        strategy.DoLogic();

        Console.WriteLine($"End DoServiceWork");
    }
}
