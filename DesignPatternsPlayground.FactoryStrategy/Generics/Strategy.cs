namespace DesignPatternsPlayground.FactoryStrategy.Generics;

internal interface IStrategy
{
    bool CanHandle(int logicType);

    void DoLogic();
}

internal interface IStrategyA : IStrategy
{
}

internal interface IStrategyB : IStrategy
{
}

internal class StrategyA : IStrategyA
{
    public bool CanHandle(int logicType) => logicType % 2 == 0;

    public void DoLogic()
    {
        Console.WriteLine("StrategyA.DoLogic");
    }
}

internal class StrategyB : IStrategyB
{
    public bool CanHandle(int logicType) => logicType % 2 == 1;

    public void DoLogic()
    {
        Console.WriteLine("StrategyB.DoLogic");
    }
}