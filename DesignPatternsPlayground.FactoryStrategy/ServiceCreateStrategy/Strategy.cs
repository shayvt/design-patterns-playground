namespace DesignPatternsPlayground.FactoryStrategy.ServiceCreateStrategy;

internal interface IStrategy
{
    bool CanHandle(int logicType);

    void DoLogic();
}

internal class StrategyA : IStrategy
{
    public bool CanHandle(int logicType) => logicType % 2 == 0;

    public void DoLogic()
    {
        Console.WriteLine("StrategyA.DoLogic");
    }
}

internal class StrategyB : IStrategy
{
    public bool CanHandle(int logicType) => logicType % 2 == 1;

    public void DoLogic()
    {
        Console.WriteLine("StrategyB.DoLogic");
    }
}