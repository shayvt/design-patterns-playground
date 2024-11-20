using DesignPatternsPlayground.FactoryStrategy.ServiceParameter;
using Microsoft.Extensions.DependencyInjection;

ServiceCollection services = new();

services.AddTransient<IStrategyFactory, StrategyFactory>();

services.AddTransient<IStrategy, StrategyA>();
services.AddTransient<IStrategy, StrategyB>();

services.AddTransient<IService, Service>();

var serviceProvider = services.BuildServiceProvider();

var service = serviceProvider.GetRequiredService<IService>();
var strategyFactory = serviceProvider.GetRequiredService<IStrategyFactory>();

service.DoServiceWork(strategyFactory.GetStrategy(0));
service.DoServiceWork(strategyFactory.GetStrategy(1));