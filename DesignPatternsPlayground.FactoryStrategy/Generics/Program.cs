//using DesignPatternsPlayground.FactoryStrategy.Generics;
//using Microsoft.Extensions.DependencyInjection;

//ServiceCollection services = new();

//services.AddTransient<IServiceFactory, ServiceFactory>();

//services.AddTransient<IStrategyA, StrategyA>();
//services.AddTransient<IStrategyB, StrategyB>();

//services.AddTransient<IService, Service<IStrategyA>>();
//services.AddTransient<IService, Service<IStrategyB>>();

//var serviceProvider = services.BuildServiceProvider();

//var serviceFactory = serviceProvider.GetRequiredService<IServiceFactory>();

//serviceFactory.GetService(0).DoServiceWork();
//serviceFactory.GetService(1).DoServiceWork();